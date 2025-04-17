namespace hotelManagement.View
{
    partial class Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room));
            label1 = new Label();
            dataGridViewRoom = new DataGridView();
            HinhQLKH = new PictureBox();
            tGiaThue = new TextBox();
            labelEmail = new Label();
            labelDiachi = new Label();
            labelTenkhachhang = new Label();
            buttonDelete = new Button();
            tSucChuaPhong = new TextBox();
            labelSodienthoai = new Label();
            tID = new TextBox();
            labelID = new Label();
            buttonSave = new Button();
            comboBoxLoaiPhong = new ComboBox();
            comboBoxTrangThai = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HinhQLKH).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(288, 21);
            label1.Name = "label1";
            label1.Size = new Size(247, 38);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ PHÒNG";
            // 
            // dataGridViewRoom
            // 
            dataGridViewRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoom.Location = new Point(-2, 362);
            dataGridViewRoom.Name = "dataGridViewRoom";
            dataGridViewRoom.RowHeadersWidth = 51;
            dataGridViewRoom.Size = new Size(1284, 344);
            dataGridViewRoom.TabIndex = 19;
            dataGridViewRoom.CellClick += CellClickRoom;
            // 
            // HinhQLKH
            // 
            HinhQLKH.BackColor = SystemColors.ControlLightLight;
            HinhQLKH.Image = (Image)resources.GetObject("HinhQLKH.Image");
            HinhQLKH.Location = new Point(730, 12);
            HinhQLKH.Name = "HinhQLKH";
            HinhQLKH.Size = new Size(527, 327);
            HinhQLKH.SizeMode = PictureBoxSizeMode.Zoom;
            HinhQLKH.TabIndex = 18;
            HinhQLKH.TabStop = false;
            // 
            // tGiaThue
            // 
            tGiaThue.Location = new Point(227, 151);
            tGiaThue.Name = "tGiaThue";
            tGiaThue.Size = new Size(478, 27);
            tGiaThue.TabIndex = 16;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(52, 184);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(152, 25);
            labelEmail.TabIndex = 14;
            labelEmail.Text = "Sức Chứa Phòng";
            // 
            // labelDiachi
            // 
            labelDiachi.AutoSize = true;
            labelDiachi.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDiachi.Location = new Point(52, 150);
            labelDiachi.Name = "labelDiachi";
            labelDiachi.Size = new Size(93, 25);
            labelDiachi.TabIndex = 13;
            labelDiachi.Text = "Giá Thuê ";
            labelDiachi.UseWaitCursor = true;
            // 
            // labelTenkhachhang
            // 
            labelTenkhachhang.AutoSize = true;
            labelTenkhachhang.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTenkhachhang.Location = new Point(52, 120);
            labelTenkhachhang.Name = "labelTenkhachhang";
            labelTenkhachhang.Size = new Size(107, 25);
            labelTenkhachhang.TabIndex = 12;
            labelTenkhachhang.Text = "Loại Phòng";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.IndianRed;
            buttonDelete.Location = new Point(611, 250);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 22;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += ToClickDelete;
            // 
            // tSucChuaPhong
            // 
            tSucChuaPhong.Location = new Point(227, 184);
            tSucChuaPhong.Name = "tSucChuaPhong";
            tSucChuaPhong.Size = new Size(478, 27);
            tSucChuaPhong.TabIndex = 24;
            // 
            // labelSodienthoai
            // 
            labelSodienthoai.AutoSize = true;
            labelSodienthoai.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSodienthoai.Location = new Point(52, 216);
            labelSodienthoai.Name = "labelSodienthoai";
            labelSodienthoai.Size = new Size(103, 25);
            labelSodienthoai.TabIndex = 26;
            labelSodienthoai.Text = "Trạng Thái";
            // 
            // tID
            // 
            tID.Location = new Point(227, 85);
            tID.Name = "tID";
            tID.Size = new Size(478, 27);
            tID.TabIndex = 32;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelID.Location = new Point(52, 85);
            labelID.Name = "labelID";
            labelID.Size = new Size(31, 25);
            labelID.TabIndex = 31;
            labelID.Text = "ID";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Lavender;
            buttonSave.Location = new Point(462, 250);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 33;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += ToClickSave;
            // 
            // comboBoxLoaiPhong
            // 
            comboBoxLoaiPhong.FormattingEnabled = true;
            comboBoxLoaiPhong.Items.AddRange(new object[] { "Single", "Double", "VIP" });
            comboBoxLoaiPhong.Location = new Point(227, 118);
            comboBoxLoaiPhong.Name = "comboBoxLoaiPhong";
            comboBoxLoaiPhong.Size = new Size(478, 28);
            comboBoxLoaiPhong.TabIndex = 34;
            // 
            // comboBoxTrangThai
            // 
            comboBoxTrangThai.FormattingEnabled = true;
            comboBoxTrangThai.Items.AddRange(new object[] { "reserved", "occupied", "available" });
            comboBoxTrangThai.Location = new Point(227, 216);
            comboBoxTrangThai.Name = "comboBoxTrangThai";
            comboBoxTrangThai.Size = new Size(478, 28);
            comboBoxTrangThai.TabIndex = 35;
            // 
            // Room
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1282, 753);
            Controls.Add(comboBoxTrangThai);
            Controls.Add(comboBoxLoaiPhong);
            Controls.Add(buttonSave);
            Controls.Add(tID);
            Controls.Add(labelID);
            Controls.Add(labelSodienthoai);
            Controls.Add(tSucChuaPhong);
            Controls.Add(dataGridViewRoom);
            Controls.Add(HinhQLKH);
            Controls.Add(tGiaThue);
            Controls.Add(labelEmail);
            Controls.Add(labelDiachi);
            Controls.Add(labelTenkhachhang);
            Controls.Add(buttonDelete);
            Controls.Add(label1);
            Name = "Room";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Room";
            Load += Room_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)HinhQLKH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void labelMaxacnhan_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        

        #endregion

        private Label label1;
        private DataGridView dataGridViewRoom;
        private PictureBox HinhQLKH;
        private TextBox tGiaThue;
        private Label labelEmail;
        private Label labelDiachi;
        private Label labelTenkhachhang;
        private Button buttonDelete;
        private TextBox tSucChuaPhong;
        private Label labelSodienthoai;
        private TextBox tID;
        private Label labelID;
        private Button buttonSave;
        private ComboBox comboBoxLoaiPhong;
        private ComboBox comboBoxTrangThai;
    }
}