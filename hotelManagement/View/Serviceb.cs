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
    public partial class Serviceb : Form, IView
    {
        serviceController serviceCtrl;
        serviceModel serviceM;
        public Serviceb()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            serviceCtrl = new serviceController();
            serviceM = new serviceModel();
            LoadDataToGridView();
        }
        public void SetDataToText()
        {
            tID.Text = serviceM.id;
            tTen.Text = serviceM.name;
            tGiaThue.Text = serviceM.description;
            tMoTa.Text = serviceM.price;
           
        }

        public void GetDataFromText()
        {
            string id = this.tID.Text;
            string name = this.tTen.Text;
            string description = this.tGiaThue.Text;
            string price = this.tMoTa.Text;
          
            serviceM.id = id;
            serviceM.name = name;
            serviceM.description = description;
         
            serviceM.price = price;
        }

        public void LoadDataToGridView()
        {
            // Gọi hàm GetDataFromText để lấy dữ liệu từ các control
            GetDataFromText();

            // Sau khi đã có dữ liệu từ GetDataFromText, tiếp tục load dữ liệu
            serviceCtrl.Load();
            dataGridViewService.DataSource = serviceCtrl.Items.OfType<serviceModel>().ToList();
        }

        private void ToPageClickDelete(object sender, EventArgs e)
        {
            // Kiểm tra xem ô ID có dữ liệu không
            if (!string.IsNullOrEmpty(tID.Text))
            {
                // Tạo đối tượng với ID lấy từ TextBox
                serviceModel serviceM = new serviceModel
                {
                    id = tID.Text
                };

                // Gọi phương thức Delete để xóa bản ghi trong cơ sở dữ liệu
                bool isDeleted = serviceCtrl.Delete(serviceM);

                // Kiểm tra kết quả và thông báo cho người dùng
                if (isDeleted)
                {
                    MessageBox.Show("Đã xóa thành công!");
                    // Cập nhật lại DataGridView (nạp lại dữ liệu)
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa!");
            }
            LoadDataToGridView();
        }

        private void ToPageClickSave(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các trường nhập liệu
            GetDataFromText();

            // Kiểm tra đối tượng  đã tồn tại trong cơ sở dữ liệu hay chưa
            if (serviceCtrl.IsExist(serviceM))
            {
                // Nếu tồn tại, thì gọi hàm Update
                bool updated = serviceCtrl.Update(serviceM);
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
                bool created = serviceCtrl.Create(serviceM);
                if (created)
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

        private void CellClickToDataService(object sender, DataGridViewCellEventArgs e)
        {
            //Kiểm tra xem dòng được chọn có hợp lệ không
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ dòng được chọn trong DataGridView
                DataGridViewRow row = dataGridViewService.Rows[e.RowIndex];

                // Gán dữ liệu từ DataGridView vào biến toàn cục branchM
                serviceM = new serviceModel
                (
                    row.Cells["id"].Value.ToString(),
                    row.Cells["name"].Value.ToString(),
                    row.Cells["description"].Value.ToString(),
                  
                    row.Cells["price"].Value.ToString()
                );

                // Hiển thị dữ liệu lên các ô nhập liệu (TextBox, ComboBox)
                SetDataToText();
            }
        }
    }
}
