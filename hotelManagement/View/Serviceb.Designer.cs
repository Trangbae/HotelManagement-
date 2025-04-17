namespace hotelManagement.View
{
    partial class Serviceb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Serviceb));
            tID = new TextBox();
            labelID = new Label();
            labelSodienthoai = new Label();
            tMoTa = new TextBox();
            HinhQLKH = new PictureBox();
            tTen = new TextBox();
            tGiaThue = new TextBox();
            labelEmail = new Label();
            labelDiachi = new Label();
            labelTenkhachhang = new Label();
            label1 = new Label();
            buttonSave = new Button();
            buttonDelete = new Button();
            dataGridViewService = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)HinhQLKH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewService).BeginInit();
            SuspendLayout();
            // 
            // tID
            // 
            tID.Location = new Point(195, 98);
            tID.Name = "tID";
            tID.Size = new Size(478, 27);
            tID.TabIndex = 44;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelID.Location = new Point(66, 101);
            labelID.Name = "labelID";
            labelID.Size = new Size(31, 25);
            labelID.TabIndex = 43;
            labelID.Text = "ID";
            // 
            // labelSodienthoai
            // 
            labelSodienthoai.AutoSize = true;
            labelSodienthoai.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSodienthoai.Location = new Point(20, 324);
            labelSodienthoai.Name = "labelSodienthoai";
            labelSodienthoai.Size = new Size(0, 25);
            labelSodienthoai.TabIndex = 42;
            // 
            // tMoTa
            // 
            tMoTa.Location = new Point(195, 164);
            tMoTa.Name = "tMoTa";
            tMoTa.Size = new Size(478, 27);
            tMoTa.TabIndex = 40;
            // 
            // HinhQLKH
            // 
            HinhQLKH.BackColor = SystemColors.ControlLightLight;
            HinhQLKH.Image = (Image)resources.GetObject("HinhQLKH.Image");
            HinhQLKH.Location = new Point(698, 25);
            HinhQLKH.Name = "HinhQLKH";
            HinhQLKH.Size = new Size(527, 327);
            HinhQLKH.SizeMode = PictureBoxSizeMode.Zoom;
            HinhQLKH.TabIndex = 39;
            HinhQLKH.TabStop = false;
            // 
            // tTen
            // 
            tTen.Location = new Point(195, 131);
            tTen.Name = "tTen";
            tTen.Size = new Size(478, 27);
            tTen.TabIndex = 38;
            // 
            // tGiaThue
            // 
            tGiaThue.Location = new Point(195, 197);
            tGiaThue.Name = "tGiaThue";
            tGiaThue.Size = new Size(478, 27);
            tGiaThue.TabIndex = 37;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(66, 199);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(66, 25);
            labelEmail.TabIndex = 36;
            labelEmail.Text = "Mô Tả";
            // 
            // labelDiachi
            // 
            labelDiachi.AutoSize = true;
            labelDiachi.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDiachi.Location = new Point(66, 166);
            labelDiachi.Name = "labelDiachi";
            labelDiachi.Size = new Size(93, 25);
            labelDiachi.TabIndex = 35;
            labelDiachi.Text = "Giá Thuê ";
            labelDiachi.UseWaitCursor = true;
            // 
            // labelTenkhachhang
            // 
            labelTenkhachhang.AutoSize = true;
            labelTenkhachhang.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTenkhachhang.Location = new Point(66, 136);
            labelTenkhachhang.Name = "labelTenkhachhang";
            labelTenkhachhang.Size = new Size(42, 25);
            labelTenkhachhang.TabIndex = 34;
            labelTenkhachhang.Text = "Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(256, 34);
            label1.Name = "label1";
            label1.Size = new Size(261, 38);
            label1.TabIndex = 33;
            label1.Text = "QUẢN LÝ DỊCH VỤ";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(467, 230);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 46;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ToPageClickSave;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.IndianRed;
            buttonDelete.Location = new Point(579, 230);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 45;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += ToPageClickDelete;
            // 
            // dataGridViewService
            // 
            dataGridViewService.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewService.Location = new Point(-4, 362);
            dataGridViewService.Name = "dataGridViewService";
            dataGridViewService.RowHeadersWidth = 51;
            dataGridViewService.Size = new Size(1284, 344);
            dataGridViewService.TabIndex = 47;
            dataGridViewService.CellClick += CellClickToDataService;
            // 
            // Serviceb
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1282, 753);
            Controls.Add(dataGridViewService);
            Controls.Add(buttonSave);
            Controls.Add(buttonDelete);
            Controls.Add(tID);
            Controls.Add(labelID);
            Controls.Add(labelSodienthoai);
            Controls.Add(tMoTa);
            Controls.Add(HinhQLKH);
            Controls.Add(tTen);
            Controls.Add(tGiaThue);
            Controls.Add(labelEmail);
            Controls.Add(labelDiachi);
            Controls.Add(labelTenkhachhang);
            Controls.Add(label1);
            Name = "Serviceb";
            Text = "Service";
            ((System.ComponentModel.ISupportInitialize)HinhQLKH).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewService).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tID;
        private Label labelID;
        private Label labelSodienthoai;
        private TextBox tMoTa;
        private PictureBox HinhQLKH;
        private TextBox tTen;
        private TextBox tGiaThue;
        private Label labelEmail;
        private Label labelDiachi;
        private Label labelTenkhachhang;
        private Label label1;
        private Button buttonSave;
        private Button buttonDelete;
        private DataGridView dataGridViewService;
    }
}