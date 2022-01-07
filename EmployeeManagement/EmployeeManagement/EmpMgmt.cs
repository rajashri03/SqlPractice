using System.Data.SqlClient;

namespace EmployeeManagement
{
    public partial class EmpMgmt : Form
    {
        public EmpMgmt()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Insert data into database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AD-PC\SQLEXPRESS; Initial Catalog =EmplyoeeDetails; Integrated Security = True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into EmployeeInfo(EmployeeName,EmpAge,Designation)values('"+ txtEmpName.Text + "','" + int.Parse(txtAge.Text) + "','" + txtdesignation.Text + "')",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted");
            con.Close();
        }
    }
}