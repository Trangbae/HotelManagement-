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
    public partial class Room : Form, IView
    {
        roomController roomCtrl;
        roomModel roomM;
        public Room()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            roomCtrl = new roomController();
            roomM = new roomModel();
            LoadDataToGridView();
        }
        public void SetDataToText()
        {
            tID.Text = roomM.id;
           comboBoxLoaiPhong.Text = roomM.room_type;
            tGiaThue.Text = roomM.price_per_night;
            tSucChuaPhong.Text = roomM.capacity;
            comboBoxTrangThai.Text = roomM.status;
        }

        public void GetDataFromText()
        {
            string id = this.tID.Text;
            string room_type = this.comboBoxLoaiPhong.Text;
            string price_per_night = this.tGiaThue.Text;
            string capacity = this.tSucChuaPhong.Text;
            string status = this.comboBoxTrangThai.Text;
            roomM.id = id;
            roomM.room_type = room_type;
            roomM.price_per_night = price_per_night;
            roomM.capacity = capacity;
            roomM.status = status;
        }

        public void LoadDataToGridView()
        {
            // Gọi hàm GetDataFromText để lấy dữ liệu từ các control
            GetDataFromText();

            // Sau khi đã có dữ liệu từ GetDataFromText, tiếp tục load dữ liệu
            roomCtrl.Load();
            dataGridViewRoom.DataSource = roomCtrl.Items.OfType<roomModel>().ToList();
        }
        private void CellClickRoom(object sender, DataGridViewCellEventArgs e)
        {
            //Kiểm tra xem dòng được chọn có hợp lệ không
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ dòng được chọn trong DataGridView
                DataGridViewRow row = dataGridViewRoom.Rows[e.RowIndex];

                // Gán dữ liệu từ DataGridView vào biến toàn cục branchM
                roomM = new roomModel
                (
                    row.Cells["id"].Value.ToString(),
                    row.Cells["room_type"].Value.ToString(),
                    row.Cells["price_per_night"].Value.ToString(),
                    row.Cells["capacity"].Value.ToString(),
                    row.Cells["status"].Value.ToString()
                );

                // Hiển thị dữ liệu lên các ô nhập liệu (TextBox, ComboBox)
                SetDataToText();
            }
        }

        private void ToClickSave(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các trường nhập liệu
            GetDataFromText();

            // Kiểm tra đối tượng  đã tồn tại trong cơ sở dữ liệu hay chưa
            if (roomCtrl.IsExist(roomM))
            {
                // Nếu tồn tại, thì gọi hàm Update
                bool updated = roomCtrl.Update(roomM);
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
                bool created = roomCtrl.Create(roomM);
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

        private void ToClickDelete(object sender, EventArgs e)
        {
            // Kiểm tra xem ô ID có dữ liệu không
            if (!string.IsNullOrEmpty(tID.Text))
            {
                // Tạo đối tượng với ID lấy từ TextBox
                roomModel roomM = new roomModel
                {
                    id = tID.Text
                };

                // Gọi phương thức Delete để xóa bản ghi trong cơ sở dữ liệu
                bool isDeleted = roomCtrl.Delete(roomM);

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

        private void Room_Load(object sender, EventArgs e)
        {

        }
    }
}
