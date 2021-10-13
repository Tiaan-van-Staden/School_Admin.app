using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PRG282_Project.Data_Layer;

namespace PRG282_Project
{
    public partial class ucDatabase : UserControl
    {
        SqlConnection conn;
        public ucDatabase()
        {
            InitializeComponent();
        }
        DataHandler handler = new DataHandler();
        private void ucDatabase_Load(object sender, EventArgs e)
        {
            cmbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            //cmbSearch.SelectedItem = "Search for Student ID"; //text instead of item value
            cmbSearch.SelectedIndex = 0;
            dgvDatabase.DataSource = handler.showAllStudents();
           
        }
        public void bntSearch_Click(object sender, EventArgs e)
        {
            //TODO: add check so that input is only numbers
            int search = int.Parse(txtSearchdata.Text); 
            int selectedIndex = cmbSearch.SelectedIndex;

            if (selectedIndex == 0)
            {
                dgvDatabase.DataSource = handler.searchStudents(int.Parse(txtSearchdata.Text));
                //extract data from datagridview dgbDatabase for student details in student summary at richtextbox
            }
            else
            {
                dgvDatabase.DataSource = handler.searchModules(int.Parse(txtSearchdata.Text));
                picStudent.Image = PRG282_Project.Properties.Resources.DefaultUser; //reset picStudent to default.
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string search = txtSearchdata.Text;
            int selectedIndex = cmbSearch.SelectedIndex;
            if (selectedIndex == 0)
            {
                //Deleting a student by searched StudentID
                try
                {
                    handler.deleteStudent(int.Parse(txtSearchdata.Text));
                }
                catch
                {
                    MessageBox.Show("Could Not Delete");
                }
                finally
                {
                    dgvDatabase.DataSource = handler.showAllStudents();
                }
            }
            else
            {
                //Deleting a module by searched ModuleCode
                try
                {
                    handler.deleteModule(int.Parse(txtSearchdata.Text));
                }
                catch
                {
                    MessageBox.Show("Could Not Delete");
                }
                finally
                {
                    dgvDatabase.DataSource = handler.showAllModules();
                }
            }
        }

        private void dgvDatabase_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            picStudent.Image = PRG282_Project.Properties.Resources.DefaultUser; //reset picStudent to default.
        }
    }
}
