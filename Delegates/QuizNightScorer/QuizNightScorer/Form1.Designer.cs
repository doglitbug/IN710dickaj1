namespace QuizNightScorer
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
            this.rbAdult = new System.Windows.Forms.RadioButton();
            this.rbChild = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCorrect = new System.Windows.Forms.TextBox();
            this.tbIncorrect = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnComputeScore = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbChild);
            this.groupBox1.Controls.Add(this.rbAdult);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Team Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbIncorrect);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbCorrect);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(146, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 68);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Answers";
            // 
            // rbAdult
            // 
            this.rbAdult.AutoSize = true;
            this.rbAdult.Checked = true;
            this.rbAdult.Location = new System.Drawing.Point(7, 20);
            this.rbAdult.Name = "rbAdult";
            this.rbAdult.Size = new System.Drawing.Size(49, 17);
            this.rbAdult.TabIndex = 0;
            this.rbAdult.TabStop = true;
            this.rbAdult.Text = "Adult";
            this.rbAdult.UseVisualStyleBackColor = true;
            // 
            // rbChild
            // 
            this.rbChild.AutoSize = true;
            this.rbChild.Location = new System.Drawing.Point(7, 44);
            this.rbChild.Name = "rbChild";
            this.rbChild.Size = new System.Drawing.Size(48, 17);
            this.rbChild.TabIndex = 1;
            this.rbChild.Text = "Child";
            this.rbChild.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correct Answers:";
            // 
            // tbCorrect
            // 
            this.tbCorrect.Location = new System.Drawing.Point(113, 9);
            this.tbCorrect.Name = "tbCorrect";
            this.tbCorrect.Size = new System.Drawing.Size(58, 20);
            this.tbCorrect.TabIndex = 2;
            this.tbCorrect.Text = "0";
            // 
            // tbIncorrect
            // 
            this.tbIncorrect.Location = new System.Drawing.Point(113, 35);
            this.tbIncorrect.Name = "tbIncorrect";
            this.tbIncorrect.Size = new System.Drawing.Size(58, 20);
            this.tbIncorrect.TabIndex = 4;
            this.tbIncorrect.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Incorrect Answers:";
            // 
            // btnComputeScore
            // 
            this.btnComputeScore.Location = new System.Drawing.Point(12, 86);
            this.btnComputeScore.Name = "btnComputeScore";
            this.btnComputeScore.Size = new System.Drawing.Size(128, 23);
            this.btnComputeScore.TabIndex = 2;
            this.btnComputeScore.Text = "Compute Score";
            this.btnComputeScore.UseVisualStyleBackColor = true;
            this.btnComputeScore.Click += new System.EventHandler(this.btnComputeScore_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(256, 91);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(13, 13);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 122);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnComputeScore);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Quiz Night Scorer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbChild;
        private System.Windows.Forms.RadioButton rbAdult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbIncorrect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCorrect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComputeScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblScore;
    }
}

