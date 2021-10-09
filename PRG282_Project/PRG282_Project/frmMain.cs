using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnViewDB_Click(object sender, EventArgs e)
        {
            btnViewDB.BackColor = SystemColors.Control;
            btnViewCreate.BackColor = Color.FromArgb(0, 111, 207);
            ucDatabase1.Visible = true;
            ucCreate1.Visible = false;
        }

        private void btnViewCreate_Click(object sender, EventArgs e)
        {
            btnViewCreate.BackColor = SystemColors.Control;
            btnViewDB.BackColor = Color.FromArgb(0, 111, 207);
            ucCreate1.Visible = true;
            ucDatabase1.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmLogin LoginLoad = new frmLogin();
            LoginLoad.Show();
            this.Close();
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //TODO: Update lblWelcome ---> lblWelcome.Text = "Welcome, "+username;

        }
    }
}
