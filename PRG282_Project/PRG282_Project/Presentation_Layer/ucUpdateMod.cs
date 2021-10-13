
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG282_Project.Data_Layer;

namespace PRG282_Project.Presentation_Layer
{
    public partial class ucUpdateMod : UserControl
    {
        DataHandler handler = new DataHandler();

        public ucUpdateMod()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //TODO: Check empty fields

            handler.updateModule(int.Parse(tbxCode.Text), tbxName.Text, tbxDesc.Text, tbxLink.Text);
            MessageBox.Show("Module updated succesfully");

            frmMain MainLoad = new frmMain();
            MainLoad.Show();
            frmMain.blFormCloseProcess = false;
            ((Form)this.TopLevelControl).Close();
        }
    }
}
