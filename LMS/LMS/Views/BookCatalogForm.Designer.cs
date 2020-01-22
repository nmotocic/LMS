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
            this.BookCatalogLbl = new System.Windows.Forms.Label();
            this.ProfileBtn = new System.Windows.Forms.Button();
            this.BookCatalogLV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Publisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YOP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
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
            // BookCatalogLV
            // 
            this.BookCatalogLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.BookID,
            this.Title,
            this.Author,
            this.Publisher,
            this.YOP,
            this.Genre,
            this.Status});
            this.BookCatalogLV.HideSelection = false;
            this.BookCatalogLV.Location = new System.Drawing.Point(42, 52);
            this.BookCatalogLV.Name = "BookCatalogLV";
            this.BookCatalogLV.Size = new System.Drawing.Size(732, 329);
            this.BookCatalogLV.TabIndex = 3;
            this.BookCatalogLV.UseCompatibleStateImageBehavior = false;
            this.BookCatalogLV.View = System.Windows.Forms.View.Details;
            this.BookCatalogLV.SelectedIndexChanged += new System.EventHandler(this.BookCatalogLV_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "....";
            this.columnHeader1.Width = 10;
            // 
            // BookID
            // 
            this.BookID.Text = "BookID";
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 161;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.Width = 124;
            // 
            // Publisher
            // 
            this.Publisher.Text = "Publisher";
            // 
            // YOP
            // 
            this.YOP.Text = "Year OF Publishing";
            this.YOP.Width = 104;
            // 
            // Genre
            // 
            this.Genre.Text = "Genre";
            this.Genre.Width = 105;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 144;
            // 
            // BookCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BookCatalogLV);
            this.Controls.Add(this.ProfileBtn);
            this.Controls.Add(this.BookCatalogLbl);
            this.Name = "BookCatalogForm";
            this.Text = "BookCatalogForm";
            this.Load += new System.EventHandler(this.BookCatalogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label BookCatalogLbl;
        private System.Windows.Forms.Button ProfileBtn;
        private System.Windows.Forms.ListView BookCatalogLV;
        private System.Windows.Forms.ColumnHeader BookID;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Publisher;
        private System.Windows.Forms.ColumnHeader YOP;
        private System.Windows.Forms.ColumnHeader Genre;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}