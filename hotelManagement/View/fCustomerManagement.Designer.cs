using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using Font = System.Drawing.Font;
using Image = System.Drawing.Image;
using System.Xml.Linq;

namespace hotelManagement
{
    partial class fCustomerManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCustomerManagement));
            label1 = new Label();
            dataGridViewCustomer = new DataGridView();
            HinhQLKH = new PictureBox();
            tTenkhachhang = new TextBox();
            tDiachi = new TextBox();
            labelEmail = new Label();
            labelDiachi = new Label();
            labelTenkhachhang = new Label();
            buttonDelete = new Button();
            tEmail = new TextBox();
            tSdt = new TextBox();
            labelSodienthoai = new Label();
            labelMaxacnhan = new Label();
            tCMND = new TextBox();
            labelNgaysinh = new Label();
            tID = new TextBox();
            labelID = new Label();
            buttonSave = new Button();
            comboBoxQuequan = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HinhQLKH).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(288, 21);
            label1.Name = "label1";
            label1.Size = new Size(334, 38);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // dataGridViewCustomer
            // 
            dataGridViewCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomer.Location = new Point(-2, 362);
            dataGridViewCustomer.Name = "dataGridViewCustomer";
            dataGridViewCustomer.RowHeadersWidth = 51;
            dataGridViewCustomer.Size = new Size(1284, 344);
            dataGridViewCustomer.TabIndex = 19;
            dataGridViewCustomer.CellClick += CellClickToPageCustomer;
            // 
            // HinhQLKH
            // 
            HinhQLKH.BackColor = SystemColors.ControlLightLight;
            HinhQLKH.Image = (Image)resources.GetObject("HinhQLKH.Image");
            HinhQLKH.Location = new Point(743, 21);
            HinhQLKH.Name = "HinhQLKH";
            HinhQLKH.Size = new Size(527, 327);
            HinhQLKH.SizeMode = PictureBoxSizeMode.Zoom;
            HinhQLKH.TabIndex = 18;
            HinhQLKH.TabStop = false;
            // 
            // tTenkhachhang
            // 
            tTenkhachhang.Location = new Point(227, 115);
            tTenkhachhang.Name = "tTenkhachhang";
            tTenkhachhang.Size = new Size(478, 27);
            tTenkhachhang.TabIndex = 17;
            // 
            // tDiachi
            // 
            tDiachi.Location = new Point(227, 211);
            tDiachi.Name = "tDiachi";
            tDiachi.Size = new Size(478, 27);
            tDiachi.TabIndex = 16;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(78, 182);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(58, 25);
            labelEmail.TabIndex = 14;
            labelEmail.Text = "Email";
            // 
            // labelDiachi
            // 
            labelDiachi.AutoSize = true;
            labelDiachi.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDiachi.Location = new Point(78, 211);
            labelDiachi.Name = "labelDiachi";
            labelDiachi.Size = new Size(70, 25);
            labelDiachi.TabIndex = 13;
            labelDiachi.Text = "Địa chỉ";
            // 
            // labelTenkhachhang
            // 
            labelTenkhachhang.AutoSize = true;
            labelTenkhachhang.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTenkhachhang.Location = new Point(75, 117);
            labelTenkhachhang.Name = "labelTenkhachhang";
            labelTenkhachhang.Size = new Size(146, 25);
            labelTenkhachhang.TabIndex = 12;
            labelTenkhachhang.Text = "Tên khách hàng";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.IndianRed;
            buttonDelete.Location = new Point(653, 712);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 22;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += ClickToPageDelete;
            // 
            // tEmail
            // 
            tEmail.Location = new Point(227, 180);
            tEmail.Name = "tEmail";
            tEmail.Size = new Size(478, 27);
            tEmail.TabIndex = 24;
            // 
            // tSdt
            // 
            tSdt.Location = new Point(227, 148);
            tSdt.Name = "tSdt";
            tSdt.Size = new Size(478, 27);
            tSdt.TabIndex = 25;
            // 
            // labelSodienthoai
            // 
            labelSodienthoai.AutoSize = true;
            labelSodienthoai.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSodienthoai.Location = new Point(78, 150);
            labelSodienthoai.Name = "labelSodienthoai";
            labelSodienthoai.Size = new Size(124, 25);
            labelSodienthoai.TabIndex = 26;
            labelSodienthoai.Text = "Số điện thoại";
            // 
            // labelMaxacnhan
            // 
            labelMaxacnhan.AutoSize = true;
            labelMaxacnhan.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMaxacnhan.Location = new Point(75, 279);
            labelMaxacnhan.Name = "labelMaxacnhan";
            labelMaxacnhan.Size = new Size(119, 25);
            labelMaxacnhan.TabIndex = 27;
            labelMaxacnhan.Text = "CMND/CCCD";
            labelMaxacnhan.Click += labelMaxacnhan_Click;
            // 
            // tCMND
            // 
            tCMND.Location = new Point(225, 279);
            tCMND.Name = "tCMND";
            tCMND.Size = new Size(478, 27);
            tCMND.TabIndex = 28;
            // 
            // labelNgaysinh
            // 
            labelNgaysinh.AutoSize = true;
            labelNgaysinh.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNgaysinh.Location = new Point(78, 245);
            labelNgaysinh.Name = "labelNgaysinh";
            labelNgaysinh.Size = new Size(95, 25);
            labelNgaysinh.TabIndex = 30;
            labelNgaysinh.Text = "Quê quán";
            // 
            // tID
            // 
            tID.Location = new Point(227, 82);
            tID.Name = "tID";
            tID.Size = new Size(478, 27);
            tID.TabIndex = 32;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelID.Location = new Point(78, 84);
            labelID.Name = "labelID";
            labelID.Size = new Size(31, 25);
            labelID.TabIndex = 31;
            labelID.Text = "ID";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(528, 712);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 33;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ClickToSave;
            // 
            // comboBoxQuequan
            // 
            comboBoxQuequan.FormattingEnabled = true;
            comboBoxQuequan.Items.AddRange(new object[] { "1. Hà Nội  ", "2. Hải Phòng  ", "3. Đà Nẵng  ", "4. Hồ Chí Minh  ", "5. Cần Thơ  ", "6. Quảng Ninh  ", "7. Hải Dương  ", "8. Bắc Ninh  ", "9. Vĩnh Phúc  ", "10. Hưng Yên  ", "11. Thái Bình  ", "12. Nam Định  ", "13. Hà Nam  ", "14. Ninh Bình  ", "15. Thanh Hóa  ", "16. Nghệ An  ", "17. Hà Tĩnh  ", "18. Quảng Bình  ", "19. Quảng Trị  ", "20. Thừa Thiên Huế  ", "21. Quảng Nam  ", "22. Quảng Ngãi  ", "23. Bình Định  ", "24. Phú Yên  ", "25. Khánh Hòa  ", "26. Ninh Thuận  ", "27. Bình Thuận  ", "28. Lâm Đồng  ", "29. Đắk Lắk  ", "30. Đắk Nông  ", "31. Gia Lai  ", "32. Kon Tum  ", "33. Bình Phước  ", "34. Bình Dương  ", "35. Tây Ninh  ", "36. Đồng Nai  ", "37. Bà Rịa - Vũng Tàu  ", "38. Long An  ", "39. Tiền Giang  ", "40. Bến Tre  ", "41. Trà Vinh  ", "42. Vĩnh Long  ", "43. Đồng Tháp  ", "44. An Giang  ", "45. Kiên Giang  ", "46. Hậu Giang  ", "47. Sóc Trăng  ", "48. Bạc Liêu  ", "49. Cà Mau  ", "50. Bắc Giang  ", "51. Bắc Kạn  ", "52. Thái Nguyên  ", "53. Lạng Sơn  ", "54. Cao Bằng  ", "55. Hà Giang  ", "56. Tuyên Quang  ", "57. Phú Thọ  ", "58. Yên Bái  ", "59. Lào Cai  ", "60. Sơn La  ", "61. Điện Biên  ", "62. Lai Châu  ", "63. Hòa Bình  " });
            comboBoxQuequan.Location = new Point(227, 242);
            comboBoxQuequan.Name = "comboBoxQuequan";
            comboBoxQuequan.Size = new Size(476, 28);
            comboBoxQuequan.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 311);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 35;
            label2.Text = "Image";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(225, 312);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(478, 27);
            textBox1.TabIndex = 36;
            // 
            // fCustomerManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1282, 753);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(comboBoxQuequan);
            Controls.Add(buttonSave);
            Controls.Add(tID);
            Controls.Add(labelID);
            Controls.Add(labelNgaysinh);
            Controls.Add(tCMND);
            Controls.Add(labelMaxacnhan);
            Controls.Add(labelSodienthoai);
            Controls.Add(tSdt);
            Controls.Add(tEmail);
            Controls.Add(dataGridViewCustomer);
            Controls.Add(HinhQLKH);
            Controls.Add(tTenkhachhang);
            Controls.Add(tDiachi);
            Controls.Add(labelEmail);
            Controls.Add(labelDiachi);
            Controls.Add(labelTenkhachhang);
            Controls.Add(buttonDelete);
            Controls.Add(label1);
            Name = "fCustomerManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)HinhQLKH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void labelMaxacnhan_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Click_Delete(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion

        private Label label1;
        private DataGridView dataGridViewCustomer;
        private PictureBox HinhQLKH;
        private TextBox tTenkhachhang;
        private TextBox tDiachi;
        private Label labelEmail;
        private Label labelDiachi;
        private Label labelTenkhachhang;
        private Button buttonDelete;
        private TextBox tEmail;
        private TextBox tSdt;
        private Label labelSodienthoai;
        private Label labelMaxacnhan;
        private TextBox tCMND;
        private Label labelNgaysinh;
        private TextBox tID;
        private Label labelID;
        private Button buttonSave;
        private ComboBox comboBoxQuequan;
        private Label label2;
        private TextBox textBox1;
    }
}