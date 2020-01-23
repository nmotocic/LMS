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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
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
            this.AddBookBtn.Location = new System.Drawing.Point(31, 450);
            this.AddBookBtn.Name = "AddBookBtn";
            this.AddBookBtn.Size = new System.Drawing.Size(158, 34);
            this.AddBookBtn.TabIndex = 2;
            this.AddBookBtn.Text = "&Add new book";
            this.AddBookBtn.UseVisualStyleBackColor = true;
            this.AddBookBtn.Click += new System.EventHandler(this.AddBookBtn_Click);
            // 
            // LoansBtn
            // 
            this.LoansBtn.Location = new System.Drawing.Point(223, 502);
            this.LoansBtn.Name = "LoansBtn";
            this.LoansBtn.Size = new System.Drawing.Size(167, 36);
            this.LoansBtn.TabIndex = 3;
            this.LoansBtn.Text = "See &loans";
            this.LoansBtn.UseVisualStyleBackColor = true;
            this.LoansBtn.Click += new System.EventHandler(this.LoansBtn_Click);
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
            this.BookCatalogLV.HideSelection = false;
            this.BookCatalogLV.Location = new System.Drawing.Point(154, 82);
            this.BookCatalogLV.Name = "BookCatalogLV";
            this.BookCatalogLV.Size = new System.Drawing.Size(730, 328);
            this.BookCatalogLV.TabIndex = 5;
            this.BookCatalogLV.UseCompatibleStateImageBehavior = false;
            this.BookCatalogLV.View = System.Windows.Forms.View.Details;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.RemoveBtn);
            this.MainPanel.Controls.Add(this.EditBtn);
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
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(31, 554);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(157, 41);
            this.RemoveBtn.TabIndex = 7;
            this.RemoveBtn.Text = "&Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(30, 499);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(158, 38);
            this.EditBtn.TabIndex = 6;
            this.EditBtn.Text = "&Edit book";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 640);
            this.Controls.Add(this.MainPanel);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label BookCatalogLbl;
        private System.Windows.Forms.Button AddBookBtn;
        private System.Windows.Forms.Button LoansBtn;
        private System.Windows.Forms.Button ReservationsBtn;
        private System.Windows.Forms.ListView BookCatalogLV;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button RemoveBtn;
    }
}