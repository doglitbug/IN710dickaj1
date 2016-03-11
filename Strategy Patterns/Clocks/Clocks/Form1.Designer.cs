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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.rbDigital = new System.Windows.Forms.RadioButton();
            this.rbAnalogue = new System.Windows.Forms.RadioButton();
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
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Clock";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(6, 48);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop Clock";
            this.btnStop.UseVisualStyleBackColor = true;
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
            // 
            // rbAnalogue
            // 
            this.rbAnalogue.AutoSize = true;
            this.rbAnalogue.Location = new System.Drawing.Point(314, 51);
            this.rbAnalogue.Name = "rbAnalogue";
            this.rbAnalogue.Size = new System.Drawing.Size(70, 17);
            this.rbAnalogue.TabIndex = 3;
            this.rbAnalogue.TabStop = true;
            this.rbAnalogue.Text = "Analogue";
            this.rbAnalogue.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 407);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Strategy Clocks";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAnalogue;
        private System.Windows.Forms.RadioButton rbDigital;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
    }
}

