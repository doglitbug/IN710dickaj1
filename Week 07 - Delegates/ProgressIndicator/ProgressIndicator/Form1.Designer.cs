namespace ProgressIndicator
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbSpinBox = new System.Windows.Forms.RadioButton();
            this.rbProgressBar = new System.Windows.Forms.RadioButton();
            this.rbTrackBar = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.probOutput = new System.Windows.Forms.ProgressBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTrackBar);
            this.groupBox1.Controls.Add(this.rbProgressBar);
            this.groupBox1.Controls.Add(this.rbSpinBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.probOutput);
            this.groupBox2.Controls.Add(this.numericUpDown);
            this.groupBox2.Location = new System.Drawing.Point(116, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 133);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // rbSpinBox
            // 
            this.rbSpinBox.AutoSize = true;
            this.rbSpinBox.Location = new System.Drawing.Point(6, 19);
            this.rbSpinBox.Name = "rbSpinBox";
            this.rbSpinBox.Size = new System.Drawing.Size(67, 17);
            this.rbSpinBox.TabIndex = 0;
            this.rbSpinBox.TabStop = true;
            this.rbSpinBox.Text = "Spin Box";
            this.rbSpinBox.UseVisualStyleBackColor = true;
            // 
            // rbProgressBar
            // 
            this.rbProgressBar.AutoSize = true;
            this.rbProgressBar.Location = new System.Drawing.Point(7, 43);
            this.rbProgressBar.Name = "rbProgressBar";
            this.rbProgressBar.Size = new System.Drawing.Size(85, 17);
            this.rbProgressBar.TabIndex = 1;
            this.rbProgressBar.TabStop = true;
            this.rbProgressBar.Text = "Progress Bar";
            this.rbProgressBar.UseVisualStyleBackColor = true;
            // 
            // rbTrackBar
            // 
            this.rbTrackBar.AutoSize = true;
            this.rbTrackBar.Location = new System.Drawing.Point(7, 67);
            this.rbTrackBar.Name = "rbTrackBar";
            this.rbTrackBar.Size = new System.Drawing.Size(72, 17);
            this.rbTrackBar.TabIndex = 2;
            this.rbTrackBar.TabStop = true;
            this.rbTrackBar.Text = "Track Bar";
            this.rbTrackBar.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 151);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(557, 48);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(7, 20);
            this.numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(440, 20);
            this.numericUpDown.TabIndex = 0;
            // 
            // probOutput
            // 
            this.probOutput.Location = new System.Drawing.Point(7, 47);
            this.probOutput.Maximum = 10;
            this.probOutput.Name = "probOutput";
            this.probOutput.Size = new System.Drawing.Size(440, 23);
            this.probOutput.Step = 1;
            this.probOutput.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(7, 77);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(440, 45);
            this.trackBar1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 214);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ProgressIndicator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTrackBar;
        private System.Windows.Forms.RadioButton rbProgressBar;
        private System.Windows.Forms.RadioButton rbSpinBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ProgressBar probOutput;
        private System.Windows.Forms.NumericUpDown numericUpDown;
    }
}

