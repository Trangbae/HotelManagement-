using hotelManagement.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelManagement
{
   
    public partial class fLogin : Form
    {
       
        public fLogin(fMainManager form)
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

        }

        private void ClickToMain(object sender, EventArgs e)
        {
            fMainManager fMain = new fMainManager();
            fMain.ShowDialog();
            this.Show();
        }

    
        
    }
}
