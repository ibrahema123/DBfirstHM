using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week_9_db
{
    public partial class frmIndex : Form
    {
        string connectionString = "Provider=SQLOLEDB;Data Source=DESKTOP-OTT897E\\SQLEXPRESS;Initial Catalog=week9;Integrated Security=True;Integrated Security=SSPI";
        OleDbConnection con;
        public frmIndex()
        {
            InitializeComponent();
            con = new OleDbConnection(connectionString);
        }

        private void frmIndex_Load(object sender, EventArgs e)
        {
            displayDBContant();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {

            string insertCommand = $"Insert Into Students([studentNo], [studentFirst], [studentLast]) values('{txtStudentID.Text}', '{txtStudentFirst.Text}', '{txtStudentLast.Text}')";

            OleDbCommand command = new OleDbCommand(insertCommand, con);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            displayDBContant();
            clearData();
        }

        private void displayDBContant()
        {
            OleDbCommand command = new OleDbCommand("Select * from Students", con);
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvStudents.DataSource = dt;
        }

        private void clearData()
        {
            txtStudentID.Clear();
            txtStudentFirst.Clear();
            txtStudentLast.Clear();
            txtStudentID.Focus();
        }
    }
}
