namespace hotelManagement.View
{
    partial class Reservations
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
            tID = new TextBox();
            labelID = new Label();
            labelSodienthoai = new Label();
            dataGridViewCustomer = new DataGridView();
            tCustomerID = new TextBox();
            tRoomID = new TextBox();
            labelEmail = new Label();
            labelDiachi = new Label();
            labelTenkhachhang = new Label();
            label1 = new Label();
            btnSave = new Button();
            btnDelete = new Button();
            label2 = new Label();
            tTongChiPhi = new TextBox();
            label4 = new Label();
            tEmployeeID = new TextBox();
            dateTimeCheckIn = new DateTimePicker();
            dateTimeCheckOut = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).BeginInit();
            SuspendLayout();
            // 
            // tID
            // 
            tID.Location = new Point(228, 103);
            tID.Name = "tID";
            tID.Size = new Size(370, 27);
            tID.TabIndex = 45;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelID.Location = new Point(53, 101);
            labelID.Name = "labelID";
            labelID.Size = new Size(41, 25);
            labelID.TabIndex = 44;
            labelID.Text = "ID :";
            // 
            // labelSodienthoai
            // 
            labelSodienthoai.AutoSize = true;
            labelSodienthoai.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSodienthoai.Location = new Point(707, 103);
            labelSodienthoai.Name = "labelSodienthoai";
            labelSodienthoai.Size = new Size(159, 25);
            labelSodienthoai.TabIndex = 43;
            labelSodienthoai.Text = "Check_out_date  :";
            // 
            // dataGridViewCustomer
            // 
            dataGridViewCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomer.Location = new Point(3, 323);
            dataGridViewCustomer.Name = "dataGridViewCustomer";
            dataGridViewCustomer.RowHeadersWidth = 51;
            dataGridViewCustomer.Size = new Size(1284, 386);
            dataGridViewCustomer.TabIndex = 40;
            dataGridViewCustomer.CellClick += CellClickPageData;
            // 
            // tCustomerID
            // 
            tCustomerID.Location = new Point(228, 136);
            tCustomerID.Name = "tCustomerID";
            tCustomerID.Size = new Size(370, 27);
            tCustomerID.TabIndex = 38;
            // 
            // tRoomID
            // 
            tRoomID.Location = new Point(228, 169);
            tRoomID.Name = "tRoomID";
            tRoomID.Size = new Size(370, 27);
            tRoomID.TabIndex = 37;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(53, 204);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(141, 25);
            labelEmail.TabIndex = 36;
            labelEmail.Text = "Check_in_date :";
            // 
            // labelDiachi
            // 
            labelDiachi.AutoSize = true;
            labelDiachi.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDiachi.Location = new Point(53, 169);
            labelDiachi.Name = "labelDiachi";
            labelDiachi.Size = new Size(91, 25);
            labelDiachi.TabIndex = 35;
            labelDiachi.Text = "RoomID :";
            labelDiachi.UseWaitCursor = true;
            // 
            // labelTenkhachhang
            // 
            labelTenkhachhang.AutoSize = true;
            labelTenkhachhang.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTenkhachhang.Location = new Point(53, 136);
            labelTenkhachhang.Name = "labelTenkhachhang";
            labelTenkhachhang.Size = new Size(122, 25);
            labelTenkhachhang.TabIndex = 34;
            labelTenkhachhang.Text = "CustomerID :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(527, 21);
            label1.Name = "label1";
            label1.Size = new Size(312, 38);
            label1.TabIndex = 33;
            label1.Text = "QUẢN LÝ ĐẶT PHÒNG";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(987, 225);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 47;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += ClickToSave;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Location = new Point(1099, 225);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 46;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += ClickToDelete;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(707, 138);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 49;
            label2.Text = "Tổng Chi Phí :";
            // 
            // tTongChiPhi
            // 
            tTongChiPhi.Location = new Point(885, 132);
            tTongChiPhi.Name = "tTongChiPhi";
            tTongChiPhi.Size = new Size(361, 27);
            tTongChiPhi.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(707, 171);
            label4.Name = "label4";
            label4.Size = new Size(124, 25);
            label4.TabIndex = 53;
            label4.Text = "EmployeeID :";
            // 
            // tEmployeeID
            // 
            tEmployeeID.Location = new Point(885, 165);
            tEmployeeID.Name = "tEmployeeID";
            tEmployeeID.Size = new Size(361, 27);
            tEmployeeID.TabIndex = 52;
            // 
            // dateTimeCheckIn
            // 
            dateTimeCheckIn.Location = new Point(228, 202);
            dateTimeCheckIn.Name = "dateTimeCheckIn";
            dateTimeCheckIn.Size = new Size(250, 27);
            dateTimeCheckIn.TabIndex = 54;

            // dateTimeCheckOut
            // 
            dateTimeCheckOut.Location = new Point(885, 99);
            dateTimeCheckOut.Name = "dateTimeCheckOut";
            dateTimeCheckOut.Size = new Size(250, 27);
            dateTimeCheckOut.TabIndex = 55;
            // 
            // Reservations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1282, 753);
            Controls.Add(dateTimeCheckOut);
            Controls.Add(dateTimeCheckIn);
            Controls.Add(label4);
            Controls.Add(tEmployeeID);
            Controls.Add(label2);
            Controls.Add(tTongChiPhi);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(tID);
            Controls.Add(labelID);
            Controls.Add(labelSodienthoai);
            Controls.Add(dataGridViewCustomer);
            Controls.Add(tCustomerID);
            Controls.Add(tRoomID);
            Controls.Add(labelEmail);
            Controls.Add(labelDiachi);
            Controls.Add(labelTenkhachhang);
            Controls.Add(label1);
            Name = "Reservations";
            Text = "Reservations";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tID;
        private Label labelID;
        private Label labelSodienthoai;
        private DataGridView dataGridViewCustomer;
        private TextBox tCustomerID;
        private TextBox tRoomID;
        private Label labelEmail;
        private Label labelDiachi;
        private Label labelTenkhachhang;
        private Label label1;
        private Button btnSave;
        private Button btnDelete;
        private Label label2;
        private TextBox tTongChiPhi;
        private Label label4;
        private TextBox tEmployeeID;
        private DateTimePicker dateTimeCheckIn;
        private DateTimePicker dateTimeCheckOut;
    }
}