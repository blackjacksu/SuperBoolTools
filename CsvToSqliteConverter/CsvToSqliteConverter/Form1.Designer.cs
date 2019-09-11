namespace CsvToSqliteConverter
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
            this.Write = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BrowseYourCsv = new System.Windows.Forms.Button();
            this.CsvFileNameLabel = new System.Windows.Forms.Label();
            this.DbFileNameLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BrowsYourDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Write
            // 
            this.Write.Location = new System.Drawing.Point(374, 152);
            this.Write.Name = "Write";
            this.Write.Size = new System.Drawing.Size(83, 47);
            this.Write.TabIndex = 0;
            this.Write.Text = "Convert";
            this.Write.UseVisualStyleBackColor = true;
            this.Write.Click += new System.EventHandler(this.Write_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(692, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(598, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 29);
            this.textBox1.TabIndex = 3;
            // 
            // BrowseYourCsv
            // 
            this.BrowseYourCsv.Location = new System.Drawing.Point(216, 58);
            this.BrowseYourCsv.Name = "BrowseYourCsv";
            this.BrowseYourCsv.Size = new System.Drawing.Size(119, 42);
            this.BrowseYourCsv.TabIndex = 4;
            this.BrowseYourCsv.Text = "Browse";
            this.BrowseYourCsv.UseVisualStyleBackColor = true;
            this.BrowseYourCsv.Click += new System.EventHandler(this.BrowseYourFile_Click);
            // 
            // CsvFileNameLabel
            // 
            this.CsvFileNameLabel.AutoSize = true;
            this.CsvFileNameLabel.Location = new System.Drawing.Point(59, 41);
            this.CsvFileNameLabel.Name = "CsvFileNameLabel";
            this.CsvFileNameLabel.Size = new System.Drawing.Size(90, 18);
            this.CsvFileNameLabel.TabIndex = 5;
            this.CsvFileNameLabel.Text = "Target CSV";
            // 
            // DbFileNameLabel
            // 
            this.DbFileNameLabel.AutoSize = true;
            this.DbFileNameLabel.Location = new System.Drawing.Point(59, 181);
            this.DbFileNameLabel.Name = "DbFileNameLabel";
            this.DbFileNameLabel.Size = new System.Drawing.Size(105, 18);
            this.DbFileNameLabel.TabIndex = 6;
            this.DbFileNameLabel.Text = "Target Sql Db";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(51, 219);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 29);
            this.textBox2.TabIndex = 7;
            // 
            // BrowsYourDB
            // 
            this.BrowsYourDB.Location = new System.Drawing.Point(224, 206);
            this.BrowsYourDB.Name = "BrowsYourDB";
            this.BrowsYourDB.Size = new System.Drawing.Size(111, 42);
            this.BrowsYourDB.TabIndex = 8;
            this.BrowsYourDB.Text = "Browse";
            this.BrowsYourDB.UseVisualStyleBackColor = true;
            this.BrowsYourDB.Click += new System.EventHandler(this.BrowsYourDB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BrowsYourDB);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.DbFileNameLabel);
            this.Controls.Add(this.CsvFileNameLabel);
            this.Controls.Add(this.BrowseYourCsv);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Write);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Write;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BrowseYourCsv;
        private System.Windows.Forms.Label CsvFileNameLabel;
        private System.Windows.Forms.Label DbFileNameLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BrowsYourDB;
    }
}

