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
    public partial class ucDatabase : UserControl
    {
        public ucDatabase()
        {
            InitializeComponent();
        }

        private void ucDatabase_Load(object sender, EventArgs e)
        {
            cmbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            //cmbSearch.SelectedItem = "Search for Student ID"; //text instead of item value
            cmbSearch.SelectedIndex = 0;
        }

        public void bntSearch_Click(object sender, EventArgs e)
        {
            int selectedIndex = cmbSearch.SelectedIndex;
            //MessageBox.Show("Index: " + selectedIndex.ToString());//Test selected item value
            if (selectedIndex == 0)
            {
                //TODO: search for Student ID
                //MessageBox.Show("Studnet");//Testing if this matches selected combobox
            }
            else
            {
                //TODO: search Module
                //MessageBox.Show("Module");//Testing if this matches selected combobox
            }
        }
    }
}
