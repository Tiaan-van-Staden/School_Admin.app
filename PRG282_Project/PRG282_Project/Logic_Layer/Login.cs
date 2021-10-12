using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project.Logic_Layer
{
    class Login
    {
        string user = "Tiaan";
        string password = "12345678"; //TODO: create list for users

        public string inputuser, inputpassword;
        public Boolean Verify()
        {
            Boolean exept = false;
            while (exept == false)
            {
                if (inputuser == user && inputpassword == password)
                {
                    exept = true;
                    MessageBox.Show("Welcome " + user);

                    break;
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");

                    break;
                }
            }

            return exept;
        }
    }
}
