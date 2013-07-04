using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyNetQ;

namespace Receiver
{
    public class Bus
    {
        private class STFU : EasyNetQ.IEasyNetQLogger
        {
            public void DebugWrite(string format, params object[] args)
            {

            }

            public void InfoWrite(string format, params object[] args)
            {
            }

            public void ErrorWrite(string format, params object[] args)
            {
            }

            public void ErrorWrite(Exception exception)
            {
            }
        }


        public static IBus Imme(ushort prefetch=50)
        {
            string connectionString = "host=mq01.QAT.15b.local;username=8A-QAT;password=He8JEc2T;virtualHost=8A-QAT;";
            var conf = new EasyNetQ.ConnectionConfiguration();
            var host = new EasyNetQ.HostConfiguration();
            host.Host = "mq01.qat.15b.local";
            conf.Hosts =  new List<IHostConfiguration>{host};
            conf.VirtualHost = "8A-QAT";
            conf.UserName = "8A-QAT";
            conf.Password = "He8JEc2T";

            conf.PrefetchCount = prefetch;
            conf.Validate();

            return EasyNetQ.RabbitHutch.CreateBus(conf, reg => reg.Register<IEasyNetQLogger>(x => new STFU()));
        }
    }

    public class HackyMessage
    {
        public string Data { get; set; }
    }

    public enum PriorityTopic
    {
        High,
        Low
    }

    public enum RunningTopic
    {
        Short,
        Long
    }
}
