namespace Sender
{
    partial class SendForm
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
            this.SendHigh = new System.Windows.Forms.Button();
            this.SendLow = new System.Windows.Forms.Button();
            this.NumberToSend = new System.Windows.Forms.TextBox();
            this.SendBoth = new System.Windows.Forms.Button();
            this.chkDripfeedHigh = new System.Windows.Forms.CheckBox();
            this.SendLongLow = new System.Windows.Forms.Button();
            this.chkDripfeedLow = new System.Windows.Forms.CheckBox();
            this.LongRunningToSend = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SendHigh
            // 
            this.SendHigh.Location = new System.Drawing.Point(13, 13);
            this.SendHigh.Name = "SendHigh";
            this.SendHigh.Size = new System.Drawing.Size(259, 23);
            this.SendHigh.TabIndex = 0;
            this.SendHigh.Text = "Send X High Priority";
            this.SendHigh.UseVisualStyleBackColor = true;
            this.SendHigh.Click += new System.EventHandler(this.SendHigh_Click);
            // 
            // SendLow
            // 
            this.SendLow.Location = new System.Drawing.Point(12, 42);
            this.SendLow.Name = "SendLow";
            this.SendLow.Size = new System.Drawing.Size(259, 23);
            this.SendLow.TabIndex = 1;
            this.SendLow.Text = "Send X Low Priority";
            this.SendLow.UseVisualStyleBackColor = true;
            this.SendLow.Click += new System.EventHandler(this.SendLow_Click);
            // 
            // NumberToSend
            // 
            this.NumberToSend.Location = new System.Drawing.Point(279, 13);
            this.NumberToSend.Name = "NumberToSend";
            this.NumberToSend.Size = new System.Drawing.Size(67, 20);
            this.NumberToSend.TabIndex = 2;
            this.NumberToSend.Text = "50";
            // 
            // SendBoth
            // 
            this.SendBoth.Location = new System.Drawing.Point(12, 71);
            this.SendBoth.Name = "SendBoth";
            this.SendBoth.Size = new System.Drawing.Size(259, 23);
            this.SendBoth.TabIndex = 3;
            this.SendBoth.Text = "Send X Both";
            this.SendBoth.UseVisualStyleBackColor = true;
            this.SendBoth.Click += new System.EventHandler(this.SendBoth_Click);
            // 
            // chkDripfeedHigh
            // 
            this.chkDripfeedHigh.AutoSize = true;
            this.chkDripfeedHigh.Location = new System.Drawing.Point(13, 101);
            this.chkDripfeedHigh.Name = "chkDripfeedHigh";
            this.chkDripfeedHigh.Size = new System.Drawing.Size(91, 17);
            this.chkDripfeedHigh.TabIndex = 4;
            this.chkDripfeedHigh.Text = "Dripfeed High";
            this.chkDripfeedHigh.UseVisualStyleBackColor = true;
            this.chkDripfeedHigh.CheckedChanged += new System.EventHandler(this.Dripfeed_CheckedChanged);
            // 
            // SendLongLow
            // 
            this.SendLongLow.Location = new System.Drawing.Point(13, 124);
            this.SendLongLow.Name = "SendLongLow";
            this.SendLongLow.Size = new System.Drawing.Size(259, 23);
            this.SendLongLow.TabIndex = 5;
            this.SendLongLow.Text = "Send X Long Running Low Priority";
            this.SendLongLow.UseVisualStyleBackColor = true;
            this.SendLongLow.Click += new System.EventHandler(this.SendLongLow_Click);
            // 
            // chkDripfeedLow
            // 
            this.chkDripfeedLow.AutoSize = true;
            this.chkDripfeedLow.Location = new System.Drawing.Point(110, 100);
            this.chkDripfeedLow.Name = "chkDripfeedLow";
            this.chkDripfeedLow.Size = new System.Drawing.Size(89, 17);
            this.chkDripfeedLow.TabIndex = 6;
            this.chkDripfeedLow.Text = "Dripfeed Low";
            this.chkDripfeedLow.UseVisualStyleBackColor = true;
            this.chkDripfeedLow.CheckedChanged += new System.EventHandler(this.Dripfeed_CheckedChanged);
            // 
            // LongRunningToSend
            // 
            this.LongRunningToSend.Location = new System.Drawing.Point(278, 126);
            this.LongRunningToSend.Name = "LongRunningToSend";
            this.LongRunningToSend.Size = new System.Drawing.Size(67, 20);
            this.LongRunningToSend.TabIndex = 7;
            this.LongRunningToSend.Text = "1";
            // 
            // SendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 158);
            this.Controls.Add(this.LongRunningToSend);
            this.Controls.Add(this.chkDripfeedLow);
            this.Controls.Add(this.SendLongLow);
            this.Controls.Add(this.chkDripfeedHigh);
            this.Controls.Add(this.SendBoth);
            this.Controls.Add(this.NumberToSend);
            this.Controls.Add(this.SendLow);
            this.Controls.Add(this.SendHigh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "SendForm";
            this.Text = "Sender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendHigh;
        private System.Windows.Forms.Button SendLow;
        private System.Windows.Forms.TextBox NumberToSend;
        private System.Windows.Forms.Button SendBoth;
        private System.Windows.Forms.CheckBox chkDripfeedHigh;
        private System.Windows.Forms.Button SendLongLow;
        private System.Windows.Forms.CheckBox chkDripfeedLow;
        private System.Windows.Forms.TextBox LongRunningToSend;
    }
}

