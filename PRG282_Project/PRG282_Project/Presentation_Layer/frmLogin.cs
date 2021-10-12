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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (users.Contains(tbxUsername.Text) && pass.Contains(tbxPassw1.Text) && Array.IndexOf(users.ToArray(), tbxUsername.Text) == Array.IndexOf(pass.ToArray(), tbxPassw1.Text))
            {
                MessageBox.Show("Welcome " + tbxUsername.Text);
                frmMain MainLoad = new frmMain();
                this.Hide();
                MainLoad.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //FileStream mystream = new FileStream(@"C:\Users\tiaan\Desktop\ItIzz\Registerd.txt", FileMode.Open);
            //StreamWriter wrt = new StreamWriter(mystream);

            string p1 = tbxPassw1.Text;
            string p2 = tbxPassw2.Text;
            string un = tbxUsername.Text;

            if (p1 == p2)
            {
                //wrt.WriteLine(un + " " + p1);
                File.WriteAllText(@"C:\Users\tiaan\Desktop\ItIzz\Registerd.txt", un + " " + p1); //TODO: fix bug with writing
                MessageBox.Show("Acount succesfully created please log in to continue");
            }
            else
            {
                MessageBox.Show("Passwords do not match");
            }

            //wrt.Close();
            //mystream.Close();
            
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//Free program from memory/processing
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"C:\Users\tiaan\Desktop\ItIzz\Registerd.txt");
            string line = "";

            while ((line = sr.ReadLine()) != null)
            {
                string[] component = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                users.Add(component[0]);
                pass.Add(component[1]);
            }

            sr.Close();
        }
    }
}
