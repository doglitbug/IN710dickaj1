namespace Encryption
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
            this.rbROT13 = new System.Windows.Forms.RadioButton();
            this.rbStringReverse = new System.Windows.Forms.RadioButton();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDecrypt);
            this.groupBox1.Controls.Add(this.btnEncrypt);
            this.groupBox1.Controls.Add(this.rbStringReverse);
            this.groupBox1.Controls.Add(this.rbROT13);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encryption";
            // 
            // rbROT13
            // 
            this.rbROT13.AutoSize = true;
            this.rbROT13.Checked = true;
            this.rbROT13.Location = new System.Drawing.Point(6, 19);
            this.rbROT13.Name = "rbROT13";
            this.rbROT13.Size = new System.Drawing.Size(60, 17);
            this.rbROT13.TabIndex = 0;
            this.rbROT13.TabStop = true;
            this.rbROT13.Text = "ROT13";
            this.rbROT13.UseVisualStyleBackColor = true;
            // 
            // rbStringReverse
            // 
            this.rbStringReverse.AutoSize = true;
            this.rbStringReverse.Location = new System.Drawing.Point(6, 42);
            this.rbStringReverse.Name = "rbStringReverse";
            this.rbStringReverse.Size = new System.Drawing.Size(90, 17);
            this.rbStringReverse.TabIndex = 1;
            this.rbStringReverse.Text = "String reverse";
            this.rbStringReverse.UseVisualStyleBackColor = true;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(425, 13);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(425, 42);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "button2";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 502);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Encryption Algorithms";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbStringReverse;
        private System.Windows.Forms.RadioButton rbROT13;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
    }
}

