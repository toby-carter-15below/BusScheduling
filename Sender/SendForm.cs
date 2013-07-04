using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyNetQ;
using Receiver;

namespace Sender
{
    public partial class SendForm : Form
    {
        private IBus bus = Receiver.Bus.Imme();

        public SendForm()
        {
            InitializeComponent();

            DripfeedTimer.Interval = 500;
            DripfeedTimer.Tick += (o, e) => Dripfeed();
        }

        private void SendHigh_Click(object sender, EventArgs e)
        {
            SendShortLoop((p, x) => Publish(p, x, PriorityTopic.High, RunningTopic.Short));
        }

        private void SendLow_Click(object sender, EventArgs e)
        {
            SendShortLoop((p,x) => Publish(p, x, PriorityTopic.Low, RunningTopic.Short));
        }

        private static void Publish(IPublishChannel p, int x, PriorityTopic priority, RunningTopic running)
        {
            p.Publish(new HackyMessage{Data=priority.ToString().First() + ":" + x}, conf=>conf.WithTopic(priority.ToString() + "-" + running.ToString()));
        }

        private void SendBoth_Click(object sender, EventArgs e)
        {

            SendShortLoop((p, x) => { Publish(p, x, PriorityTopic.High, RunningTopic.Short); Publish(p, x, PriorityTopic.Low, RunningTopic.Short); });
        }

        private void Dripfeed()
        {
            using (var pubber = bus.OpenPublishChannel())
            {
                if (chkDripfeedHigh.Checked)
                    pubber.Publish(new HackyMessage{Data="dripfeed high:" + DateTime.Now.Second + "." + DateTime.Now.Millisecond.ToString().PadLeft(3,'0')}, conf=>conf.WithTopic("High-Short"));
                if (chkDripfeedLow.Checked)
                    pubber.Publish(new HackyMessage{Data="dripfeed low:" + DateTime.Now.Second + "." + DateTime.Now.Millisecond.ToString().PadLeft(3,'0')}, conf=>conf.WithTopic("Low-Short"));
            }
        }
        private void SendShortLoop(Action<IPublishChannel,int> sender)
        {
            var count = int.Parse(NumberToSend.Text);
            SendLoop(sender, count);
        }
        private void SendLongLoop(Action<IPublishChannel,int> sender)
        {
            var count = int.Parse(LongRunningToSend.Text);
            SendLoop(sender, count);
        }
        private void SendLoop(Action<IPublishChannel, int> sender, int count)
        {
            this.Enabled = false;
            Application.DoEvents();

            using (var pubber = bus.OpenPublishChannel())
            {
                for (var index = 1; index <= count; index++)
                {
                    sender(pubber, index);
                }
            }

            this.Enabled = true;
        }

        private Timer DripfeedTimer = new Timer();

        private void Dripfeed_CheckedChanged(object sender, EventArgs e)
        {
                DripfeedTimer.Enabled = chkDripfeedHigh.Checked || chkDripfeedLow.Checked;
        }

        private void SendLongLow_Click(object sender, EventArgs e)
        {
            SendLongLoop((p,x) => Publish(p, x, PriorityTopic.Low, RunningTopic.Long));
        }



    }
}
