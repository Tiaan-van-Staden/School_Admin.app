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
    public partial class ucCreate : UserControl
    {
        public ucCreate()
        {
            InitializeComponent();
        }

        private void picStudent_Click(object sender, EventArgs e)
        {
            //TODO: add code to save pic
        }

        private void rbnMale_CheckedChanged(object sender, EventArgs e)
        {   
            //if Male is checked, uncheck Female
            if (rbnMale.Checked == true)   
            {
                rbnFemale.Checked = false;
            }
        }

        private void rbnFemale_CheckedChanged(object sender, EventArgs e)
        {
            //if Female is checked, uncheck Male
            if (rbnFemale.Checked == true)
            {
                rbnMale.Checked = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
