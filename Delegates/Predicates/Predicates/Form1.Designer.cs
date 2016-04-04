namespace Predicates
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnEven = new System.Windows.Forms.Button();
            this.btnLessThanTen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listboxOutput = new System.Windows.Forms.ListBox();
            this.listboxInput = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(6, 19);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(146, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate Randoms";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // btnEven
            // 
            this.btnEven.Location = new System.Drawing.Point(5, 19);
            this.btnEven.Name = "btnEven";
            this.btnEven.Size = new System.Drawing.Size(146, 23);
            this.btnEven.TabIndex = 1;
            this.btnEven.Text = "Select Even Numbers";
            this.btnEven.UseVisualStyleBackColor = true;
            // 
            // btnLessThanTen
            // 
            this.btnLessThanTen.Location = new System.Drawing.Point(5, 48);
            this.btnLessThanTen.Name = "btnLessThanTen";
            this.btnLessThanTen.Size = new System.Drawing.Size(146, 23);
            this.btnLessThanTen.TabIndex = 2;
            this.btnLessThanTen.Text = "Select Numbers < 10";
            this.btnLessThanTen.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listboxInput);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 479);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listboxOutput);
            this.groupBox2.Controls.Add(this.btnEven);
            this.groupBox2.Controls.Add(this.btnLessThanTen);
            this.groupBox2.Location = new System.Drawing.Point(175, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 479);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // listboxOutput
            // 
            this.listboxOutput.FormattingEnabled = true;
            this.listboxOutput.Location = new System.Drawing.Point(6, 77);
            this.listboxOutput.Name = "listboxOutput";
            this.listboxOutput.Size = new System.Drawing.Size(145, 394);
            this.listboxOutput.TabIndex = 5;
            // 
            // listboxInput
            // 
            this.listboxInput.FormattingEnabled = true;
            this.listboxInput.Location = new System.Drawing.Point(6, 77);
            this.listboxInput.Name = "listboxInput";
            this.listboxInput.Size = new System.Drawing.Size(145, 394);
            this.listboxInput.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 497);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Predicates Demo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnEven;
        private System.Windows.Forms.Button btnLessThanTen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listboxInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listboxOutput;
    }
}

