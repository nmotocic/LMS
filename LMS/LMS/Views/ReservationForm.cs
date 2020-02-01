using LMS.Domain.ViewModels;
using LMS.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Views
{
    public partial class ReservationForm : Form
    {
        private AdminPresenter _adminPresenter = new AdminPresenter();

        public ReservationForm()
        {
            InitializeComponent();
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            var reservationList = _adminPresenter.ShowReservations();
            foreach (ReservationViewModel reservation in reservationList.Reservations)
            {
                ListViewItem item = new ListViewItem();
                item.Text = reservation.Reservation_ID.ToString();
                item.SubItems.Add(reservation.Book.Title);
                item.SubItems.Add(reservation.User.Username);
                item.SubItems.Add(reservation.User.Email);
                item.SubItems.Add(reservation.ReservationDate.ToString());
                
                ReservationLV.Items.Add(item);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            int reservationID = 0;
            var selectedItem = ReservationLV.SelectedItems;
            if (selectedItem.Count == 1)
            {
                reservationID = Convert.ToInt32(selectedItem[0].SubItems[0].Text);
            }
            _adminPresenter.CancelReservation(reservationID);
            this.Refresh();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminForm().Show();
        }
    }
}
