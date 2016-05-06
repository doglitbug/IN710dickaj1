namespace UsingORM
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
            this.btnAveIntensity = new System.Windows.Forms.Button();
            this.btnThreeLargestFires = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAveIntensity
            // 
            this.btnAveIntensity.Location = new System.Drawing.Point(12, 12);
            this.btnAveIntensity.Name = "btnAveIntensity";
            this.btnAveIntensity.Size = new System.Drawing.Size(223, 23);
            this.btnAveIntensity.TabIndex = 0;
            this.btnAveIntensity.Text = "1. Average intensity of all strikes";
            this.btnAveIntensity.UseVisualStyleBackColor = true;
            this.btnAveIntensity.Click += new System.EventHandler(this.btnAveIntensity_Click);
            // 
            // btnThreeLargestFires
            // 
            this.btnThreeLargestFires.Location = new System.Drawing.Point(12, 41);
            this.btnThreeLargestFires.Name = "btnThreeLargestFires";
            this.btnThreeLargestFires.Size = new System.Drawing.Size(223, 23);
            this.btnThreeLargestFires.TabIndex = 1;
            this.btnThreeLargestFires.Text = "2. Complete records of 3 largest fires";
            this.btnThreeLargestFires.UseVisualStyleBackColor = true;
            this.btnThreeLargestFires.Click += new System.EventHandler(this.btnThreelargestFires_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(241, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "3.";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(241, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "4.";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(718, 342);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 422);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnThreeLargestFires);
            this.Controls.Add(this.btnAveIntensity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAveIntensity;
        private System.Windows.Forms.Button btnThreeLargestFires;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

