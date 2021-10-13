using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG282_Project.Logic_Layer;

namespace PRG282_Project
{
    public partial class ucUpdateStdnt : UserControl
    {
        DataHandler handler = new DataHandler();

        public ucUpdateStdnt()
        {
            InitializeComponent();
        }
        public string PicFileName = "";
        public string PicName = "";
        FileHandler handlerF = new FileHandler();
        private void ucUpdateStdnt_Load(object sender, EventArgs e)
        {
            cmbModules.DropDownStyle = ComboBoxStyle.DropDownList;
            //cmbSearch.SelectedItem = "Search for Student ID"; //text instead of item value
            cmbModules.SelectedIndex = 0;
        }

        private void picStudent_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Open Image file";
            openFile.Filter = "Image Files(*.JPG;*.PNG)|*.JPG;*.PNG";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                PicFileName = openFile.FileName;
                picStudent.Image = Image.FromFile(PicFileName);
                if (openFile.FileName.ToString() != "")
                {
                    PicFileName = openFile.FileName.ToString();
                    PicName = PicFileName.ToString();
                    PicName = PicName.Substring(PicName.LastIndexOf("\\"));
                    PicName = PicName.Remove(0, 1);
                }
            }
            openFile.Dispose();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //TODO: Check for empty fields
            //TODO: Save to database
            handlerF.PicSave(PicFileName, PicName);
            tbxID.Text = "";
            tbxFullname.Text = "";
            rbnMale.Checked = false;
            rbnFemale.Checked = false;
            tbxPhone.Text = "";
            tbxAddress.Text = "";
            picStudent.Image = PRG282_Project.Properties.Resources.DefaultUser; //reset picStudent to default.

            handler.updateStudent(int.Parse(tbxID.Text), tbxFullname.Text, dtpDOB.Value, rbnMale.Checked, rbnFemale.Checked, tbxPhone.Text, tbxAddress.Text, cmbModules.SelectedIndex);
            MessageBox.Show("Student updated succesfully");
        }

    }
}
