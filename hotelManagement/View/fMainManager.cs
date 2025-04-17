using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelManagement.View
{
    public partial class fMainManager : Form
    {
        public fMainManager()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Mở form ở chế độ phóng to
            this.WindowState = FormWindowState.Maximized;
        }

        private void ClickToLogin(object sender, EventArgs e)
        {
            fLogin loginForm = new fLogin(this);
            loginForm.ShowDialog();  // Hiển thị form đăng nhập
        }

        private void ClickToCustomer(object sender, EventArgs e)
        {
            fCustomerManagement fCustomer = new fCustomerManagement();
            fCustomer.ShowDialog();
            this.Show();
        }

        private void ClickToPageEmployee(object sender, EventArgs e)
        {
            fEmployeeManegement fEmployee = new fEmployeeManegement();
            fEmployee.ShowDialog();
            this.Show();
        }

        private void ClickToPageRoom(object sender, EventArgs e)
        {
            Room room = new Room();
            room.ShowDialog();
            this.Show();
        }

        private void ClickToPageService(object sender, EventArgs e)
        {
            Serviceb serviceb = new Serviceb();
            serviceb.ShowDialog();
            this.Show();
        }

        private void ClickToPageReservation(object sender, EventArgs e)
        {
            Reservations reservation = new Reservations();
            reservation.ShowDialog();
            this.Show();
        }

        private void ClickToPageReservation_Services(object sender, EventArgs e)
        {
            Reservation_Services Rservice = new Reservation_Services();
            Rservice.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_BottomToolStripPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
