namespace LMS.Views
{
    partial class AddBookForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.AuthorLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.authorTB = new System.Windows.Forms.TextBox();
            this.publisherTB = new System.Windows.Forms.TextBox();
            this.yopTB = new System.Windows.Forms.TextBox();
            this.genreTB = new System.Windows.Forms.TextBox();
            this.statusTB = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.serialNumTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add new book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // titleTB
            // 
            this.titleTB.Location = new System.Drawing.Point(158, 84);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(208, 20);
            this.titleTB.TabIndex = 2;
            // 
            // AuthorLbl
            // 
            this.AuthorLbl.AutoSize = true;
            this.AuthorLbl.Location = new System.Drawing.Point(60, 134);
            this.AuthorLbl.Name = "AuthorLbl";
            this.AuthorLbl.Size = new System.Drawing.Size(38, 13);
            this.AuthorLbl.TabIndex = 3;
            this.AuthorLbl.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Publisher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Year of Publishing";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Status";
            // 
            // authorTB
            // 
            this.authorTB.Location = new System.Drawing.Point(158, 134);
            this.authorTB.Name = "authorTB";
            this.authorTB.Size = new System.Drawing.Size(208, 20);
            this.authorTB.TabIndex = 8;
            // 
            // publisherTB
            // 
            this.publisherTB.Location = new System.Drawing.Point(158, 173);
            this.publisherTB.Name = "publisherTB";
            this.publisherTB.Size = new System.Drawing.Size(208, 20);
            this.publisherTB.TabIndex = 9;
            // 
            // yopTB
            // 
            this.yopTB.Location = new System.Drawing.Point(158, 210);
            this.yopTB.Name = "yopTB";
            this.yopTB.Size = new System.Drawing.Size(208, 20);
            this.yopTB.TabIndex = 10;
            // 
            // genreTB
            // 
            this.genreTB.Location = new System.Drawing.Point(158, 244);
            this.genreTB.Name = "genreTB";
            this.genreTB.Size = new System.Drawing.Size(208, 20);
            this.genreTB.TabIndex = 11;
            // 
            // statusTB
            // 
            this.statusTB.Location = new System.Drawing.Point(158, 275);
            this.statusTB.Name = "statusTB";
            this.statusTB.Size = new System.Drawing.Size(208, 20);
            this.statusTB.TabIndex = 12;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(86, 344);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(148, 42);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "&Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(279, 346);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(155, 39);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.Text = "&Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Serial Number";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // serialNumTB
            // 
            this.serialNumTB.Location = new System.Drawing.Point(158, 58);
            this.serialNumTB.Name = "serialNumTB";
            this.serialNumTB.Size = new System.Drawing.Size(208, 20);
            this.serialNumTB.TabIndex = 16;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.serialNumTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.statusTB);
            this.Controls.Add(this.genreTB);
            this.Controls.Add(this.yopTB);
            this.Controls.Add(this.publisherTB);
            this.Controls.Add(this.authorTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AuthorLbl);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddBookForm";
            this.Text = "AddBookForm";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.Label AuthorLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox authorTB;
        private System.Windows.Forms.TextBox publisherTB;
        private System.Windows.Forms.TextBox yopTB;
        private System.Windows.Forms.TextBox genreTB;
        private System.Windows.Forms.TextBox statusTB;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox serialNumTB;
    }
}