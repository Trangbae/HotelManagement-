using hotelManagement.Controller;
using hotelManagement.Model;
using hotelManagement.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace hotelManagement.View
{
    public partial class fEmployeeManegement : Form, IView
    {
        employeeController employeeCtrl;
        employeeModel employeeM;
        public fEmployeeManegement()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            employeeCtrl = new employeeController();
            employeeM = new employeeModel();
            LoadDataToGridView();
        }
        public void SetDataToText()
        {
            tID.Text = employeeM.id;
            tTennhanvien.Text = employeeM.name;
            tTentaikhoan.Text = employeeM.userName;
            tMatkhau.Text = employeeM.password;
            comboBoxChucvu.Text = employeeM.role;
        }

        public void GetDataFromText()
        {
            string id = this.tID.Text;
            string name = this.tTennhanvien.Text;
            string userName = this.tTentaikhoan.Text;
            string password = this.tMatkhau.Text;
            string role = this.comboBoxChucvu.Text;
            employeeM.id = id;
            employeeM.name = name;
            employeeM.userName = userName;
            employeeM.password = password;
            employeeM.role = role;
        }

        public void LoadDataToGridView()
        {
            // Gọi hàm GetDataFromText để lấy dữ liệu từ các control
            GetDataFromText();

            // Sau khi đã có dữ liệu từ GetDataFromText, tiếp tục load dữ liệu
            employeeCtrl.Load();
            dataGridViewEmployee.DataSource = employeeCtrl.Items.OfType < employeeModel>().ToList();
        }

        private void CellClickTo_dataGridViewEmployee(object sender, DataGridViewCellEventArgs e)
        {
            //Kiểm tra xem dòng được chọn có hợp lệ không
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ dòng được chọn trong DataGridView
                DataGridViewRow row = dataGridViewEmployee.Rows[e.RowIndex];

                // Gán dữ liệu từ DataGridView vào biến toàn cục
                employeeM = new employeeModel
                (
                    row.Cells["id"].Value.ToString(),
                    row.Cells["name"].Value.ToString(),
                    row.Cells["userName"].Value.ToString(),
                    row.Cells["password"].Value.ToString(),
                    row.Cells["role"].Value.ToString()
                );

                // Hiển thị dữ liệu lên các ô nhập liệu (TextBox, ComboBox)
                SetDataToText();
            }
        }

        private void ClickToSave(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các trường nhập liệu
            GetDataFromText();

            // Kiểm tra đối tượng  đã tồn tại trong cơ sở dữ liệu hay chưa
            if (employeeCtrl.IsExist(employeeM))
            {
                // Nếu tồn tại, thì gọi hàm Update
                bool updated = employeeCtrl.Update(employeeM);
                if (updated)
                {
                    MessageBox.Show("Cập nhật nhân viên thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật nhân viên thất bại!");
                }
            }
            else
            {
                // Nếu không tồn tại, thì gọi hàm Create
                bool created = employeeCtrl.Create(employeeM);
                if (created)
                {
                    MessageBox.Show("Thêm nhân viên mới thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên mới thất bại!");
                }
            }
            LoadDataToGridView();

        }

        private void ClickToDelete(object sender, EventArgs e)
        {
            // Kiểm tra xem ô ID có dữ liệu không
            if (!string.IsNullOrEmpty(tID.Text))
            {
                // Tạo đối tượng với ID lấy từ TextBox
                employeeModel employeeM = new employeeModel
                {
                    id = tID.Text
                };

                // Gọi phương thức Delete để xóa bản ghi trong cơ sở dữ liệu
                bool isDeleted = employeeCtrl.Delete(employeeM);

                // Kiểm tra kết quả và thông báo cho người dùng
                if (isDeleted)
                {
                    MessageBox.Show("Đã xóa nhân viên thành công!");
                    // Cập nhật lại DataGridView (nạp lại dữ liệu)
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!");
            }
            LoadDataToGridView();

        }
    }
}
