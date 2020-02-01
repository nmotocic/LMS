namespace LMS.Views
{
    partial class ReservationForm
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
            this.reservationLbl = new System.Windows.Forms.Label();
            this.ReservationLV = new System.Windows.Forms.ListView();
            this.idHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emailHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReservationDateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reservationLbl
            // 
            this.reservationLbl.AutoSize = true;
            this.reservationLbl.Location = new System.Drawing.Point(350, 29);
            this.reservationLbl.Name = "reservationLbl";
            this.reservationLbl.Size = new System.Drawing.Size(69, 13);
            this.reservationLbl.TabIndex = 0;
            this.reservationLbl.Text = "Reservations";
            this.reservationLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ReservationLV
            // 
            this.ReservationLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idHeader,
            this.BookHeader,
            this.UserHeader,
            this.emailHeader,
            this.ReservationDateHeader});
            this.ReservationLV.HideSelection = false;
            this.ReservationLV.Location = new System.Drawing.Point(60, 54);
            this.ReservationLV.Name = "ReservationLV";
            this.ReservationLV.Size = new System.Drawing.Size(689, 310);
            this.ReservationLV.TabIndex = 1;
            this.ReservationLV.UseCompatibleStateImageBehavior = false;
            this.ReservationLV.View = System.Windows.Forms.View.Details;
            // 
            // idHeader
            // 
            this.idHeader.Text = "ID";
            // 
            // BookHeader
            // 
            this.BookHeader.Text = "Book";
            this.BookHeader.Width = 222;
            // 
            // UserHeader
            // 
            this.UserHeader.Text = "Username";
            this.UserHeader.Width = 116;
            // 
            // emailHeader
            // 
            this.emailHeader.Text = "E-mail";
            this.emailHeader.Width = 121;
            // 
            // ReservationDateHeader
            // 
            this.ReservationDateHeader.Text = "Reservation Date";
            this.ReservationDateHeader.Width = 113;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(124, 391);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(203, 38);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel Reservation";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(528, 393);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(229, 35);
            this.ReturnBtn.TabIndex = 3;
            this.ReturnBtn.Text = "Return to List";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ReservationLV);
            this.Controls.Add(this.reservationLbl);
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reservationLbl;
        private System.Windows.Forms.ListView ReservationLV;
        private System.Windows.Forms.ColumnHeader idHeader;
        private System.Windows.Forms.ColumnHeader BookHeader;
        private System.Windows.Forms.ColumnHeader UserHeader;
        private System.Windows.Forms.ColumnHeader emailHeader;
        private System.Windows.Forms.ColumnHeader ReservationDateHeader;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button ReturnBtn;
    }
}