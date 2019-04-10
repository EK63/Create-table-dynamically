// DataRetrieve
// a simple program to learn how to access Sql and retrieve data and display in a label
//
// Data base    Database1.mdf
// Table        Student
// Fields       StudentId   int
//              Name        NVARCHAR (50)
//              Surname     NVARCHAR (50)
//              Colour      NCHAR (10)
//
// after retrieving the name, use the colour to create a table dynamically with 2 fields
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DataRetrieve
{
    public partial class StudentLookUp : Form
    {
        SqlConnection connection;
        string connectionString;
        SqlCommand command;
        SqlDataReader sdr;

        string tableName;

        public StudentLookUp()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DataRetrieve.Properties.Settings.Database1ConnectionString"].ConnectionString;
        }

        private void BtnStudentLookUp_Click(object sender, EventArgs e)
        {
            //using (connection = new SqlConnection(connectionString));
            connection = new SqlConnection(connectionString);
            string selectQuery = "SELECT * FROM Student WHERE StudentId=" + int.Parse(txtStudentId.Text);

            command = new SqlCommand(selectQuery, connection);
            connection.Open();
            sdr = command.ExecuteReader();      //Sql Data Reader

            //Looking-up student details
            if (sdr.Read())
            {
                lblStudentName.Text     = (sdr["Name"].ToString());
                lblStudentSurname.Text  = (sdr["Surname"].ToString());
                lblStudentColour.Text   = (sdr["Colour"].ToString());

                //Name the new table to the colour
                tableName = (sdr["Colour"].ToString());
            }

            else
            {
                lblStudentName.Text     = "";
                lblStudentSurname.Text  = "";
                lblStudentColour.Text   = "";

                MessageBox.Show("No data for this student");
            }

            //connection.Close();
        }

        private void BtnTableCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tableName))
            {
                MessageBox.Show("No data for this student");
                return;
            }
            
            //Create table dynamically
            DataTable dt = new DataTable();  
            dt.TableName = tableName;
            //Add column name
            dt.Columns.Add("AppleID", typeof(int));      // this should be the Colour value + Id
            dt.Columns.Add("AppleName", typeof(string)); // this should be the Colour value + Name

            lblTableName.Text = tableName;

            MessageBox.Show("Table created");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaren_Click(object sender, EventArgs e)
        {
            WindowsFormsApp1.frmKaren f2 = new WindowsFormsApp1.frmKaren();
            f2.Show();
        }
    }
}
