namespace Clocks
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAnalogue = new System.Windows.Forms.RadioButton();
            this.rbDigital = new System.Windows.Forms.RadioButton();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.roundClock = new AnalogClockControl.AnalogClock();
            this.lblDigital = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAnalogue);
            this.groupBox1.Controls.Add(this.rbDigital);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // rbAnalogue
            // 
            this.rbAnalogue.AutoSize = true;
            this.rbAnalogue.Checked = true;
            this.rbAnalogue.Location = new System.Drawing.Point(314, 51);
            this.rbAnalogue.Name = "rbAnalogue";
            this.rbAnalogue.Size = new System.Drawing.Size(70, 17);
            this.rbAnalogue.TabIndex = 3;
            this.rbAnalogue.TabStop = true;
            this.rbAnalogue.Text = "Analogue";
            this.rbAnalogue.UseVisualStyleBackColor = true;
            this.rbAnalogue.CheckedChanged += new System.EventHandler(this.rbAnalogue_CheckedChanged);
            // 
            // rbDigital
            // 
            this.rbDigital.AutoSize = true;
            this.rbDigital.Location = new System.Drawing.Point(314, 19);
            this.rbDigital.Name = "rbDigital";
            this.rbDigital.Size = new System.Drawing.Size(54, 17);
            this.rbDigital.TabIndex = 2;
            this.rbDigital.TabStop = true;
            this.rbDigital.Text = "Digital";
            this.rbDigital.UseVisualStyleBackColor = true;
            this.rbDigital.CheckedChanged += new System.EventHandler(this.rbDigital_CheckedChanged);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(6, 48);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop Clock";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Clock";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // roundClock
            // 
            this.roundClock.Draw1MinuteTicks = true;
            this.roundClock.Draw5MinuteTicks = true;
            this.roundClock.HourHandColor = System.Drawing.Color.DarkMagenta;
            this.roundClock.Location = new System.Drawing.Point(53, 98);
            this.roundClock.MinuteHandColor = System.Drawing.Color.Green;
            this.roundClock.Name = "roundClock";
            this.roundClock.SecondHandColor = System.Drawing.Color.Red;
            this.roundClock.Size = new System.Drawing.Size(297, 297);
            this.roundClock.TabIndex = 1;
            this.roundClock.TicksColor = System.Drawing.Color.Black;
            // 
            // lblDigital
            // 
            this.lblDigital.AutoSize = true;
            this.lblDigital.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigital.Location = new System.Drawing.Point(57, 206);
            this.lblDigital.Name = "lblDigital";
            this.lblDigital.Size = new System.Drawing.Size(293, 76);
            this.lblDigital.TabIndex = 2;
            this.lblDigital.Text = "00:00:00";
            this.lblDigital.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 407);
            this.Controls.Add(this.lblDigital);
            this.Controls.Add(this.roundClock);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Strategy Clocks";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAnalogue;
        private System.Windows.Forms.RadioButton rbDigital;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private AnalogClockControl.AnalogClock roundClock;
        private System.Windows.Forms.Label lblDigital;
    }
}

