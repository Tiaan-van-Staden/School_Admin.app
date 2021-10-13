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
using PRG282_Project.Data_Layer;

namespace PRG282_Project
{
    public partial class ucCreate : UserControl
    {
        public ucCreate()
        {
            InitializeComponent();
        }
        public string PicFileName = "";
        public string PicName = "";
        public string Gender = "";
        FileHandler handlerF = new FileHandler();
        DataHandler handlerD = new DataHandler();

        public void picStudent_Click(object sender, EventArgs e)
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
            //MessageBox.Show("Insert code to save image", "Remove this message when done with code");
        }

        public void rbnMale_CheckedChanged(object sender, EventArgs e)
        {   
            //if Male is checked, uncheck Female
            if (rbnMale.Checked == true)   
            {
                rbnFemale.Checked = false;
                Gender = "Male";
            }
        }

        public void rbnFemale_CheckedChanged(object sender, EventArgs e)
        {
            //if Female is checked, uncheck Male
            if (rbnFemale.Checked == true)
            {
                rbnMale.Checked = false;
                Gender = "Female";
            }
        }

        private void ucCreate_Load(object sender, EventArgs e)
        {
            cmbModules.DropDownStyle = ComboBoxStyle.DropDownList;
            //cmbSearch.SelectedItem = "Search for Student ID"; //text instead of item value
            cmbModules.SelectedIndex = 0;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //TODO: Check for empty fields
            handlerF.PicSave(PicFileName, PicName);
            handlerD.insertStudent(int.Parse(tbxID.Text), tbxFullname.Text, PicFileName, dtpDOB.Value.ToString(), Gender, tbxPhone.Text, tbxAddress.Text, cmbModules.SelectedIndex.ToString(), PicFileName);
            MessageBox.Show("Student created succesfully");

            frmMain MainLoad = new frmMain();
            MainLoad.Show();
            frmMain.blFormCloseProcess = false;
            ((Form)this.TopLevelControl).Close();
        }
    }
}
