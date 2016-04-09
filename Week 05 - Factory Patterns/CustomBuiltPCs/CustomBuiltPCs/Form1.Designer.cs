namespace CustomBuiltPCs
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
            this.btnPrintSpec = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMultimedia = new System.Windows.Forms.RadioButton();
            this.rbBusiness = new System.Windows.Forms.RadioButton();
            this.rbGame = new System.Windows.Forms.RadioButton();
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.rbBudget = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrintSpec
            // 
            this.btnPrintSpec.Location = new System.Drawing.Point(12, 12);
            this.btnPrintSpec.Name = "btnPrintSpec";
            this.btnPrintSpec.Size = new System.Drawing.Size(87, 23);
            this.btnPrintSpec.TabIndex = 0;
            this.btnPrintSpec.Text = "Print Spec";
            this.btnPrintSpec.UseVisualStyleBackColor = true;
            this.btnPrintSpec.Click += new System.EventHandler(this.btnPrintSpec_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbBudget);
            this.groupBox1.Controls.Add(this.rbMultimedia);
            this.groupBox1.Controls.Add(this.rbBusiness);
            this.groupBox1.Controls.Add(this.rbGame);
            this.groupBox1.Location = new System.Drawing.Point(13, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 130);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Machine type";
            // 
            // rbMultimedia
            // 
            this.rbMultimedia.AutoSize = true;
            this.rbMultimedia.Location = new System.Drawing.Point(7, 68);
            this.rbMultimedia.Name = "rbMultimedia";
            this.rbMultimedia.Size = new System.Drawing.Size(75, 17);
            this.rbMultimedia.TabIndex = 2;
            this.rbMultimedia.TabStop = true;
            this.rbMultimedia.Text = "Multimedia";
            this.rbMultimedia.UseVisualStyleBackColor = true;
            // 
            // rbBusiness
            // 
            this.rbBusiness.AutoSize = true;
            this.rbBusiness.Location = new System.Drawing.Point(7, 44);
            this.rbBusiness.Name = "rbBusiness";
            this.rbBusiness.Size = new System.Drawing.Size(67, 17);
            this.rbBusiness.TabIndex = 1;
            this.rbBusiness.TabStop = true;
            this.rbBusiness.Text = "Business";
            this.rbBusiness.UseVisualStyleBackColor = true;
            // 
            // rbGame
            // 
            this.rbGame.AutoSize = true;
            this.rbGame.Location = new System.Drawing.Point(7, 20);
            this.rbGame.Name = "rbGame";
            this.rbGame.Size = new System.Drawing.Size(53, 17);
            this.rbGame.TabIndex = 0;
            this.rbGame.TabStop = true;
            this.rbGame.Text = "Game";
            this.rbGame.UseVisualStyleBackColor = true;
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.Location = new System.Drawing.Point(105, 12);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(455, 160);
            this.listBoxDisplay.TabIndex = 2;
            // 
            // rbBudget
            // 
            this.rbBudget.AutoSize = true;
            this.rbBudget.Location = new System.Drawing.Point(7, 92);
            this.rbBudget.Name = "rbBudget";
            this.rbBudget.Size = new System.Drawing.Size(59, 17);
            this.rbBudget.TabIndex = 3;
            this.rbBudget.TabStop = true;
            this.rbBudget.Text = "Budget";
            this.rbBudget.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 187);
            this.Controls.Add(this.listBoxDisplay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrintSpec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrintSpec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMultimedia;
        private System.Windows.Forms.RadioButton rbBusiness;
        private System.Windows.Forms.RadioButton rbGame;
        private System.Windows.Forms.ListBox listBoxDisplay;
        private System.Windows.Forms.RadioButton rbBudget;
    }
}

