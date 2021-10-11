using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using PRG282_Project.

namespace PRG282_Project
{
    public partial class frmMain : Form
    {
        

        public frmMain()
        {
            InitializeComponent();
           
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            //TODO: Update lblWelcome ---> lblWelcome.Text = "Welcome, "+username;
        }

        private void btnViewDB_Click(object sender, EventArgs e)
        {
            btnViewDB.BackColor = SystemColors.ActiveCaption;
            btnViewStudntCrt.BackColor = Color.FromArgb(0, 111, 207);
            btnViewModCrt.BackColor = Color.FromArgb(0, 111, 207);
            btnViewStudntUpdt.BackColor = Color.FromArgb(0, 111, 207);
            btnViewModUpdt.BackColor = Color.FromArgb(0, 111, 207);
            ucDatabase1.Visible = true;
            ucCreateStudent.Visible = false;
            ucUpdateStudent.Visible = false;
            ucCreateMod1.Visible = false;
            ucUpdateMod1.Visible = false;
        }

        private void btnViewStudntCrt_Click(object sender, EventArgs e)
        {
            btnViewStudntCrt.BackColor = SystemColors.Control;
            btnViewDB.BackColor = Color.FromArgb(0, 111, 207);
            btnViewModCrt.BackColor = Color.FromArgb(0, 111, 207);
            btnViewStudntUpdt.BackColor = Color.FromArgb(0, 111, 207);
            btnViewModUpdt.BackColor = Color.FromArgb(0, 111, 207);
            ucCreateStudent.Visible = true;
            ucDatabase1.Visible = false;
            ucUpdateStudent.Visible = false;
            ucCreateMod1.Visible = false;
            ucUpdateMod1.Visible = false;
        }

        private void btnViewStudntUpdt_Click(object sender, EventArgs e)
        {
            btnViewStudntUpdt.BackColor = SystemColors.ScrollBar;
            btnViewDB.BackColor = Color.FromArgb(0, 111, 207);
            btnViewStudntCrt.BackColor = Color.FromArgb(0, 111, 207);
            btnViewModCrt.BackColor = Color.FromArgb(0, 111, 207);
            btnViewModUpdt.BackColor = Color.FromArgb(0, 111, 207);
            ucUpdateStudent.Visible = true;
            ucCreateStudent.Visible = true;
            ucDatabase1.Visible = false;
            ucCreateMod1.Visible = false;
            ucUpdateMod1.Visible = false;
        }

        private void btnViewModCrt_Click(object sender, EventArgs e)
        {
            btnViewModCrt.BackColor = Color.CornflowerBlue;
            btnViewDB.BackColor = Color.FromArgb(0, 111, 207);
            btnViewStudntCrt.BackColor = Color.FromArgb(0, 111, 207);
            btnViewStudntUpdt.BackColor = Color.FromArgb(0, 111, 207);
            btnViewModUpdt.BackColor = Color.FromArgb(0, 111, 207);
            ucCreateMod1.Visible = true;
            ucDatabase1.Visible = false;
            ucCreateStudent.Visible = false;
            ucUpdateStudent.Visible = false;
            ucUpdateMod1.Visible = false;
        }

        private void btnViewModUpdt_Click(object sender, EventArgs e)
        {
            btnViewModUpdt.BackColor = SystemColors.ActiveCaption;
            btnViewDB.BackColor = Color.FromArgb(0, 111, 207);
            btnViewStudntCrt.BackColor = Color.FromArgb(0, 111, 207);
            btnViewModCrt.BackColor = Color.FromArgb(0, 111, 207);
            btnViewStudntUpdt.BackColor = Color.FromArgb(0, 111, 207);
            ucUpdateMod1.Visible = true;
            ucDatabase1.Visible = false;
            ucCreateStudent.Visible = false;
            ucUpdateStudent.Visible = false;
            ucCreateMod1.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmLogin LoginLoad = new frmLogin();
            LoginLoad.Show();
            this.Close();
        }


    }
}
