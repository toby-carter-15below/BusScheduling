using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyNetQ;

namespace Receiver
{
    public partial class RecForm : Form
    {
        #region formy bits and utility stuff
        public RecForm()
        {
            InitializeComponent();
            this.Closing += RecForm_Closing;
        }

        private void RecForm_Closing(object sender, CancelEventArgs e)
        {
            CloseBuses();
            Thread.Sleep(500);
        }

        private void ClearOutput_Click(object sender, EventArgs e)
        {
            output.Clear();
        }


        private void SpawnReceiver_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Receiver.exe");
        }

        private delegate void DisplayCallback(string message);

        private void DisplayMessage(string message)
        {
            if (this.output.InvokeRequired)
            {
                DisplayCallback d = new DisplayCallback(DisplayMessage);
                this.Invoke(d, new object[] {message});
            }
            else
            {
                output.AppendText(message + Environment.NewLine);
            }
        }

        private ushort GetPrefetch()
        {
            if (prefetch0.Checked) return 0;
            if (prefetch1.Checked) return 1;
            return 50;
        }

        private void ApplyBusConfig_Click(object sender, EventArgs e)
        {
            Bus1Setup();
            Bus2Setup();
            NonBlockingBusSetup();
            AsyncBus1Setup();
            AsyncBus2Setup();
        }

        private int SimulateWork(int multiplier = 1)
        {
            int a = 0;
            for (var l = 0; l < multiplier; l++)
            {
                for (var i = 0; i < 7000000; i++)
                {
                    a += i - l;
                    if (i%10 == 0)
                        a--;
                }
            }
            return a;
        }
        private void ResetBusConfig_Click(object sender, EventArgs e)
        {
            CloseBuses();
            Thread.Sleep(100);
            chkBus1High.Checked = false;
            chkBus1High2.Checked = false;
            chkBus1LongLow.Checked = false;
            chkBus1Low.Checked = false;

            chkBus2High.Checked = false;
            chkBus2High2.Checked = false;

            chkNonBlocking.Checked = false;

            chkAsyncHigh.Checked = false;
            chkAsyncHigh2.Checked = false;
            chkAsyncLongLow.Checked = false;
            chkAsyncLow.Checked = false;

            chkAsync2High1.Checked = false;
            chkAsync2High2.Checked = false;

            prefetch50.Checked = true;

            output.Clear();

            ApplyBusConfig_Click(null, null);
        }

        private void CloseBuses()
        {
            if (bus1 != null) bus1.Dispose();
            if (bus2 != null) bus2.Dispose();
            if (nonBlockingBus != null) nonBlockingBus.Dispose();
            if (asyncBus1 != null) asyncBus1.Dispose();
            if (asyncBus2 != null) asyncBus2.Dispose();
        }

        #endregion


        private IBus bus1;
        private IBus bus2;
        private NonBlockingBus nonBlockingBus;
        private IBus asyncBus1;
        private IBus asyncBus2;

        private void ShortHandler(string message)
        {
            var meh = SimulateWork(ushort.Parse(ShortJobSize.Text));
            DisplayMessage(message);
        }

        private void LongHandler(string message)
        {
            DisplayMessage(message + " START...");
            var meh = SimulateWork(ushort.Parse(LongJobSize.Text));
            DisplayMessage(message + " END...");
        }

        private void Bus1Setup()
        {
            ResetBus(ref bus1);

            if (chkBus1High.Checked) bus1.Subscribe<HackyMessage>("Rec-High-Short", m => ShortHandler("B1-High1 :" + m.Data), conf => conf.WithTopic("High-Short"));
            if (chkBus1High2.Checked) bus1.Subscribe<HackyMessage>("Rec-High-Short", m => ShortHandler("B1-High2 :" + m.Data), conf => conf.WithTopic("High-Short"));
            if (chkBus1Low.Checked) bus1.Subscribe<HackyMessage>("Rec-Low-Short", m => ShortHandler("B1-Low :" + m.Data), conf => conf.WithTopic("Low-Short")); 
            if (chkBus1LongLow.Checked) bus1.Subscribe<HackyMessage>("Rec-Low-Long", m => LongHandler("B1-Low&Long :" + m.Data), conf => conf.WithTopic("Low-Long"));
        }


        private void ResetBus(ref IBus bus)
        {
            if (bus != null) bus.Dispose();

            bus = Bus.Imme(GetPrefetch());
        }


        private void Bus2Setup()
        {
            ResetBus(ref bus2);

            if (chkBus2High.Checked) bus2.Subscribe<HackyMessage>("Rec-High-Short", m => ShortHandler("B2-High1 :" + m.Data), conf => conf.WithTopic("High-Short"));
            if (chkBus2High2.Checked) bus2.Subscribe<HackyMessage>("Rec-High-Short", m => ShortHandler("B2-High2 :" + m.Data), conf => conf.WithTopic("High-Short"));
        }




        private void NonBlockingBusSetup()
        {
            if (nonBlockingBus != null) nonBlockingBus.Dispose();
            nonBlockingBus = new NonBlockingBus(GetPrefetch());

            if (chkNonBlocking.Checked)
            {
                nonBlockingBus.BlockingSubscribe<HackyMessage>("Rec-Low-Long",  m => LongHandler("NB-low-long:" + m.Data), conf => conf.WithTopic("Low-Long"));

                nonBlockingBus.BlockableSubscribe<HackyMessage>("Rec-Low-Short",  m => ShortHandler("NB-low-short:" + m.Data), conf => conf.WithTopic("Low-Short"));

                nonBlockingBus.NonBlockingSubscribe<HackyMessage>("Rec-High-Short",  m => ShortHandler("NB-high-short:" + m.Data), conf => conf.WithTopic("High-Short"));
            }
        }
        private void AsyncBus1Setup()
        {
            ResetBus(ref asyncBus1);

            if (chkAsyncHigh.Checked) 
                asyncBus1.SubscribeAsync<HackyMessage>("Rec-High-Short", m => Task.Factory.StartNew(() => ShortHandler("Async-High1 :" + m.Data)), conf => conf.WithTopic("High-Short"));
            if (chkAsyncHigh2.Checked)
                asyncBus1.SubscribeAsync<HackyMessage>("Rec-High-Short", m => Task.Factory.StartNew(() => ShortHandler("Async-High2 :" + m.Data)), conf => conf.WithTopic("High-Short"));
            if (chkAsyncLow.Checked)
                asyncBus1.SubscribeAsync<HackyMessage>("Rec-Low-Short", m => Task.Factory.StartNew(() => ShortHandler("Async-Low :" + m.Data)), conf => conf.WithTopic("Low-Short"));
            if (chkAsyncLongLow.Checked)
            {
                asyncBus1.SubscribeAsync<HackyMessage>("Rec-Low-Long", m => Task.Factory.StartNew(() => LongHandler("Async-Low&Long :" + m.Data)), conf => conf.WithTopic("Low-Long"));
                //asyncBus1.SubscribeAsync<HackyMessage>("Rec-Low-Long", m => Task.Factory.StartNew(() => LongHandler("Async-Low&Long2 :" + m.Data)), conf => conf.WithTopic("Low-Long"));
            }
        }
        private void AsyncBus2Setup()
        {
            ResetBus(ref asyncBus2);

            if (chkAsync2High1.Checked) 
                asyncBus2.SubscribeAsync<HackyMessage>("Rec-High-Short", m => Task.Factory.StartNew(() => ShortHandler("Async2-High1 :" + m.Data)), conf => conf.WithTopic("High-Short"));
            if (chkAsync2High2.Checked)
                asyncBus2.SubscribeAsync<HackyMessage>("Rec-High-Short", m => Task.Factory.StartNew(() => ShortHandler("Async2-High2 :" + m.Data)), conf => conf.WithTopic("High-Short"));
        }
    }

}
