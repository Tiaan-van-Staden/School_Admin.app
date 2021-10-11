using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace PRG282_Project
{
    public partial class ucDatabase : UserControl
    {
        SqlConnection conn;
        public ucDatabase()
        {
            InitializeComponent();
        }

        private void ucDatabase_Load(object sender, EventArgs e)
        {
            cmbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            //cmbSearch.SelectedItem = "Search for Student ID"; //text instead of item value
            cmbSearch.SelectedIndex = 0;

            //connection to database starts
            conn = new SqlConnection("Server=.; Initial Catalog=StudentDB; Integrated Security=SSPI");
            try
            {
                conn.Open();
                //MessageBox.Show("Database Connection Successful");              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SqlCommand cmd = new SqlCommand("Select StudentID, StudentNames, StudentDOB, StudentGender, StudentPhone, StudentAddress, ModuleCodes From StudentInfo", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            BindingSource source = new BindingSource();
            source.DataSource = reader;
            dataGridView1.DataSource = source;
            conn.Close();
            //connection ends
        }

        public void bntSearch_Click(object sender, EventArgs e)
        {
            int search = int.Parse(txtSearchdata.Text); 
            int selectedIndex = cmbSearch.SelectedIndex;
            //MessageBox.Show("Index: " + selectedIndex.ToString());//Test selected item value
            if (selectedIndex == 0)
            {
                //TODO: search for Student ID
                //MessageBox.Show("Studnet");//Testing if this matches selected combobox
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select StudentID, StudentNames, StudentDOB, StudentGender, StudentPhone, StudentAddress, ModuleCodes From StudentInfo WHERE StudentID=" + search, conn);
                try
                {                                     
                    SqlDataReader reader = cmd.ExecuteReader();
                    BindingSource source = new BindingSource();
                    source.DataSource = reader;
                    dataGridView1.DataSource = source;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }

            }
            else
            {
                //TODO: search Module
                //MessageBox.Show("Module");//Testing if this matches selected combobox

                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * From ModuleInfo WHERE ModuleCodes=" + search, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = reader;
                dataGridView1.DataSource = source;
                conn.Close();
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
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM StudentInfo WHERE StudentID=" + search, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    MessageBox.Show("Deleted Student");
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Could Not Delete");
                }
                finally
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select StudentID, StudentNames, StudentDOB, StudentGender, StudentPhone, StudentAddress, ModuleCodes From StudentInfo", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    BindingSource source = new BindingSource();
                    source.DataSource = reader;
                    dataGridView1.DataSource = source;
                    conn.Close();
                }
            }
            else
            {
                //Deleting a module by searched ModuleCode
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM ModuleInfo WHERE ModuleCodes=" + search, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    MessageBox.Show("Deleted Module");
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Could Not Delete");
                }
                finally
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM ModuleInfo", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    BindingSource source = new BindingSource();
                    source.DataSource = reader;
                    dataGridView1.DataSource = source;
                    conn.Close();
                }
            }
        }
    }
}
