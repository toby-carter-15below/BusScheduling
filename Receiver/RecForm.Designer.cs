namespace Receiver
{
    partial class RecForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.output = new System.Windows.Forms.TextBox();
            this.SpawnReceiver = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBus1LongLow = new System.Windows.Forms.CheckBox();
            this.chkBus1High2 = new System.Windows.Forms.CheckBox();
            this.chkBus1Low = new System.Windows.Forms.CheckBox();
            this.chkBus1High = new System.Windows.Forms.CheckBox();
            this.prefetch0 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.prefetch50 = new System.Windows.Forms.RadioButton();
            this.prefetch1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkBus2High2 = new System.Windows.Forms.CheckBox();
            this.chkBus2High = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkNonBlocking = new System.Windows.Forms.CheckBox();
            this.ApplyBusConfig = new System.Windows.Forms.Button();
            this.ResetBusConfig = new System.Windows.Forms.Button();
            this.ShortJobSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LongJobSize = new System.Windows.Forms.TextBox();
            this.ClearOutput = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkAsyncLongLow = new System.Windows.Forms.CheckBox();
            this.chkAsyncLow = new System.Windows.Forms.CheckBox();
            this.chkAsyncHigh2 = new System.Windows.Forms.CheckBox();
            this.chkAsyncHigh = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkAsync2High2 = new System.Windows.Forms.CheckBox();
            this.chkAsync2High1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.Dock = System.Windows.Forms.DockStyle.Left;
            this.output.Location = new System.Drawing.Point(0, 0);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output.Size = new System.Drawing.Size(284, 586);
            this.output.TabIndex = 0;
            // 
            // SpawnReceiver
            // 
            this.SpawnReceiver.Location = new System.Drawing.Point(298, 411);
            this.SpawnReceiver.Name = "SpawnReceiver";
            this.SpawnReceiver.Size = new System.Drawing.Size(271, 23);
            this.SpawnReceiver.TabIndex = 2;
            this.SpawnReceiver.Text = "Spawn Receiver";
            this.SpawnReceiver.UseVisualStyleBackColor = true;
            this.SpawnReceiver.Click += new System.EventHandler(this.SpawnReceiver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBus1LongLow);
            this.groupBox1.Controls.Add(this.chkBus1High2);
            this.groupBox1.Controls.Add(this.chkBus1Low);
            this.groupBox1.Controls.Add(this.chkBus1High);
            this.groupBox1.Location = new System.Drawing.Point(298, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 46);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bus 1";
            // 
            // chkBus1LongLow
            // 
            this.chkBus1LongLow.AutoSize = true;
            this.chkBus1LongLow.Location = new System.Drawing.Point(183, 20);
            this.chkBus1LongLow.Name = "chkBus1LongLow";
            this.chkBus1LongLow.Size = new System.Drawing.Size(82, 17);
            this.chkBus1LongLow.TabIndex = 3;
            this.chkBus1LongLow.Text = "Long && Low";
            this.chkBus1LongLow.UseVisualStyleBackColor = true;
            // 
            // chkBus1High2
            // 
            this.chkBus1High2.AutoSize = true;
            this.chkBus1High2.Location = new System.Drawing.Point(61, 20);
            this.chkBus1High2.Name = "chkBus1High2";
            this.chkBus1High2.Size = new System.Drawing.Size(64, 17);
            this.chkBus1High2.TabIndex = 2;
            this.chkBus1High2.Text = "High #2";
            this.chkBus1High2.UseVisualStyleBackColor = true;
            // 
            // chkBus1Low
            // 
            this.chkBus1Low.AutoSize = true;
            this.chkBus1Low.Location = new System.Drawing.Point(131, 20);
            this.chkBus1Low.Name = "chkBus1Low";
            this.chkBus1Low.Size = new System.Drawing.Size(46, 17);
            this.chkBus1Low.TabIndex = 1;
            this.chkBus1Low.Text = "Low";
            this.chkBus1Low.UseVisualStyleBackColor = true;
            // 
            // chkBus1High
            // 
            this.chkBus1High.AutoSize = true;
            this.chkBus1High.Location = new System.Drawing.Point(7, 20);
            this.chkBus1High.Name = "chkBus1High";
            this.chkBus1High.Size = new System.Drawing.Size(48, 17);
            this.chkBus1High.TabIndex = 0;
            this.chkBus1High.Text = "High";
            this.chkBus1High.UseVisualStyleBackColor = true;
            // 
            // prefetch0
            // 
            this.prefetch0.AutoSize = true;
            this.prefetch0.Location = new System.Drawing.Point(434, 7);
            this.prefetch0.Name = "prefetch0";
            this.prefetch0.Size = new System.Drawing.Size(40, 17);
            this.prefetch0.TabIndex = 7;
            this.prefetch0.Text = "0!!!";
            this.prefetch0.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prefetch Queue Size";
            // 
            // prefetch50
            // 
            this.prefetch50.AutoSize = true;
            this.prefetch50.Checked = true;
            this.prefetch50.Location = new System.Drawing.Point(517, 7);
            this.prefetch50.Name = "prefetch50";
            this.prefetch50.Size = new System.Drawing.Size(37, 17);
            this.prefetch50.TabIndex = 5;
            this.prefetch50.TabStop = true;
            this.prefetch50.Text = "50";
            this.prefetch50.UseVisualStyleBackColor = true;
            // 
            // prefetch1
            // 
            this.prefetch1.AutoSize = true;
            this.prefetch1.Location = new System.Drawing.Point(480, 7);
            this.prefetch1.Name = "prefetch1";
            this.prefetch1.Size = new System.Drawing.Size(31, 17);
            this.prefetch1.TabIndex = 4;
            this.prefetch1.Text = "1";
            this.prefetch1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkBus2High2);
            this.groupBox2.Controls.Add(this.chkBus2High);
            this.groupBox2.Location = new System.Drawing.Point(298, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 50);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bus 2";
            // 
            // chkBus2High2
            // 
            this.chkBus2High2.AutoSize = true;
            this.chkBus2High2.Location = new System.Drawing.Point(61, 20);
            this.chkBus2High2.Name = "chkBus2High2";
            this.chkBus2High2.Size = new System.Drawing.Size(64, 17);
            this.chkBus2High2.TabIndex = 2;
            this.chkBus2High2.Text = "High #2";
            this.chkBus2High2.UseVisualStyleBackColor = true;
            // 
            // chkBus2High
            // 
            this.chkBus2High.AutoSize = true;
            this.chkBus2High.Location = new System.Drawing.Point(7, 20);
            this.chkBus2High.Name = "chkBus2High";
            this.chkBus2High.Size = new System.Drawing.Size(48, 17);
            this.chkBus2High.TabIndex = 0;
            this.chkBus2High.Text = "High";
            this.chkBus2High.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkNonBlocking);
            this.groupBox3.Location = new System.Drawing.Point(298, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 44);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Non-Blocking Subscription (not a good name)";
            // 
            // chkNonBlocking
            // 
            this.chkNonBlocking.AutoSize = true;
            this.chkNonBlocking.Location = new System.Drawing.Point(7, 20);
            this.chkNonBlocking.Name = "chkNonBlocking";
            this.chkNonBlocking.Size = new System.Drawing.Size(136, 17);
            this.chkNonBlocking.TabIndex = 0;
            this.chkNonBlocking.Text = "High, Low, Long && Low";
            this.chkNonBlocking.UseVisualStyleBackColor = true;
            // 
            // ApplyBusConfig
            // 
            this.ApplyBusConfig.Location = new System.Drawing.Point(298, 324);
            this.ApplyBusConfig.Name = "ApplyBusConfig";
            this.ApplyBusConfig.Size = new System.Drawing.Size(271, 23);
            this.ApplyBusConfig.TabIndex = 6;
            this.ApplyBusConfig.Text = "Apply Bus Config";
            this.ApplyBusConfig.UseVisualStyleBackColor = true;
            this.ApplyBusConfig.Click += new System.EventHandler(this.ApplyBusConfig_Click);
            // 
            // ResetBusConfig
            // 
            this.ResetBusConfig.Location = new System.Drawing.Point(298, 353);
            this.ResetBusConfig.Name = "ResetBusConfig";
            this.ResetBusConfig.Size = new System.Drawing.Size(271, 23);
            this.ResetBusConfig.TabIndex = 7;
            this.ResetBusConfig.Text = "Reset Buses";
            this.ResetBusConfig.UseVisualStyleBackColor = true;
            this.ResetBusConfig.Click += new System.EventHandler(this.ResetBusConfig_Click);
            // 
            // ShortJobSize
            // 
            this.ShortJobSize.Location = new System.Drawing.Point(379, 30);
            this.ShortJobSize.Name = "ShortJobSize";
            this.ShortJobSize.Size = new System.Drawing.Size(21, 20);
            this.ShortJobSize.TabIndex = 8;
            this.ShortJobSize.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Short Job Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Long Job Size";
            // 
            // LongJobSize
            // 
            this.LongJobSize.Location = new System.Drawing.Point(512, 30);
            this.LongJobSize.Name = "LongJobSize";
            this.LongJobSize.Size = new System.Drawing.Size(42, 20);
            this.LongJobSize.TabIndex = 10;
            this.LongJobSize.Text = "100";
            // 
            // ClearOutput
            // 
            this.ClearOutput.Location = new System.Drawing.Point(298, 382);
            this.ClearOutput.Name = "ClearOutput";
            this.ClearOutput.Size = new System.Drawing.Size(271, 23);
            this.ClearOutput.TabIndex = 12;
            this.ClearOutput.Text = "Clear Output";
            this.ClearOutput.UseVisualStyleBackColor = true;
            this.ClearOutput.Click += new System.EventHandler(this.ClearOutput_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkAsyncLongLow);
            this.groupBox4.Controls.Add(this.chkAsyncLow);
            this.groupBox4.Controls.Add(this.chkAsyncHigh2);
            this.groupBox4.Controls.Add(this.chkAsyncHigh);
            this.groupBox4.Location = new System.Drawing.Point(298, 214);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(271, 49);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Async Subscribers 1";
            // 
            // chkAsyncLongLow
            // 
            this.chkAsyncLongLow.AutoSize = true;
            this.chkAsyncLongLow.Location = new System.Drawing.Point(183, 19);
            this.chkAsyncLongLow.Name = "chkAsyncLongLow";
            this.chkAsyncLongLow.Size = new System.Drawing.Size(82, 17);
            this.chkAsyncLongLow.TabIndex = 3;
            this.chkAsyncLongLow.Text = "Long && Low";
            this.chkAsyncLongLow.UseVisualStyleBackColor = true;
            // 
            // chkAsyncLow
            // 
            this.chkAsyncLow.AutoSize = true;
            this.chkAsyncLow.Location = new System.Drawing.Point(128, 20);
            this.chkAsyncLow.Name = "chkAsyncLow";
            this.chkAsyncLow.Size = new System.Drawing.Size(46, 17);
            this.chkAsyncLow.TabIndex = 2;
            this.chkAsyncLow.Text = "Low";
            this.chkAsyncLow.UseVisualStyleBackColor = true;
            // 
            // chkAsyncHigh2
            // 
            this.chkAsyncHigh2.AutoSize = true;
            this.chkAsyncHigh2.Location = new System.Drawing.Point(61, 19);
            this.chkAsyncHigh2.Name = "chkAsyncHigh2";
            this.chkAsyncHigh2.Size = new System.Drawing.Size(64, 17);
            this.chkAsyncHigh2.TabIndex = 1;
            this.chkAsyncHigh2.Text = "High #2";
            this.chkAsyncHigh2.UseVisualStyleBackColor = true;
            // 
            // chkAsyncHigh
            // 
            this.chkAsyncHigh.AutoSize = true;
            this.chkAsyncHigh.Location = new System.Drawing.Point(7, 20);
            this.chkAsyncHigh.Name = "chkAsyncHigh";
            this.chkAsyncHigh.Size = new System.Drawing.Size(48, 17);
            this.chkAsyncHigh.TabIndex = 0;
            this.chkAsyncHigh.Text = "High";
            this.chkAsyncHigh.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkAsync2High2);
            this.groupBox5.Controls.Add(this.chkAsync2High1);
            this.groupBox5.Location = new System.Drawing.Point(298, 269);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(271, 49);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Async Subscribers 2";
            // 
            // chkAsync2High2
            // 
            this.chkAsync2High2.AutoSize = true;
            this.chkAsync2High2.Location = new System.Drawing.Point(61, 19);
            this.chkAsync2High2.Name = "chkAsync2High2";
            this.chkAsync2High2.Size = new System.Drawing.Size(64, 17);
            this.chkAsync2High2.TabIndex = 1;
            this.chkAsync2High2.Text = "High #2";
            this.chkAsync2High2.UseVisualStyleBackColor = true;
            // 
            // chkAsync2High1
            // 
            this.chkAsync2High1.AutoSize = true;
            this.chkAsync2High1.Location = new System.Drawing.Point(7, 20);
            this.chkAsync2High1.Name = "chkAsync2High1";
            this.chkAsync2High1.Size = new System.Drawing.Size(48, 17);
            this.chkAsync2High1.TabIndex = 0;
            this.chkAsync2High1.Text = "High";
            this.chkAsync2High1.UseVisualStyleBackColor = true;
            // 
            // RecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 586);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.ClearOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LongJobSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShortJobSize);
            this.Controls.Add(this.prefetch0);
            this.Controls.Add(this.ResetBusConfig);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prefetch50);
            this.Controls.Add(this.ApplyBusConfig);
            this.Controls.Add(this.prefetch1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SpawnReceiver);
            this.Controls.Add(this.output);
            this.Name = "RecForm";
            this.Text = "Receiver";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button SpawnReceiver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkBus1High2;
        private System.Windows.Forms.CheckBox chkBus1Low;
        private System.Windows.Forms.CheckBox chkBus1High;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkBus2High2;
        private System.Windows.Forms.CheckBox chkBus2High;
        private System.Windows.Forms.CheckBox chkBus1LongLow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton prefetch50;
        private System.Windows.Forms.RadioButton prefetch1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton prefetch0;
        private System.Windows.Forms.Button ApplyBusConfig;
        private System.Windows.Forms.Button ResetBusConfig;
        private System.Windows.Forms.CheckBox chkNonBlocking;
        private System.Windows.Forms.TextBox ShortJobSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LongJobSize;
        private System.Windows.Forms.Button ClearOutput;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkAsyncLongLow;
        private System.Windows.Forms.CheckBox chkAsyncLow;
        private System.Windows.Forms.CheckBox chkAsyncHigh2;
        private System.Windows.Forms.CheckBox chkAsyncHigh;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chkAsync2High2;
        private System.Windows.Forms.CheckBox chkAsync2High1;
    }
}

