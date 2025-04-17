
namespace hotelManagement.View
{
    partial class fMainManager
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMainManager));
            menuStrip1 = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            meuItemLogin = new ToolStripMenuItem();
            menuItemLogout = new ToolStripMenuItem();
            menuItemExit = new ToolStripMenuItem();
            menuSystem = new ToolStripMenuItem();
            menuItemCustomer = new ToolStripMenuItem();
            employeeToolStripMenuItem = new ToolStripMenuItem();
            roomToolStripMenuItem = new ToolStripMenuItem();
            hotelManagementToolStripMenuItem = new ToolStripMenuItem();
            serviceToolStripMenuItem = new ToolStripMenuItem();
            reservationToolStripMenuItem = new ToolStripMenuItem();
            reservationServicesToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            toolStripContainer1 = new ToolStripContainer();
            groupBox1 = new GroupBox();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile, menuSystem, hotelManagementToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1813, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { meuItemLogin, menuItemLogout, menuItemExit });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(50, 24);
            menuFile.Text = "File ";
            // 
            // meuItemLogin
            // 
            meuItemLogin.Name = "meuItemLogin";
            meuItemLogin.Size = new Size(139, 26);
            meuItemLogin.Text = "Login";
            meuItemLogin.Click += ClickToLogin;
            // 
            // menuItemLogout
            // 
            menuItemLogout.Name = "menuItemLogout";
            menuItemLogout.Size = new Size(139, 26);
            menuItemLogout.Text = "Logout";
            // 
            // menuItemExit
            // 
            menuItemExit.Name = "menuItemExit";
            menuItemExit.Size = new Size(139, 26);
            menuItemExit.Text = "Exit";
            // 
            // menuSystem
            // 
            menuSystem.DropDownItems.AddRange(new ToolStripItem[] { menuItemCustomer, employeeToolStripMenuItem, roomToolStripMenuItem });
            menuSystem.Name = "menuSystem";
            menuSystem.Size = new Size(70, 24);
            menuSystem.Text = "System";
            // 
            // menuItemCustomer
            // 
            menuItemCustomer.Name = "menuItemCustomer";
            menuItemCustomer.Size = new Size(158, 26);
            menuItemCustomer.Text = "Customer";
            menuItemCustomer.Click += ClickToCustomer;
            // 
            // employeeToolStripMenuItem
            // 
            employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            employeeToolStripMenuItem.Size = new Size(158, 26);
            employeeToolStripMenuItem.Text = "Employee";
            employeeToolStripMenuItem.Click += ClickToPageEmployee;
            // 
            // roomToolStripMenuItem
            // 
            roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            roomToolStripMenuItem.Size = new Size(158, 26);
            roomToolStripMenuItem.Text = "Room";
            roomToolStripMenuItem.Click += ClickToPageRoom;
            // 
            // hotelManagementToolStripMenuItem
            // 
            hotelManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { serviceToolStripMenuItem, reservationToolStripMenuItem, reservationServicesToolStripMenuItem });
            hotelManagementToolStripMenuItem.Name = "hotelManagementToolStripMenuItem";
            hotelManagementToolStripMenuItem.Size = new Size(152, 24);
            hotelManagementToolStripMenuItem.Text = "Hotel Management";
            // 
            // serviceToolStripMenuItem
            // 
            serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            serviceToolStripMenuItem.Size = new Size(228, 26);
            serviceToolStripMenuItem.Text = "Service";
            serviceToolStripMenuItem.Click += ClickToPageService;
            // 
            // reservationToolStripMenuItem
            // 
            reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            reservationToolStripMenuItem.Size = new Size(228, 26);
            reservationToolStripMenuItem.Text = "Reservation";
            reservationToolStripMenuItem.Click += ClickToPageReservation;
            // 
            // reservationServicesToolStripMenuItem
            // 
            reservationServicesToolStripMenuItem.Name = "reservationServicesToolStripMenuItem";
            reservationServicesToolStripMenuItem.Size = new Size(228, 26);
            reservationServicesToolStripMenuItem.Text = "Reservation_Services";
            reservationServicesToolStripMenuItem.Click += ClickToPageReservation_Services;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            toolStripContainer1.BottomToolStripPanel.Click += toolStripContainer1_BottomToolStripPanel_Click;
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.BackColor = SystemColors.ActiveCaption;
            toolStripContainer1.ContentPanel.Controls.Add(groupBox1);
            toolStripContainer1.ContentPanel.Controls.Add(label5);
            toolStripContainer1.ContentPanel.Controls.Add(label4);
            toolStripContainer1.ContentPanel.Controls.Add(label3);
            toolStripContainer1.ContentPanel.Controls.Add(label2);
            toolStripContainer1.ContentPanel.Controls.Add(label1);
            toolStripContainer1.ContentPanel.Controls.Add(pictureBox5);
            toolStripContainer1.ContentPanel.Controls.Add(pictureBox4);
            toolStripContainer1.ContentPanel.Controls.Add(pictureBox3);
            toolStripContainer1.ContentPanel.Controls.Add(pictureBox2);
            toolStripContainer1.ContentPanel.Controls.Add(pictureBox1);
            toolStripContainer1.ContentPanel.Size = new Size(1813, 993);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.LeftToolStripPanelVisible = false;
            toolStripContainer1.Location = new Point(0, 28);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.RightToolStripPanelVisible = false;
            toolStripContainer1.Size = new Size(1813, 993);
            toolStripContainer1.TabIndex = 6;
            toolStripContainer1.Text = "toolStripContainer1";
            toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(toolStrip1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1813, 38);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripButton5, toolStripButton6 });
            toolStrip1.Location = new Point(3, 8);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(187, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "menu";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 24);
            toolStripButton2.Text = "quay lại";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 24);
            toolStripButton3.Text = "tiến tới";
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(29, 24);
            toolStripButton4.Text = "print";
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(29, 24);
            toolStripButton5.Text = "save";
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(29, 24);
            toolStripButton6.Text = "export";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(442, 802);
            label5.Name = "label5";
            label5.Size = new Size(388, 41);
            label5.TabIndex = 10;
            label5.Text = "Ghế nằm vô cực Khách sạn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1006, 802);
            label4.Name = "label4";
            label4.Size = new Size(399, 41);
            label4.TabIndex = 9;
            label4.Text = "Massages vô cực Khách sạn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1228, 366);
            label3.Name = "label3";
            label3.Size = new Size(355, 41);
            label3.TabIndex = 8;
            label3.Text = "Phòng vô cực Khách sạn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(721, 363);
            label2.Name = "label2";
            label2.Size = new Size(341, 41);
            label2.TabIndex = 7;
            label2.Text = "Sảnh vô cực Khách sạn ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(208, 364);
            label1.Name = "label1";
            label1.Size = new Size(339, 38);
            label1.TabIndex = 6;
            label1.Text = "Hồ bơi vô cực Khách sạn";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(974, 551);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(424, 243);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(410, 551);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(420, 234);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1152, 93);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(430, 249);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(661, 93);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(413, 249);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(199, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 249);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // fMainManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1813, 1021);
            Controls.Add(toolStripContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fMainManager";
            Text = "HotelSystem";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ContentPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuSystem;
        private ToolStripMenuItem meuItemLogin;
        private ToolStripMenuItem menuItemLogout;
        private ToolStripMenuItem menuItemCustomer;
        private ToolStripMenuItem menuItemExit;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private ToolStripMenuItem roomToolStripMenuItem;
        private ToolStripMenuItem hotelManagementToolStripMenuItem;
        private ToolStripMenuItem serviceToolStripMenuItem;
        private ToolStripMenuItem reservationToolStripMenuItem;
        private ToolStripMenuItem reservationServicesToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripContainer toolStripContainer1;
        private PictureBox pictureBox1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
    }
}
