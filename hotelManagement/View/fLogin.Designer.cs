using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using Font = System.Drawing.Font;
using System.Xml.Linq;

namespace hotelManagement
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            panel1 = new Panel();
            labelDangnhap = new Label();
            labelTenDangNhap = new Label();
            labelMatkhau = new Label();
            textBoxTenDangNhap = new TextBox();
            textBoxMatKhau = new TextBox();
            buttonHuy = new Button();
            btnDangNhap = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(labelDangnhap);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 120);
            panel1.TabIndex = 0;
            // 
            // labelDangnhap
            // 
            labelDangnhap.AutoSize = true;
            labelDangnhap.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDangnhap.Location = new Point(330, 46);
            labelDangnhap.Name = "labelDangnhap";
            labelDangnhap.Size = new Size(153, 35);
            labelDangnhap.TabIndex = 0;
            labelDangnhap.Text = "Đăng nhập";
            labelDangnhap.Click += label1_Click;
            // 
            // labelTenDangNhap
            // 
            labelTenDangNhap.AutoSize = true;
            labelTenDangNhap.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTenDangNhap.Location = new Point(284, 169);
            labelTenDangNhap.Name = "labelTenDangNhap";
            labelTenDangNhap.Size = new Size(120, 19);
            labelTenDangNhap.TabIndex = 1;
            labelTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // labelMatkhau
            // 
            labelMatkhau.AutoSize = true;
            labelMatkhau.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMatkhau.Location = new Point(284, 194);
            labelMatkhau.Name = "labelMatkhau";
            labelMatkhau.Size = new Size(84, 19);
            labelMatkhau.TabIndex = 2;
            labelMatkhau.Text = "Mật khẩu:";
            // 
            // textBoxTenDangNhap
            // 
            textBoxTenDangNhap.Location = new Point(422, 162);
            textBoxTenDangNhap.Name = "textBoxTenDangNhap";
            textBoxTenDangNhap.Size = new Size(324, 27);
            textBoxTenDangNhap.TabIndex = 0;
            // 
            // textBoxMatKhau
            // 
            textBoxMatKhau.Location = new Point(422, 193);
            textBoxMatKhau.Name = "textBoxMatKhau";
            textBoxMatKhau.Size = new Size(324, 27);
            textBoxMatKhau.TabIndex = 1;
            textBoxMatKhau.UseSystemPasswordChar = true;
            // 
            // buttonHuy
            // 
            buttonHuy.BackColor = SystemColors.ButtonFace;
            buttonHuy.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHuy.Location = new Point(634, 226);
            buttonHuy.Name = "buttonHuy";
            buttonHuy.Size = new Size(112, 41);
            buttonHuy.TabIndex = 3;
            buttonHuy.Text = "Hủy";
            buttonHuy.UseVisualStyleBackColor = false;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.Orange;
            btnDangNhap.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.Location = new Point(502, 226);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(112, 41);
            btnDangNhap.TabIndex = 5;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += ClickToMain;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 256);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnDangNhap);
            Controls.Add(buttonHuy);
            Controls.Add(textBoxMatKhau);
            Controls.Add(textBoxTenDangNhap);
            Controls.Add(labelMatkhau);
            Controls.Add(labelTenDangNhap);
            Controls.Add(panel1);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Label labelTenDangNhap;
        private Label labelMatkhau;
        private TextBox textBoxTenDangNhap;
        private TextBox textBoxMatKhau;
        private Label labelDangnhap;
        private Button buttonHuy;
        private Button btnDangNhap;
        private PictureBox pictureBox1;
    }
}