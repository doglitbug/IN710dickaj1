namespace MixAndMatch
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
            this.gbParts = new System.Windows.Forms.GroupBox();
            this.gbPreview = new System.Windows.Forms.GroupBox();
            this.cbHead = new System.Windows.Forms.ComboBox();
            this.cbBody = new System.Windows.Forms.ComboBox();
            this.cbLegs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pbHead = new System.Windows.Forms.PictureBox();
            this.pbBody = new System.Windows.Forms.PictureBox();
            this.pbLegs = new System.Windows.Forms.PictureBox();
            this.gbParts.SuspendLayout();
            this.gbPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLegs)).BeginInit();
            this.SuspendLayout();
            // 
            // gbParts
            // 
            this.gbParts.Controls.Add(this.btnCreate);
            this.gbParts.Controls.Add(this.label3);
            this.gbParts.Controls.Add(this.label2);
            this.gbParts.Controls.Add(this.label1);
            this.gbParts.Controls.Add(this.cbLegs);
            this.gbParts.Controls.Add(this.cbBody);
            this.gbParts.Controls.Add(this.cbHead);
            this.gbParts.Location = new System.Drawing.Point(12, 12);
            this.gbParts.Name = "gbParts";
            this.gbParts.Size = new System.Drawing.Size(192, 134);
            this.gbParts.TabIndex = 0;
            this.gbParts.TabStop = false;
            this.gbParts.Text = "Select parts";
            // 
            // gbPreview
            // 
            this.gbPreview.Controls.Add(this.pbLegs);
            this.gbPreview.Controls.Add(this.pbBody);
            this.gbPreview.Controls.Add(this.pbHead);
            this.gbPreview.Location = new System.Drawing.Point(210, 12);
            this.gbPreview.Name = "gbPreview";
            this.gbPreview.Size = new System.Drawing.Size(200, 413);
            this.gbPreview.TabIndex = 1;
            this.gbPreview.TabStop = false;
            this.gbPreview.Text = "Preview";
            // 
            // cbHead
            // 
            this.cbHead.FormattingEnabled = true;
            this.cbHead.Location = new System.Drawing.Point(48, 19);
            this.cbHead.Name = "cbHead";
            this.cbHead.Size = new System.Drawing.Size(133, 21);
            this.cbHead.TabIndex = 0;
            // 
            // cbBody
            // 
            this.cbBody.FormattingEnabled = true;
            this.cbBody.Location = new System.Drawing.Point(48, 47);
            this.cbBody.Name = "cbBody";
            this.cbBody.Size = new System.Drawing.Size(133, 21);
            this.cbBody.TabIndex = 1;
            // 
            // cbLegs
            // 
            this.cbLegs.FormattingEnabled = true;
            this.cbLegs.Location = new System.Drawing.Point(48, 75);
            this.cbLegs.Name = "cbLegs";
            this.cbLegs.Size = new System.Drawing.Size(133, 21);
            this.cbLegs.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Head:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Body:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Legs:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(6, 102);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(175, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create monster";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // pbHead
            // 
            this.pbHead.Location = new System.Drawing.Point(6, 19);
            this.pbHead.Name = "pbHead";
            this.pbHead.Size = new System.Drawing.Size(184, 124);
            this.pbHead.TabIndex = 0;
            this.pbHead.TabStop = false;
            // 
            // pbBody
            // 
            this.pbBody.Location = new System.Drawing.Point(6, 149);
            this.pbBody.Name = "pbBody";
            this.pbBody.Size = new System.Drawing.Size(184, 124);
            this.pbBody.TabIndex = 1;
            this.pbBody.TabStop = false;
            // 
            // pbLegs
            // 
            this.pbLegs.Location = new System.Drawing.Point(6, 279);
            this.pbLegs.Name = "pbLegs";
            this.pbLegs.Size = new System.Drawing.Size(184, 124);
            this.pbLegs.TabIndex = 2;
            this.pbLegs.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 435);
            this.Controls.Add(this.gbPreview);
            this.Controls.Add(this.gbParts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbParts.ResumeLayout(false);
            this.gbParts.PerformLayout();
            this.gbPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLegs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbParts;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLegs;
        private System.Windows.Forms.ComboBox cbBody;
        private System.Windows.Forms.ComboBox cbHead;
        private System.Windows.Forms.GroupBox gbPreview;
        private System.Windows.Forms.PictureBox pbLegs;
        private System.Windows.Forms.PictureBox pbBody;
        private System.Windows.Forms.PictureBox pbHead;

    }
}

