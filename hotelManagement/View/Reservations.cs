using hotelManagement.Controller;
using hotelManagement.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace hotelManagement.View
{
    public partial class Reservations : Form, IView
    {
        private reservationsController reservationsCtrl;
        private reservationsModel reservationsM;
        private customerModel customerM;
        private roomModel roomM;
        private employeeModel employeeM;

        public Reservations()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            reservationsCtrl = new reservationsController();
            reservationsM = new reservationsModel();
            customerM = new customerModel();
            roomM = new roomModel();
            employeeM = new employeeModel();

            LoadDataToGridView();
        }

        public void SetDataToText()
        {
            tID.Text = reservationsM.id;
            tCustomerID.Text = reservationsM.customer_id?.id;
            tRoomID.Text = reservationsM.room_id?.id;
            dateTimeCheckIn.Value = reservationsM.check_in_date;
            dateTimeCheckOut.Value = reservationsM.check_out_date;
            tTongChiPhi.Text = reservationsM.total_amount.ToString();
            tEmployeeID.Text = reservationsM.employee_id?.id;
        }

        public void GetDataFromText()
        {
            // Retrieve data from the form
            reservationsM.id = tID.Text;
            reservationsM.check_in_date = dateTimeCheckIn.Value;
            reservationsM.check_out_date = dateTimeCheckOut.Value;

            // Parse total amount safely
            reservationsM.total_amount = float.TryParse(tTongChiPhi.Text, out var total) ? total.ToString() : "0";

            // Initialize customer, room, and employee models if necessary
            if (customerM == null) customerM = new customerModel();
            if (roomM == null) roomM = new roomModel();
            if (employeeM == null) employeeM = new employeeModel();

            customerM.id = tCustomerID.Text;
            roomM.id = tRoomID.Text;
            employeeM.id = tEmployeeID.Text;

            reservationsM.customer_id = customerM;
            reservationsM.room_id = roomM;
            reservationsM.employee_id = employeeM;
        }

        public void LoadDataToGridView()
        {
            if (reservationsCtrl.Load())
            {
                var reservations = reservationsCtrl.Items.OfType<reservationsModel>().Select(r => new
                {
                    r.id,
                    CustomerID = r.customer_id?.id,
                    RoomID = r.room_id?.id,
                    r.check_in_date,
                    r.check_out_date,
                    r.total_amount,
                    EmployeeID = r.employee_id?.id
                }).ToList();

                dataGridViewCustomer.DataSource = reservations;
            }
            else
            {
                MessageBox.Show("Failed to load data!");
            }
        }

        private void ClickToSave(object sender, EventArgs e)
        {
            GetDataFromText();

            if (reservationsCtrl.IsExist(reservationsM))
            {
                if (reservationsCtrl.Update(reservationsM))
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            else
            {
                if (reservationsCtrl.Create(reservationsM))
                {
                    MessageBox.Show("Thêm mới thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm mới thất bại!");
                }
            }
            LoadDataToGridView();
        }

        private void ClickToDelete(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tID.Text))
            {
                MessageBox.Show("Vui lòng chọn bản ghi để xóa!");
                return;
            }

            var reservationToDelete = new reservationsModel { id = tID.Text };

            if (reservationsCtrl.Delete(reservationToDelete))
            {
                MessageBox.Show("Đã xóa thành công!");
                LoadDataToGridView();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void CellClickPageData(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is selected
            {
                var selectedRow = dataGridViewCustomer.Rows[e.RowIndex];

                // Initialize related models if needed
                reservationsM = new reservationsModel
                {
                    id = selectedRow.Cells["id"].Value.ToString(),
                    check_in_date = Convert.ToDateTime(selectedRow.Cells["check_in_date"].Value),
                    check_out_date = Convert.ToDateTime(selectedRow.Cells["check_out_date"].Value),
                    total_amount = selectedRow.Cells["total_amount"].Value.ToString(),
                    customer_id = new customerModel
                    {
                        id = selectedRow.Cells["CustomerID"].Value.ToString()
                    },
                    room_id = new roomModel
                    {
                        id = selectedRow.Cells["RoomID"].Value.ToString()
                    },
                    employee_id = new employeeModel
                    {
                        id = selectedRow.Cells["EmployeeID"].Value.ToString()
                    }
                };

                // Update input fields
                SetDataToText();
            }
        }
    }
}
