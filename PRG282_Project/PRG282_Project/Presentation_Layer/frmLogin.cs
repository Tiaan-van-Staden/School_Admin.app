using PRG282_Project.Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        List<string> users = new List<string>();
        List<string> pass = new List<string>();

        FileHandler handler = new FileHandler();
        

        
        private void btnShowRegister_Click(object sender, EventArgs e)
        {
            pnlRegister.Visible = true;
            btnRegister.Visible = true;
            btnBack.Visible = true;
            btnLogin.Visible = false;
            btnShowRegister.Visible = false;
            this.Height = 630;
            tbxUsername.Text = "";
            tbxPassw1.Text = "";
            tbxPassw2.Text = "";
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlRegister.Visible = false;
            btnRegister.Visible = false;
            btnBack.Visible = false;
            btnLogin.Visible = true;
            btnShowRegister.Visible = true;
            this.Height = 550;
            tbxUsername.Text = "";
            tbxPassw1.Text = "";
            tbxPassw2.Text = "";
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            string uname = tbxUsername.Text;
            string p1 = tbxPassw1.Text;

            handler.Login(uname, p1);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string p1 = tbxPassw1.Text;
            string p2 = tbxPassw2.Text;
            string un = tbxUsername.Text;

            handler.Register(un, p1, p2);
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//Free program from memory/processing
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
