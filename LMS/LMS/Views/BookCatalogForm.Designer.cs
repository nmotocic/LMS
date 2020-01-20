namespace LMS.Views
{
    partial class BookCatalogForm
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
            this.BookCatalogLV = new System.Windows.Forms.ListView();
            this.BookIDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TitleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AuthoerHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PublisherHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YOPHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GenreHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookCatalogLbl = new System.Windows.Forms.Label();
            this.ProfileBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.BookCatalogLV.Location = new System.Drawing.Point(32, 50);
            this.BookCatalogLV.Name = "BookCatalogLV";
            this.BookCatalogLV.Size = new System.Drawing.Size(730, 328);
            this.BookCatalogLV.TabIndex = 0;
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
            // BookCatalogLbl
            // 
            this.BookCatalogLbl.AutoSize = true;
            this.BookCatalogLbl.Location = new System.Drawing.Point(344, 34);
            this.BookCatalogLbl.Name = "BookCatalogLbl";
            this.BookCatalogLbl.Size = new System.Drawing.Size(71, 13);
            this.BookCatalogLbl.TabIndex = 1;
            this.BookCatalogLbl.Text = "Book Catalog";
            // 
            // ProfileBtn
            // 
            this.ProfileBtn.Location = new System.Drawing.Point(35, 403);
            this.ProfileBtn.Name = "ProfileBtn";
            this.ProfileBtn.Size = new System.Drawing.Size(167, 36);
            this.ProfileBtn.TabIndex = 2;
            this.ProfileBtn.Text = "&Profile";
            this.ProfileBtn.UseVisualStyleBackColor = true;
            // 
            // BookCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProfileBtn);
            this.Controls.Add(this.BookCatalogLV);
            this.Controls.Add(this.BookCatalogLbl);
            this.Name = "BookCatalogForm";
            this.Text = "BookCatalogForm";
            this.Load += new System.EventHandler(this.BookCatalogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView BookCatalogLV;
        private System.Windows.Forms.Label BookCatalogLbl;
        private System.Windows.Forms.ColumnHeader TitleHeader;
        private System.Windows.Forms.ColumnHeader AuthoerHeader;
        private System.Windows.Forms.ColumnHeader PublisherHeader;
        private System.Windows.Forms.ColumnHeader YOPHeader;
        private System.Windows.Forms.ColumnHeader GenreHeader;
        private System.Windows.Forms.ColumnHeader StatusHeader;
        private System.Windows.Forms.Button ProfileBtn;
        private System.Windows.Forms.ColumnHeader BookIDHeader;
    }
}