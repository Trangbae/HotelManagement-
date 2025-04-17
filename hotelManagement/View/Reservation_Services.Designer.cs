namespace hotelManagement.View
{
    partial class Reservation_Services
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation_Services));
            tRID = new TextBox();
            labelID = new Label();
            dataGridView = new DataGridView();
            labelDiachi = new Label();
            labelTenkhachhang = new Label();
            label1 = new Label();
            btnSave = new Button();
            buttonDelete = new Button();
            tSID = new TextBox();
            tSoLuongDichVu = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tRID
            // 
            tRID.Location = new Point(341, 111);
            tRID.Name = "tRID";
            tRID.Size = new Size(542, 27);
            tRID.TabIndex = 65;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelID.Location = new Point(149, 115);
            labelID.Name = "labelID";
            labelID.Size = new Size(143, 25);
            labelID.TabIndex = 64;
            labelID.Text = "ReservationID :";
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(0, 292);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1284, 409);
            dataGridView.TabIndex = 60;
            dataGridView.CellClick += ToData;
            // 
            // labelDiachi
            // 
            labelDiachi.AutoSize = true;
            labelDiachi.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDiachi.Location = new Point(149, 181);
            labelDiachi.Name = "labelDiachi";
            labelDiachi.Size = new Size(173, 25);
            labelDiachi.TabIndex = 56;
            labelDiachi.Text = "Số Lượng Dịch Vụ :";
            labelDiachi.UseWaitCursor = true;
            // 
            // labelTenkhachhang
            // 
            labelTenkhachhang.AutoSize = true;
            labelTenkhachhang.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTenkhachhang.Location = new Point(149, 146);
            labelTenkhachhang.Name = "labelTenkhachhang";
            labelTenkhachhang.Size = new Size(103, 25);
            labelTenkhachhang.TabIndex = 55;
            labelTenkhachhang.Text = "ServiceID :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(523, 32);
            label1.Name = "label1";
            label1.Size = new Size(295, 38);
            label1.TabIndex = 54;
            label1.Text = "THÔNG TIN DỊCH VỤ";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(661, 222);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 71;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += ToPageSave;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.IndianRed;
            buttonDelete.Location = new Point(789, 222);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 70;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += ToPageDelete;
            // 
            // tSID
            // 
            tSID.Location = new Point(341, 144);
            tSID.Name = "tSID";
            tSID.Size = new Size(542, 27);
            tSID.TabIndex = 72;
            // 
            // tSoLuongDichVu
            // 
            tSoLuongDichVu.Location = new Point(341, 177);
            tSoLuongDichVu.Name = "tSoLuongDichVu";
            tSoLuongDichVu.Size = new Size(542, 27);
            tSoLuongDichVu.TabIndex = 73;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(915, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(345, 254);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 74;
            pictureBox1.TabStop = false;
            // 
            // Reservation_Services
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1282, 753);
            Controls.Add(pictureBox1);
            Controls.Add(tSoLuongDichVu);
            Controls.Add(tSID);
            Controls.Add(btnSave);
            Controls.Add(buttonDelete);
            Controls.Add(tRID);
            Controls.Add(labelID);
            Controls.Add(dataGridView);
            Controls.Add(labelDiachi);
            Controls.Add(labelTenkhachhang);
            Controls.Add(label1);
            Name = "Reservation_Services";
            Text = "Reservation_Services";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tRID;
        private Label labelID;
        private DataGridView dataGridView;
        private Label labelDiachi;
        private Label labelTenkhachhang;
        private Label label1;
        private Button btnSave;
        private Button buttonDelete;
        private TextBox tSID;
        private TextBox tSoLuongDichVu;
        private PictureBox pictureBox1;
    }
}