using hotelManagement.Controller;
using hotelManagement.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace hotelManagement.View
{
    public partial class Reservation_Services : Form, IView
    {
        private reservationServicesController reservationsServicesCtrl;
        private reservationsServiceModel reservationsServicesM;
        private reservationsModel reservationM;
        private serviceModel serviceM;

        public Reservation_Services()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            reservationsServicesCtrl = new reservationServicesController();
            reservationsServicesM = new reservationsServiceModel();
            reservationM = new reservationsModel();
            serviceM = new serviceModel();

            LoadDataToGridView();
        }

        public void SetDataToText()
        {
            tRID.Text = reservationsServicesM.reservationsID;
            tSID.Text = reservationsServicesM.serviceID;
            tSoLuongDichVu.Text = reservationsServicesM.quantity.ToString();
        }

        public void GetDataFromText()
        {
            // Parse quantity safely
            reservationsServicesM.quantity = int.TryParse(tSoLuongDichVu.Text, out var quantity) ? quantity.ToString() : "0";

            // Initialize reservation and service models if necessary
            if (reservationM == null) reservationM = new reservationsModel { id = tRID.Text };
            if (serviceM == null) serviceM = new serviceModel { id = tSID.Text };

            reservationsServicesM.reservation_id = reservationM;
            reservationsServicesM.service_id = serviceM;
        }

        public void LoadDataToGridView()
        {
            if (reservationsServicesCtrl.Load())
            {
                var reservationsServices = reservationsServicesCtrl.Items
                    .OfType<reservationsServiceModel>()
                    .Select(r => new
                    {

                        ReservationID = r.reservation_id?.id,
                        ServiceID = r.service_id?.id,
                        Quantity = r.quantity
                    }).ToList();

                dataGridView.DataSource = reservationsServices;
            }
            else
            {
                MessageBox.Show("Failed to load data!");
            }
        }

        private void ToPageSave(object sender, EventArgs e)
        {
            GetDataFromText();

            if (reservationsServicesCtrl.IsExist(reservationsServicesM))
            {
                if (reservationsServicesCtrl.Update(reservationsServicesM))
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
                if (reservationsServicesCtrl.Create(reservationsServicesM))

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

        private void ToPageDelete(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tRID.Text))
            {
                MessageBox.Show("Vui lòng chọn bản ghi để xóa!");
                return;
            }

            var reservationToDelete = new reservationsModel { id = tRID.Text };

            if (reservationsServicesCtrl.Delete(reservationToDelete))
            {
                MessageBox.Show("Đã xóa thành công!");
                LoadDataToGridView();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
            LoadDataToGridView();

        }

        private void ToData(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridView.Rows[e.RowIndex];
                reservationsServicesM = new reservationsServiceModel
                {



                    quantity = selectedRow.Cells["quantity"].Value.ToString(),

                    reservation_id = new reservationsModel
                    {
                        id = selectedRow.Cells["reservation_id"].Value.ToString()
                    },
                    service_id = new serviceModel
                    {
                        id = selectedRow.Cells["service_id"].Value.ToString()
                    }
                };
                // Update input fields
                SetDataToText();
            }
        }
    }
        }
    

