namespace LMS.Views
{
    partial class AdminForm
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
            this.BookCatalogLbl = new System.Windows.Forms.Label();
            this.AddBookBtn = new System.Windows.Forms.Button();
            this.LoansBtn = new System.Windows.Forms.Button();
            this.ReservationsBtn = new System.Windows.Forms.Button();
            this.BookCatalogLV = new System.Windows.Forms.ListView();
            this.BookIDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TitleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AuthoerHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PublisherHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YOPHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GenreHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LoanPanel = new System.Windows.Forms.Panel();
            this.ReturnBtn1 = new System.Windows.Forms.Button();
            this.LoanLV = new System.Windows.Forms.ListView();
            this.LoanIDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UsernameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EMailHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoanDateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReturnDateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoanLbl = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.LoanPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookCatalogLbl
            // 
            this.BookCatalogLbl.AutoSize = true;
            this.BookCatalogLbl.Location = new System.Drawing.Point(470, 66);
            this.BookCatalogLbl.Name = "BookCatalogLbl";
            this.BookCatalogLbl.Size = new System.Drawing.Size(71, 13);
            this.BookCatalogLbl.TabIndex = 1;
            this.BookCatalogLbl.Text = "Book Catalog";
            // 
            // AddBookBtn
            // 
            this.AddBookBtn.Location = new System.Drawing.Point(35, 506);
            this.AddBookBtn.Name = "AddBookBtn";
            this.AddBookBtn.Size = new System.Drawing.Size(158, 34);
            this.AddBookBtn.TabIndex = 2;
            this.AddBookBtn.Text = "&Add new book";
            this.AddBookBtn.UseVisualStyleBackColor = true;
            // 
            // LoansBtn
            // 
            this.LoansBtn.Location = new System.Drawing.Point(223, 502);
            this.LoansBtn.Name = "LoansBtn";
            this.LoansBtn.Size = new System.Drawing.Size(167, 36);
            this.LoansBtn.TabIndex = 3;
            this.LoansBtn.Text = "See &loans";
            this.LoansBtn.UseVisualStyleBackColor = true;
            // 
            // ReservationsBtn
            // 
            this.ReservationsBtn.Location = new System.Drawing.Point(416, 504);
            this.ReservationsBtn.Name = "ReservationsBtn";
            this.ReservationsBtn.Size = new System.Drawing.Size(151, 32);
            this.ReservationsBtn.TabIndex = 4;
            this.ReservationsBtn.Text = "See &reservations";
            this.ReservationsBtn.UseVisualStyleBackColor = true;
            // 
            // BookCatalogLV
            // 
            this.BookCatalogLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BookIDHeader,
            this.TitleHeader,
            this.AuthoerHeader,
            this.PublisherHeader,
            this.YOPHeader,
            this.GenreHeader,
            this.StatusHeader});
            this.BookCatalogLV.HideSelection = false;
            this.BookCatalogLV.Location = new System.Drawing.Point(154, 82);
            this.BookCatalogLV.Name = "BookCatalogLV";
            this.BookCatalogLV.Size = new System.Drawing.Size(730, 328);
            this.BookCatalogLV.TabIndex = 5;
            this.BookCatalogLV.UseCompatibleStateImageBehavior = false;
            this.BookCatalogLV.View = System.Windows.Forms.View.Details;
            // 
            // BookIDHeader
            // 
            this.BookIDHeader.Text = "BookID";
            this.BookIDHeader.Width = 49;
            // 
            // TitleHeader
            // 
            this.TitleHeader.Text = "Title";
            this.TitleHeader.Width = 136;
            // 
            // AuthoerHeader
            // 
            this.AuthoerHeader.Text = "Author";
            this.AuthoerHeader.Width = 136;
            // 
            // PublisherHeader
            // 
            this.PublisherHeader.Text = "Publisher";
            // 
            // YOPHeader
            // 
            this.YOPHeader.Text = "Year of Publishing";
            this.YOPHeader.Width = 97;
            // 
            // GenreHeader
            // 
            this.GenreHeader.Text = "Genre";
            this.GenreHeader.Width = 105;
            // 
            // StatusHeader
            // 
            this.StatusHeader.Text = "Status";
            this.StatusHeader.Width = 131;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.LoanPanel);
            this.MainPanel.Controls.Add(this.BookCatalogLV);
            this.MainPanel.Controls.Add(this.ReservationsBtn);
            this.MainPanel.Controls.Add(this.LoansBtn);
            this.MainPanel.Controls.Add(this.AddBookBtn);
            this.MainPanel.Controls.Add(this.BookCatalogLbl);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1109, 640);
            this.MainPanel.TabIndex = 6;
            // 
            // LoanPanel
            // 
            this.LoanPanel.Controls.Add(this.LoanLbl);
            this.LoanPanel.Controls.Add(this.LoanLV);
            this.LoanPanel.Controls.Add(this.ReturnBtn1);
            this.LoanPanel.Location = new System.Drawing.Point(6, 6);
            this.LoanPanel.Name = "LoanPanel";
            this.LoanPanel.Size = new System.Drawing.Size(1103, 634);
            this.LoanPanel.TabIndex = 6;
            this.LoanPanel.Visible = false;
            // 
            // ReturnBtn1
            // 
            this.ReturnBtn1.Location = new System.Drawing.Point(908, 576);
            this.ReturnBtn1.Name = "ReturnBtn1";
            this.ReturnBtn1.Size = new System.Drawing.Size(168, 41);
            this.ReturnBtn1.TabIndex = 0;
            this.ReturnBtn1.Text = "&Return";
            this.ReturnBtn1.UseVisualStyleBackColor = true;
            // 
            // LoanLV
            // 
            this.LoanLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LoanIDHeader,
            this.BookHeader,
            this.UsernameHeader,
            this.EMailHeader,
            this.LoanDateHeader,
            this.ReturnDateHeader});
            this.LoanLV.HideSelection = false;
            this.LoanLV.Location = new System.Drawing.Point(86, 91);
            this.LoanLV.Name = "LoanLV";
            this.LoanLV.Size = new System.Drawing.Size(977, 441);
            this.LoanLV.TabIndex = 1;
            this.LoanLV.UseCompatibleStateImageBehavior = false;
            this.LoanLV.View = System.Windows.Forms.View.Details;
            // 
            // LoanIDHeader
            // 
            this.LoanIDHeader.Text = "Loan ID";
            // 
            // BookHeader
            // 
            this.BookHeader.Text = "Book";
            this.BookHeader.Width = 226;
            // 
            // UsernameHeader
            // 
            this.UsernameHeader.Text = "Username";
            this.UsernameHeader.Width = 105;
            // 
            // EMailHeader
            // 
            this.EMailHeader.Text = "Email";
            this.EMailHeader.Width = 133;
            // 
            // LoanDateHeader
            // 
            this.LoanDateHeader.Text = "Loan Date";
            this.LoanDateHeader.Width = 94;
            // 
            // ReturnDateHeader
            // 
            this.ReturnDateHeader.Text = "Return Date";
            this.ReturnDateHeader.Width = 94;
            // 
            // LoanLbl
            // 
            this.LoanLbl.AutoSize = true;
            this.LoanLbl.Location = new System.Drawing.Point(484, 50);
            this.LoanLbl.Name = "LoanLbl";
            this.LoanLbl.Size = new System.Drawing.Size(36, 13);
            this.LoanLbl.TabIndex = 2;
            this.LoanLbl.Text = "Loans";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 640);
            this.Controls.Add(this.MainPanel);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.LoanPanel.ResumeLayout(false);
            this.LoanPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label BookCatalogLbl;
        private System.Windows.Forms.Button AddBookBtn;
        private System.Windows.Forms.Button LoansBtn;
        private System.Windows.Forms.Button ReservationsBtn;
        private System.Windows.Forms.ListView BookCatalogLV;
        private System.Windows.Forms.ColumnHeader BookIDHeader;
        private System.Windows.Forms.ColumnHeader TitleHeader;
        private System.Windows.Forms.ColumnHeader AuthoerHeader;
        private System.Windows.Forms.ColumnHeader PublisherHeader;
        private System.Windows.Forms.ColumnHeader YOPHeader;
        private System.Windows.Forms.ColumnHeader GenreHeader;
        private System.Windows.Forms.ColumnHeader StatusHeader;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel LoanPanel;
        private System.Windows.Forms.Label LoanLbl;
        private System.Windows.Forms.ListView LoanLV;
        private System.Windows.Forms.ColumnHeader LoanIDHeader;
        private System.Windows.Forms.ColumnHeader BookHeader;
        private System.Windows.Forms.ColumnHeader UsernameHeader;
        private System.Windows.Forms.ColumnHeader EMailHeader;
        private System.Windows.Forms.ColumnHeader LoanDateHeader;
        private System.Windows.Forms.ColumnHeader ReturnDateHeader;
        private System.Windows.Forms.Button ReturnBtn1;
    }
}