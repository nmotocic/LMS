namespace LMS.Views
{
    partial class LoansForm
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
            this.LoanLV = new System.Windows.Forms.ListView();
            this.LoanIdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UsernameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emailHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoanDateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.returnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.renewBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoanLV
            // 
            this.LoanLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LoanIdHeader,
            this.BookHeader,
            this.UsernameHeader,
            this.emailHeader,
            this.LoanDateHeader,
            this.returnDate});
            this.LoanLV.HideSelection = false;
            this.LoanLV.Location = new System.Drawing.Point(65, 52);
            this.LoanLV.Name = "LoanLV";
            this.LoanLV.Size = new System.Drawing.Size(668, 303);
            this.LoanLV.TabIndex = 0;
            this.LoanLV.UseCompatibleStateImageBehavior = false;
            this.LoanLV.View = System.Windows.Forms.View.Details;
            // 
            // LoanIdHeader
            // 
            this.LoanIdHeader.Text = "LoanId";
            this.LoanIdHeader.Width = 52;
            // 
            // BookHeader
            // 
            this.BookHeader.Text = "Book";
            this.BookHeader.Width = 185;
            // 
            // UsernameHeader
            // 
            this.UsernameHeader.Text = "Username";
            this.UsernameHeader.Width = 98;
            // 
            // emailHeader
            // 
            this.emailHeader.Text = "E-mail";
            this.emailHeader.Width = 111;
            // 
            // LoanDateHeader
            // 
            this.LoanDateHeader.Text = "Loan Date";
            this.LoanDateHeader.Width = 84;
            // 
            // returnDate
            // 
            this.returnDate.Text = "Return Date";
            this.returnDate.Width = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loans";
            // 
            // renewBtn
            // 
            this.renewBtn.Location = new System.Drawing.Point(80, 382);
            this.renewBtn.Name = "renewBtn";
            this.renewBtn.Size = new System.Drawing.Size(182, 49);
            this.renewBtn.TabIndex = 2;
            this.renewBtn.Text = "&Renew Loan";
            this.renewBtn.UseVisualStyleBackColor = true;
            this.renewBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(532, 382);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(151, 52);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "&Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // LoansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.renewBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoanLV);
            this.Name = "LoansForm";
            this.Text = "LoansForm";
            this.Load += new System.EventHandler(this.LoansForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LoanLV;
        private System.Windows.Forms.ColumnHeader LoanIdHeader;
        private System.Windows.Forms.ColumnHeader BookHeader;
        private System.Windows.Forms.ColumnHeader UsernameHeader;
        private System.Windows.Forms.ColumnHeader emailHeader;
        private System.Windows.Forms.ColumnHeader LoanDateHeader;
        private System.Windows.Forms.ColumnHeader returnDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button renewBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}