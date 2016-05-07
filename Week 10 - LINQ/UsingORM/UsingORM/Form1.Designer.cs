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
            this.btnLocationPicture = new System.Windows.Forms.Button();
            this.btnFireStrikes = new System.Windows.Forms.Button();
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
            // btnLocationPicture
            // 
            this.btnLocationPicture.Location = new System.Drawing.Point(241, 12);
            this.btnLocationPicture.Name = "btnLocationPicture";
            this.btnLocationPicture.Size = new System.Drawing.Size(223, 23);
            this.btnLocationPicture.TabIndex = 2;
            this.btnLocationPicture.Text = "3. Location and picture for each fire";
            this.btnLocationPicture.UseVisualStyleBackColor = true;
            this.btnLocationPicture.Click += new System.EventHandler(this.btnLocationPicture_Click);
            // 
            // btnFireStrikes
            // 
            this.btnFireStrikes.Location = new System.Drawing.Point(241, 41);
            this.btnFireStrikes.Name = "btnFireStrikes";
            this.btnFireStrikes.Size = new System.Drawing.Size(223, 23);
            this.btnFireStrikes.TabIndex = 3;
            this.btnFireStrikes.Text = "4. Fires caused by strikes";
            this.btnFireStrikes.UseVisualStyleBackColor = true;
            this.btnFireStrikes.Click += new System.EventHandler(this.btnFireStrikes_Click);
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
            this.Controls.Add(this.btnFireStrikes);
            this.Controls.Add(this.btnLocationPicture);
            this.Controls.Add(this.btnThreeLargestFires);
            this.Controls.Add(this.btnAveIntensity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAveIntensity;
        private System.Windows.Forms.Button btnThreeLargestFires;
        private System.Windows.Forms.Button btnLocationPicture;
        private System.Windows.Forms.Button btnFireStrikes;
        private System.Windows.Forms.ListBox listBox1;
    }
}

