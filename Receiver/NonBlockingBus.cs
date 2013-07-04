using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyNetQ;
using EasyNetQ.FluentConfiguration;

namespace Receiver
{
    internal class NonBlockingBus : IDisposable
    {
        private readonly IList<Action> resubscribeActions = new List<Action>();
        private IBus transientBus;
        private readonly IBus persistentBus;
        private readonly ushort Prefetch;

        private static readonly object Sequentialiser = new object();

        public NonBlockingBus(ushort prefetch)
        {
            Prefetch = prefetch;
            transientBus = Bus.Imme(prefetch);
            persistentBus = Bus.Imme(prefetch);
        }

        /// <summary>
        /// These subscriptions will cause NonBlocking subscriptions to be deregistered so that they won't be queued.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="subscriptionId"></param>
        /// <param name="onMessage"></param>
        /// <param name="configure"></param>
        public void BlockingSubscribe<T>(string subscriptionId, Action<T> onMessage, Action<ISubscriptionConfiguration<T>> configure)
        {
            persistentBus.Subscribe<T>(subscriptionId, x =>
                {
                    lock (Sequentialiser)
                    {
                        transientBus.Dispose();
                        onMessage(x);
                        Resubscribe();
                    }
                }, configure);
        }

        /// <summary>
        /// These subscriptions will be queued behind Blocking subscriptions
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="subscriptionId"></param>
        /// <param name="onMessage"></param>
        /// <param name="configure"></param>
        public void BlockableSubscribe<T>(string subscriptionId, Action<T> onMessage, Action<ISubscriptionConfiguration<T>> configure)
        {
            persistentBus.Subscribe<T>(subscriptionId, onMessage, configure);
        }

        private void Resubscribe()
        {
            transientBus = Bus.Imme(Prefetch);
            foreach (var subscribeAction in resubscribeActions)
            {
                subscribeAction();
            }
        }

        /// <summary>
        /// These subscriptions will be deregistered when a Blocking subscription is active, so other consumers will get them
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="subscriptionId"></param>
        /// <param name="onMessage"></param>
        /// <param name="configure"></param>
        public void NonBlockingSubscribe<T>(string subscriptionId, Action<T> onMessage, Action<ISubscriptionConfiguration<T>> configure)
        {

            Action subscribeAction = () => { lock (Sequentialiser) // ensure transient bus is available for subscribing to
            {
                transientBus.Subscribe<T>(subscriptionId, x =>
                    {
                        lock (Sequentialiser) // ensure messages are handled sequentially
                        {
                            onMessage(x);
                        }
                    }, configure);
            } };
            resubscribeActions.Add(subscribeAction);
            subscribeAction();
        }

        public void Dispose()
        {
            transientBus.Dispose();
            persistentBus.Dispose();
        }
    }
}
