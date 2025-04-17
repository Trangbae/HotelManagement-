
namespace hotelManagement.View
{
    partial class fEmployeeManegement
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


        #endregion
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEmployeeManegement));
            buttonDelete = new Button();
            pictureBox1 = new PictureBox();
            tTennhanvien = new TextBox();
            tTentaikhoan = new TextBox();
            labelMatkhau = new Label();
            labelTentaikhoan = new Label();
            labelTennhanvien = new Label();
            labelQLCN = new Label();
            labelChucvu = new Label();
            dataGridViewEmployee = new DataGridView();
            buttonSave = new Button();
            tID = new TextBox();
            labelID = new Label();
            comboBoxChucvu = new ComboBox();
            tMatkhau = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployee).BeginInit();
            SuspendLayout();
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.IndianRed;
            buttonDelete.Location = new Point(677, 694);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 24;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += ClickToDelete;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(697, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(563, 279);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // tTennhanvien
            // 
            tTennhanvien.Location = new Point(189, 120);
            tTennhanvien.Name = "tTennhanvien";
            tTennhanvien.Size = new Size(478, 27);
            tTennhanvien.TabIndex = 19;
            // 
            // tTentaikhoan
            // 
            tTentaikhoan.Location = new Point(189, 152);
            tTentaikhoan.Name = "tTentaikhoan";
            tTentaikhoan.Size = new Size(478, 27);
            tTentaikhoan.TabIndex = 18;
            // 
            // labelMatkhau
            // 
            labelMatkhau.AutoSize = true;
            labelMatkhau.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMatkhau.Location = new Point(40, 188);
            labelMatkhau.Name = "labelMatkhau";
            labelMatkhau.Size = new Size(98, 25);
            labelMatkhau.TabIndex = 16;
            labelMatkhau.Text = "Mật khẩu ";
            // 
            // labelTentaikhoan
            // 
            labelTentaikhoan.AutoSize = true;
            labelTentaikhoan.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTentaikhoan.Location = new Point(40, 154);
            labelTentaikhoan.Name = "labelTentaikhoan";
            labelTentaikhoan.Size = new Size(127, 25);
            labelTentaikhoan.TabIndex = 15;
            labelTentaikhoan.Text = "Tên tài khoản";
            // 
            // labelTennhanvien
            // 
            labelTennhanvien.AutoSize = true;
            labelTennhanvien.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTennhanvien.Location = new Point(40, 122);
            labelTennhanvien.Name = "labelTennhanvien";
            labelTennhanvien.Size = new Size(131, 25);
            labelTennhanvien.TabIndex = 14;
            labelTennhanvien.Text = "Tên nhân viên";
            // 
            // labelQLCN
            // 
            labelQLCN.AutoSize = true;
            labelQLCN.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQLCN.Location = new Point(251, 30);
            labelQLCN.Name = "labelQLCN";
            labelQLCN.Size = new Size(304, 38);
            labelQLCN.TabIndex = 13;
            labelQLCN.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // labelChucvu
            // 
            labelChucvu.AutoSize = true;
            labelChucvu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelChucvu.Location = new Point(40, 219);
            labelChucvu.Name = "labelChucvu";
            labelChucvu.Size = new Size(86, 25);
            labelChucvu.TabIndex = 26;
            labelChucvu.Text = "Chức vụ ";
            labelChucvu.Click += label1_Click;
            // 
            // dataGridViewEmployee
            // 
            dataGridViewEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployee.Location = new Point(-1, 346);
            dataGridViewEmployee.Name = "dataGridViewEmployee";
            dataGridViewEmployee.RowHeadersWidth = 51;
            dataGridViewEmployee.Size = new Size(1284, 320);
            dataGridViewEmployee.TabIndex = 21;
            dataGridViewEmployee.CellClick += CellClickTo_dataGridViewEmployee;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(552, 694);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 34;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ClickToSave;
            // 
            // tID
            // 
            tID.Location = new Point(189, 87);
            tID.Name = "tID";
            tID.Size = new Size(478, 27);
            tID.TabIndex = 36;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelID.Location = new Point(40, 89);
            labelID.Name = "labelID";
            labelID.Size = new Size(31, 25);
            labelID.TabIndex = 35;
            labelID.Text = "ID";
            // 
            // comboBoxChucvu
            // 
            comboBoxChucvu.FormattingEnabled = true;
            comboBoxChucvu.Items.AddRange(new object[] { "Manager", "Serve ", "Reception" });
            comboBoxChucvu.Location = new Point(189, 219);
            comboBoxChucvu.Name = "comboBoxChucvu";
            comboBoxChucvu.Size = new Size(478, 28);
            comboBoxChucvu.TabIndex = 37;
            // 
            // tMatkhau
            // 
            tMatkhau.Location = new Point(189, 186);
            tMatkhau.Name = "tMatkhau";
            tMatkhau.Size = new Size(478, 27);
            tMatkhau.TabIndex = 38;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(189, 253);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(478, 27);
            textBox1.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 249);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 39;
            label1.Text = "Image";
            // 
            // fEmployeeManegement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1282, 753);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(tMatkhau);
            Controls.Add(comboBoxChucvu);
            Controls.Add(tID);
            Controls.Add(labelID);
            Controls.Add(buttonSave);
            Controls.Add(labelChucvu);
            Controls.Add(buttonDelete);
            Controls.Add(dataGridViewEmployee);
            Controls.Add(pictureBox1);
            Controls.Add(tTennhanvien);
            Controls.Add(tTentaikhoan);
            Controls.Add(labelMatkhau);
            Controls.Add(labelTentaikhoan);
            Controls.Add(labelTennhanvien);
            Controls.Add(labelQLCN);
            Name = "fEmployeeManegement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        


        #endregion
        private Button buttonDelete;
        private PictureBox pictureBox1;
        private TextBox tTennhanvien;
        private TextBox tTentaikhoan;
        private Label labelMatkhau;
        private Label labelTentaikhoan;
        private Label labelTennhanvien;
        private Label labelQLCN;
        private Label labelChucvu;
        private DataGridView dataGridViewEmployee;
        private Button buttonSave;
        private TextBox tID;
        private Label labelID;
        private ComboBox comboBoxChucvu;
        private TextBox tMatkhau;
        private TextBox textBox1;
        private Label label1;
    }
}
   