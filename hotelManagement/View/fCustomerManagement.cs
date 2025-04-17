using hotelManagement.Controller;
using hotelManagement.Model;
using hotelManagement.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using Excel = Microsoft.Office.Interop.Excel;

namespace hotelManagement
{
    public partial class fCustomerManagement : Form, IView
    {

        customerController customerControll;
        customerModel customerModel;
        public fCustomerManagement()
            {
                InitializeComponent();
                this.MinimizeBox = false;
                this.MaximizeBox = false;
                this.FormBorderStyle = FormBorderStyle.FixedDialog;



            customerControll = new customerController();
            customerModel = new customerModel();
            LoadDataToGridView();
            }
            public void SetDataToText()
            {
                tID.Text = customerModel.id;
                tTenkhachhang.Text = customerModel.name;
                tSdt.Text = customerModel.phone;
                tEmail.Text = customerModel.email;
                tDiachi.Text = customerModel.address;
                comboBoxQuequan.Text = customerModel.city;
                tCMND.Text = customerModel.id_card;
            }

            public void GetDataFromText()
            {
                string id = this.tID.Text;
                string name = this.tTenkhachhang.Text;
                string phone = this.tSdt.Text;
                string email = this.tEmail.Text;
                string address = this.tDiachi.Text;
                string city = this.comboBoxQuequan.Text;
                string id_card  = this.tCMND.Text;
                customerModel.id = id;
                customerModel.name = name;
                customerModel.phone = phone;
                customerModel.email = email;
                customerModel.address = address;
                customerModel.city = city;
                customerModel.id_card = id_card;
            }
            public void LoadDataToGridView()
            {
                // Gọi hàm GetDataFromText để lấy dữ liệu từ các control
                GetDataFromText();

            // Sau khi đã có dữ liệu từ GetDataFromText, tiếp tục load dữ liệu
            customerControll.Load();
                dataGridViewCustomer.DataSource = customerControll.Items.OfType<customerModel>().ToList();
            }
            private void ClickToSave(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các trường nhập liệu
            GetDataFromText();

            // Kiểm tra đối tượng đã tồn tại trong cơ sở dữ liệu hay chưa
            if (customerControll.IsExist(customerModel))
            {
                // Nếu tồn tại, thì gọi hàm Update
                bool updated = customerControll.Update(customerModel);
                if (updated)
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
                // Nếu không tồn tại, thì gọi hàm Create
                bool created = customerControll.Create(customerModel);
                if (created)
                {
                    MessageBox.Show("Thêm khách hàng mới thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng mới thất bại!");
                }
            }
            LoadDataToGridView();
        }

        private void CellClickToPageCustomer(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem dòng được chọn có hợp lệ không
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ dòng được chọn trong DataGridView
                DataGridViewRow row = dataGridViewCustomer.Rows[e.RowIndex];

                // Gán dữ liệu từ DataGridView vào biến toàn cục branchM
                customerModel = new customerModel
                (
                    row.Cells["id"].Value.ToString(),
                    row.Cells["name"].Value.ToString(),
                    row.Cells["phone"].Value.ToString(),
                    row.Cells["email"].Value.ToString(),
                    row.Cells["address"].Value.ToString(),
                    row.Cells["city"].Value.ToString(),
                    row.Cells["id_card"].Value.ToString()
                );

                // Hiển thị dữ liệu lên các ô nhập liệu (TextBox, ComboBox)
                SetDataToText();
            }
        }

        private void ClickToPageDelete(object sender, EventArgs e)
        {
            // Kiểm tra xem ô ID có dữ liệu không
            if (!string.IsNullOrEmpty(tID.Text))
            {
                // Tạo đối tượng customerModel với ID lấy từ TextBox
                customerModel customerM = new customerModel
                {
                    id = tID.Text
                };

                // Gọi phương thức Delete để xóa bản ghi trong cơ sở dữ liệu
                bool isDeleted = customerControll.Delete(customerModel);

                // Kiểm tra kết quả và thông báo cho người dùng
                if (isDeleted)
                {
                    MessageBox.Show("Đã xóa khách hàng thành công!");
                    // Cập nhật lại DataGridView (nạp lại dữ liệu)
                }
                else
                {
                    MessageBox.Show("Xóa khách hàng thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!");
            }
            LoadDataToGridView();

        }
    }
    
}
