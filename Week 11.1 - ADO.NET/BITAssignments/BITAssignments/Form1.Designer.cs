namespace BITAssignments
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnListAllPapers = new System.Windows.Forms.Button();
            this.btnListAssignmentsDue = new System.Windows.Forms.Button();
            this.btnAverageMarksSoFar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 12);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(246, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create new database";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnListAllPapers
            // 
            this.btnListAllPapers.Location = new System.Drawing.Point(12, 41);
            this.btnListAllPapers.Name = "btnListAllPapers";
            this.btnListAllPapers.Size = new System.Drawing.Size(246, 23);
            this.btnListAllPapers.TabIndex = 1;
            this.btnListAllPapers.Text = "1. List all papers";
            this.btnListAllPapers.UseVisualStyleBackColor = true;
            this.btnListAllPapers.Click += new System.EventHandler(this.btnListAllPapers_Click);
            // 
            // btnListAssignmentsDue
            // 
            this.btnListAssignmentsDue.Location = new System.Drawing.Point(12, 70);
            this.btnListAssignmentsDue.Name = "btnListAssignmentsDue";
            this.btnListAssignmentsDue.Size = new System.Drawing.Size(246, 23);
            this.btnListAssignmentsDue.TabIndex = 2;
            this.btnListAssignmentsDue.Text = "2. List all assignments due in 2 weeks";
            this.btnListAssignmentsDue.UseVisualStyleBackColor = true;
            this.btnListAssignmentsDue.Click += new System.EventHandler(this.btnListAssignmentsDue_Click);
            // 
            // btnAverageMarksSoFar
            // 
            this.btnAverageMarksSoFar.Location = new System.Drawing.Point(12, 99);
            this.btnAverageMarksSoFar.Name = "btnAverageMarksSoFar";
            this.btnAverageMarksSoFar.Size = new System.Drawing.Size(246, 23);
            this.btnAverageMarksSoFar.TabIndex = 3;
            this.btnAverageMarksSoFar.Text = "3. List average marks so far";
            this.btnAverageMarksSoFar.UseVisualStyleBackColor = true;
            this.btnAverageMarksSoFar.Click += new System.EventHandler(this.btnAverageMarksSoFar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 128);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(670, 381);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 526);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAverageMarksSoFar);
            this.Controls.Add(this.btnListAssignmentsDue);
            this.Controls.Add(this.btnListAllPapers);
            this.Controls.Add(this.btnCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnListAllPapers;
        private System.Windows.Forms.Button btnListAssignmentsDue;
        private System.Windows.Forms.Button btnAverageMarksSoFar;
        private System.Windows.Forms.ListBox listBox1;
    }
}

