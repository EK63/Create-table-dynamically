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

namespace WindowsFormsApp1
{
    public partial class frmKaren : Form
    {
        private string ConnectionString;

        public frmKaren()
        {
            InitializeComponent();
        }
        public DataTable CreateDataTable(string pTableName)
        {
            var dt = new DataTable() { TableName = pTableName };

            dt.Columns.AddRange(new[]
            {
                new DataColumn() {ColumnName = "AppleID", DataType = typeof(int)},
                new DataColumn() {ColumnName = "AppleName", DataType = typeof(string)}
            });

            return dt;
        }
        private DataTable ReadData()
        {
            var dt = new DataTable();
            var ConnectionString = "TODO";
            using (var cn = new SqlConnection(ConnectionString))
            {
                using (var cmd = new SqlCommand { Connection = cn })
                {
                    cmd.CommandText = "SELECT Name,SurName,Colour FROM Student WHERE StudentId= @StudentId";
                    cmd.Parameters.AddWithValue("@StudentId", txtStudentId.Text);
                    cn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        dt = CreateDataTable(reader.GetString(2));
                    }
                }
            }

            return dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = ReadData();
        }
    }
}
