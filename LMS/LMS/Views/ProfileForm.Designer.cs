namespace LMS.Views
{
    partial class ProfileForm
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
            this.returnBtn = new System.Windows.Forms.Button();
            this.ProfileInfo = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.eMailLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.LoanListView = new System.Windows.Forms.ListView();
            this.CurrentLoansLbl = new System.Windows.Forms.Label();
            this.ReservationLV = new System.Windows.Forms.ListView();
            this.ReservationsLbl = new System.Windows.Forms.Label();
            this.InsertNameLbl = new System.Windows.Forms.Label();
            this.InsertSurnameLbl = new System.Windows.Forms.Label();
            this.InsertEmailLbl = new System.Windows.Forms.Label();
            this.InsertPhoneLbl = new System.Windows.Forms.Label();
            this.InsertUsernameLbl = new System.Windows.Forms.Label();
            this.returnListBtn = new System.Windows.Forms.Button();
            this.LoanIDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loanDateheader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReturndateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reservsationIdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.addNameLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameAddLbl = new System.Windows.Forms.Label();
            this.addSurnameLbl = new System.Windows.Forms.Label();
            this.addUsernameLbl = new System.Windows.Forms.Label();
            this.addMailLbl = new System.Windows.Forms.Label();
            this.addPhoneLbl = new System.Windows.Forms.Label();
            this.CancelReservationBtn = new System.Windows.Forms.Button();
            this.renewLoanBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(61, 385);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(114, 35);
            this.returnBtn.TabIndex = 0;
            this.returnBtn.Text = "&Return book";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // ProfileInfo
            // 
            this.ProfileInfo.AutoSize = true;
            this.ProfileInfo.Location = new System.Drawing.Point(334, 34);
            this.ProfileInfo.Name = "ProfileInfo";
            this.ProfileInfo.Size = new System.Drawing.Size(25, 13);
            this.ProfileInfo.TabIndex = 1;
            this.ProfileInfo.Text = "Info";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(89, 77);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(35, 13);
            this.NameLbl.TabIndex = 2;
            this.NameLbl.Text = "Name";
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.Location = new System.Drawing.Point(86, 103);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(49, 13);
            this.SurnameLbl.TabIndex = 3;
            this.SurnameLbl.Text = "Surname";
            // 
            // eMailLbl
            // 
            this.eMailLbl.AutoSize = true;
            this.eMailLbl.Location = new System.Drawing.Point(325, 71);
            this.eMailLbl.Name = "eMailLbl";
            this.eMailLbl.Size = new System.Drawing.Size(35, 13);
            this.eMailLbl.TabIndex = 4;
            this.eMailLbl.Text = "E-mail";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Location = new System.Drawing.Point(324, 95);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(38, 13);
            this.phoneLbl.TabIndex = 5;
            this.phoneLbl.Text = "Phone";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(127, 139);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(55, 13);
            this.usernameLbl.TabIndex = 6;
            this.usernameLbl.Text = "Username";
            // 
            // LoanListView
            // 
            this.LoanListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LoanIDHeader,
            this.BookHeader,
            this.loanDateheader,
            this.ReturndateHeader});
            this.LoanListView.HideSelection = false;
            this.LoanListView.Location = new System.Drawing.Point(30, 201);
            this.LoanListView.Name = "LoanListView";
            this.LoanListView.Size = new System.Drawing.Size(347, 161);
            this.LoanListView.TabIndex = 7;
            this.LoanListView.UseCompatibleStateImageBehavior = false;
            this.LoanListView.View = System.Windows.Forms.View.Details;
            // 
            // CurrentLoansLbl
            // 
            this.CurrentLoansLbl.AutoSize = true;
            this.CurrentLoansLbl.Location = new System.Drawing.Point(139, 183);
            this.CurrentLoansLbl.Name = "CurrentLoansLbl";
            this.CurrentLoansLbl.Size = new System.Drawing.Size(73, 13);
            this.CurrentLoansLbl.TabIndex = 8;
            this.CurrentLoansLbl.Text = "Current Loans";
            // 
            // ReservationLV
            // 
            this.ReservationLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.reservsationIdHeader,
            this.columnHeader1,
            this.columnHeader2});
            this.ReservationLV.HideSelection = false;
            this.ReservationLV.Location = new System.Drawing.Point(405, 201);
            this.ReservationLV.Name = "ReservationLV";
            this.ReservationLV.ShowGroups = false;
            this.ReservationLV.Size = new System.Drawing.Size(374, 158);
            this.ReservationLV.TabIndex = 9;
            this.ReservationLV.UseCompatibleStateImageBehavior = false;
            this.ReservationLV.View = System.Windows.Forms.View.Details;
            // 
            // ReservationsLbl
            // 
            this.ReservationsLbl.AutoSize = true;
            this.ReservationsLbl.Location = new System.Drawing.Point(546, 183);
            this.ReservationsLbl.Name = "ReservationsLbl";
            this.ReservationsLbl.Size = new System.Drawing.Size(106, 13);
            this.ReservationsLbl.TabIndex = 10;
            this.ReservationsLbl.Text = "Current Reservations";
            // 
            // InsertNameLbl
            // 
            this.InsertNameLbl.AutoSize = true;
            this.InsertNameLbl.Location = new System.Drawing.Point(140, 77);
            this.InsertNameLbl.Name = "InsertNameLbl";
            this.InsertNameLbl.Size = new System.Drawing.Size(0, 13);
            this.InsertNameLbl.TabIndex = 11;
            // 
            // InsertSurnameLbl
            // 
            this.InsertSurnameLbl.AutoSize = true;
            this.InsertSurnameLbl.Location = new System.Drawing.Point(147, 103);
            this.InsertSurnameLbl.Name = "InsertSurnameLbl";
            this.InsertSurnameLbl.Size = new System.Drawing.Size(0, 13);
            this.InsertSurnameLbl.TabIndex = 12;
            // 
            // InsertEmailLbl
            // 
            this.InsertEmailLbl.AutoSize = true;
            this.InsertEmailLbl.Location = new System.Drawing.Point(377, 72);
            this.InsertEmailLbl.Name = "InsertEmailLbl";
            this.InsertEmailLbl.Size = new System.Drawing.Size(0, 13);
            this.InsertEmailLbl.TabIndex = 13;
            // 
            // InsertPhoneLbl
            // 
            this.InsertPhoneLbl.AutoSize = true;
            this.InsertPhoneLbl.Location = new System.Drawing.Point(366, 99);
            this.InsertPhoneLbl.Name = "InsertPhoneLbl";
            this.InsertPhoneLbl.Size = new System.Drawing.Size(0, 13);
            this.InsertPhoneLbl.TabIndex = 14;
            // 
            // InsertUsernameLbl
            // 
            this.InsertUsernameLbl.AutoSize = true;
            this.InsertUsernameLbl.Location = new System.Drawing.Point(201, 139);
            this.InsertUsernameLbl.Name = "InsertUsernameLbl";
            this.InsertUsernameLbl.Size = new System.Drawing.Size(0, 13);
            this.InsertUsernameLbl.TabIndex = 15;
            // 
            // returnListBtn
            // 
            this.returnListBtn.Location = new System.Drawing.Point(614, 127);
            this.returnListBtn.Name = "returnListBtn";
            this.returnListBtn.Size = new System.Drawing.Size(174, 36);
            this.returnListBtn.TabIndex = 16;
            this.returnListBtn.Text = "&Return to list";
            this.returnListBtn.UseVisualStyleBackColor = true;
            this.returnListBtn.Click += new System.EventHandler(this.returnListBtn_Click);
            // 
            // LoanIDHeader
            // 
            this.LoanIDHeader.Text = "Loan ID";
            // 
            // BookHeader
            // 
            this.BookHeader.Text = "Book";
            this.BookHeader.Width = 143;
            // 
            // loanDateheader
            // 
            this.loanDateheader.Text = "Loan Date";
            this.loanDateheader.Width = 69;
            // 
            // ReturndateHeader
            // 
            this.ReturndateHeader.Text = "Return date";
            this.ReturndateHeader.Width = 129;
            // 
            // reservsationIdHeader
            // 
            this.reservsationIdHeader.Text = "Reservation ID";
            this.reservsationIdHeader.Width = 87;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Book";
            this.columnHeader1.Width = 184;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Reservation Date";
            this.columnHeader2.Width = 163;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 17;
            // 
            // addNameLbl
            // 
            this.addNameLbl.AutoSize = true;
            this.addNameLbl.Location = new System.Drawing.Point(130, 77);
            this.addNameLbl.Name = "addNameLbl";
            this.addNameLbl.Size = new System.Drawing.Size(0, 13);
            this.addNameLbl.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 19;
            // 
            // NameAddLbl
            // 
            this.NameAddLbl.AutoSize = true;
            this.NameAddLbl.Location = new System.Drawing.Point(129, 79);
            this.NameAddLbl.Name = "NameAddLbl";
            this.NameAddLbl.Size = new System.Drawing.Size(10, 13);
            this.NameAddLbl.TabIndex = 20;
            this.NameAddLbl.Text = ".";
            // 
            // addSurnameLbl
            // 
            this.addSurnameLbl.AutoSize = true;
            this.addSurnameLbl.Location = new System.Drawing.Point(141, 103);
            this.addSurnameLbl.Name = "addSurnameLbl";
            this.addSurnameLbl.Size = new System.Drawing.Size(10, 13);
            this.addSurnameLbl.TabIndex = 21;
            this.addSurnameLbl.Text = ".";
            // 
            // addUsernameLbl
            // 
            this.addUsernameLbl.AutoSize = true;
            this.addUsernameLbl.Location = new System.Drawing.Point(191, 139);
            this.addUsernameLbl.Name = "addUsernameLbl";
            this.addUsernameLbl.Size = new System.Drawing.Size(10, 13);
            this.addUsernameLbl.TabIndex = 22;
            this.addUsernameLbl.Text = ".";
            // 
            // addMailLbl
            // 
            this.addMailLbl.AutoSize = true;
            this.addMailLbl.Location = new System.Drawing.Point(367, 72);
            this.addMailLbl.Name = "addMailLbl";
            this.addMailLbl.Size = new System.Drawing.Size(10, 13);
            this.addMailLbl.TabIndex = 23;
            this.addMailLbl.Text = ".";
            // 
            // addPhoneLbl
            // 
            this.addPhoneLbl.AutoSize = true;
            this.addPhoneLbl.Location = new System.Drawing.Point(372, 99);
            this.addPhoneLbl.Name = "addPhoneLbl";
            this.addPhoneLbl.Size = new System.Drawing.Size(10, 13);
            this.addPhoneLbl.TabIndex = 24;
            this.addPhoneLbl.Text = ".";
            // 
            // CancelReservationBtn
            // 
            this.CancelReservationBtn.Location = new System.Drawing.Point(422, 383);
            this.CancelReservationBtn.Name = "CancelReservationBtn";
            this.CancelReservationBtn.Size = new System.Drawing.Size(190, 39);
            this.CancelReservationBtn.TabIndex = 25;
            this.CancelReservationBtn.Text = "&Cancel Reservation";
            this.CancelReservationBtn.UseVisualStyleBackColor = true;
            this.CancelReservationBtn.Click += new System.EventHandler(this.CancelReservationBtn_Click);
            // 
            // renewLoanBtn
            // 
            this.renewLoanBtn.Location = new System.Drawing.Point(194, 385);
            this.renewLoanBtn.Name = "renewLoanBtn";
            this.renewLoanBtn.Size = new System.Drawing.Size(131, 35);
            this.renewLoanBtn.TabIndex = 26;
            this.renewLoanBtn.Text = "&RenewLoan";
            this.renewLoanBtn.UseVisualStyleBackColor = true;
            this.renewLoanBtn.Click += new System.EventHandler(this.renewLoanBtn_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.renewLoanBtn);
            this.Controls.Add(this.CancelReservationBtn);
            this.Controls.Add(this.addPhoneLbl);
            this.Controls.Add(this.addMailLbl);
            this.Controls.Add(this.addUsernameLbl);
            this.Controls.Add(this.addSurnameLbl);
            this.Controls.Add(this.NameAddLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addNameLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnListBtn);
            this.Controls.Add(this.InsertUsernameLbl);
            this.Controls.Add(this.InsertPhoneLbl);
            this.Controls.Add(this.InsertEmailLbl);
            this.Controls.Add(this.InsertSurnameLbl);
            this.Controls.Add(this.InsertNameLbl);
            this.Controls.Add(this.ReservationsLbl);
            this.Controls.Add(this.ReservationLV);
            this.Controls.Add(this.CurrentLoansLbl);
            this.Controls.Add(this.LoanListView);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.eMailLbl);
            this.Controls.Add(this.SurnameLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.ProfileInfo);
            this.Controls.Add(this.returnBtn);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Label ProfileInfo;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label SurnameLbl;
        private System.Windows.Forms.Label eMailLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.ListView LoanListView;
        private System.Windows.Forms.Label CurrentLoansLbl;
        private System.Windows.Forms.ListView ReservationLV;
        private System.Windows.Forms.Label ReservationsLbl;
        private System.Windows.Forms.Label InsertNameLbl;
        private System.Windows.Forms.Label InsertSurnameLbl;
        private System.Windows.Forms.Label InsertEmailLbl;
        private System.Windows.Forms.Label InsertPhoneLbl;
        private System.Windows.Forms.Label InsertUsernameLbl;
        private System.Windows.Forms.Button returnListBtn;
        private System.Windows.Forms.ColumnHeader LoanIDHeader;
        private System.Windows.Forms.ColumnHeader BookHeader;
        private System.Windows.Forms.ColumnHeader loanDateheader;
        private System.Windows.Forms.ColumnHeader ReturndateHeader;
        private System.Windows.Forms.ColumnHeader reservsationIdHeader;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label addNameLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NameAddLbl;
        private System.Windows.Forms.Label addSurnameLbl;
        private System.Windows.Forms.Label addUsernameLbl;
        private System.Windows.Forms.Label addMailLbl;
        private System.Windows.Forms.Label addPhoneLbl;
        private System.Windows.Forms.Button CancelReservationBtn;
        private System.Windows.Forms.Button renewLoanBtn;
    }
}