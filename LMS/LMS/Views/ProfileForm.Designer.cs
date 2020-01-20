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
            this.SuspendLayout();
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(61, 385);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(114, 35);
            this.returnBtn.TabIndex = 0;
            this.returnBtn.Text = "&Return";
            this.returnBtn.UseVisualStyleBackColor = true;
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
            this.LoanListView.HideSelection = false;
            this.LoanListView.Location = new System.Drawing.Point(61, 199);
            this.LoanListView.Name = "LoanListView";
            this.LoanListView.Size = new System.Drawing.Size(256, 161);
            this.LoanListView.TabIndex = 7;
            this.LoanListView.UseCompatibleStateImageBehavior = false;
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
            this.ReservationLV.HideSelection = false;
            this.ReservationLV.Location = new System.Drawing.Point(414, 201);
            this.ReservationLV.Name = "ReservationLV";
            this.ReservationLV.ShowGroups = false;
            this.ReservationLV.Size = new System.Drawing.Size(279, 158);
            this.ReservationLV.TabIndex = 9;
            this.ReservationLV.UseCompatibleStateImageBehavior = false;
            // 
            // ReservationsLbl
            // 
            this.ReservationsLbl.AutoSize = true;
            this.ReservationsLbl.Location = new System.Drawing.Point(483, 182);
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
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}