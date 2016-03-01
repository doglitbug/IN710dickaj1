namespace BestMovieDatabase
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAddYear = new System.Windows.Forms.TextBox();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.textBoxAddDirector = new System.Windows.Forms.TextBox();
            this.textBoxAddTitle = new System.Windows.Forms.TextBox();
            this.groupBoxDelete = new System.Windows.Forms.GroupBox();
            this.textBoxDeleteYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.textBoxSearchYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBoxPrintAll = new System.Windows.Forms.GroupBox();
            this.buttonPrintAll = new System.Windows.Forms.Button();
            this.richTextBoxPrintAll = new System.Windows.Forms.RichTextBox();
            this.groupBoxAdd.SuspendLayout();
            this.groupBoxDelete.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxPrintAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(6, 16);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(112, 71);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add Movie";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Director";
            // 
            // textBoxAddYear
            // 
            this.textBoxAddYear.Location = new System.Drawing.Point(206, 16);
            this.textBoxAddYear.Name = "textBoxAddYear";
            this.textBoxAddYear.Size = new System.Drawing.Size(356, 20);
            this.textBoxAddYear.TabIndex = 4;
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.textBoxAddDirector);
            this.groupBoxAdd.Controls.Add(this.textBoxAddTitle);
            this.groupBoxAdd.Controls.Add(this.buttonAdd);
            this.groupBoxAdd.Controls.Add(this.textBoxAddYear);
            this.groupBoxAdd.Controls.Add(this.label1);
            this.groupBoxAdd.Controls.Add(this.label3);
            this.groupBoxAdd.Controls.Add(this.label2);
            this.groupBoxAdd.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(568, 102);
            this.groupBoxAdd.TabIndex = 5;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Add Movie";
            // 
            // textBoxAddDirector
            // 
            this.textBoxAddDirector.Location = new System.Drawing.Point(205, 70);
            this.textBoxAddDirector.Name = "textBoxAddDirector";
            this.textBoxAddDirector.Size = new System.Drawing.Size(357, 20);
            this.textBoxAddDirector.TabIndex = 6;
            // 
            // textBoxAddTitle
            // 
            this.textBoxAddTitle.Location = new System.Drawing.Point(205, 43);
            this.textBoxAddTitle.Name = "textBoxAddTitle";
            this.textBoxAddTitle.Size = new System.Drawing.Size(357, 20);
            this.textBoxAddTitle.TabIndex = 5;
            // 
            // groupBoxDelete
            // 
            this.groupBoxDelete.Controls.Add(this.textBoxDeleteYear);
            this.groupBoxDelete.Controls.Add(this.label4);
            this.groupBoxDelete.Controls.Add(this.buttonDelete);
            this.groupBoxDelete.Location = new System.Drawing.Point(12, 120);
            this.groupBoxDelete.Name = "groupBoxDelete";
            this.groupBoxDelete.Size = new System.Drawing.Size(568, 54);
            this.groupBoxDelete.TabIndex = 6;
            this.groupBoxDelete.TabStop = false;
            this.groupBoxDelete.Text = "Delete Movie";
            // 
            // textBoxDeleteYear
            // 
            this.textBoxDeleteYear.Location = new System.Drawing.Point(206, 16);
            this.textBoxDeleteYear.Name = "textBoxDeleteYear";
            this.textBoxDeleteYear.Size = new System.Drawing.Size(356, 20);
            this.textBoxDeleteYear.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Year";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(6, 16);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(112, 31);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "Delete Movie";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.textBoxSearchYear);
            this.groupBoxSearch.Controls.Add(this.label5);
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(13, 181);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(567, 58);
            this.groupBoxSearch.TabIndex = 7;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search Movie";
            // 
            // textBoxSearchYear
            // 
            this.textBoxSearchYear.Location = new System.Drawing.Point(205, 16);
            this.textBoxSearchYear.Name = "textBoxSearchYear";
            this.textBoxSearchYear.Size = new System.Drawing.Size(356, 20);
            this.textBoxSearchYear.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Year";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(6, 19);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(112, 31);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search Movie";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // groupBoxPrintAll
            // 
            this.groupBoxPrintAll.Controls.Add(this.richTextBoxPrintAll);
            this.groupBoxPrintAll.Controls.Add(this.buttonPrintAll);
            this.groupBoxPrintAll.Location = new System.Drawing.Point(13, 245);
            this.groupBoxPrintAll.Name = "groupBoxPrintAll";
            this.groupBoxPrintAll.Size = new System.Drawing.Size(567, 263);
            this.groupBoxPrintAll.TabIndex = 3;
            this.groupBoxPrintAll.TabStop = false;
            this.groupBoxPrintAll.Text = "Print All";
            // 
            // buttonPrintAll
            // 
            this.buttonPrintAll.Location = new System.Drawing.Point(6, 19);
            this.buttonPrintAll.Name = "buttonPrintAll";
            this.buttonPrintAll.Size = new System.Drawing.Size(112, 31);
            this.buttonPrintAll.TabIndex = 4;
            this.buttonPrintAll.Text = "Print All";
            this.buttonPrintAll.UseVisualStyleBackColor = true;
            this.buttonPrintAll.Click += new System.EventHandler(this.buttonPrintAll_Click);
            // 
            // textBoxPrintAll
            // 
            this.richTextBoxPrintAll.Location = new System.Drawing.Point(138, 19);
            this.richTextBoxPrintAll.Name = "textBoxPrintAll";
            this.richTextBoxPrintAll.Size = new System.Drawing.Size(423, 238);
            this.richTextBoxPrintAll.TabIndex = 5;
            this.richTextBoxPrintAll.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 520);
            this.Controls.Add(this.groupBoxPrintAll);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxDelete);
            this.Controls.Add(this.groupBoxAdd);
            this.Name = "Form1";
            this.Text = "Movie Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.groupBoxDelete.ResumeLayout(false);
            this.groupBoxDelete.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBoxPrintAll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAddYear;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.TextBox textBoxAddDirector;
        private System.Windows.Forms.TextBox textBoxAddTitle;
        private System.Windows.Forms.GroupBox groupBoxDelete;
        private System.Windows.Forms.TextBox textBoxDeleteYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox textBoxSearchYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBoxPrintAll;
        private System.Windows.Forms.Button buttonPrintAll;
        private System.Windows.Forms.RichTextBox richTextBoxPrintAll;
    }
}

