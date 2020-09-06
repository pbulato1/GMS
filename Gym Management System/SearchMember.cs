using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class SearchMember : Form
    {
        public SearchMember()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "data source = DESKTOP-OAPL2HR\\SQLEXPRESS; database = Gym; integrated security = true";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "select * from NewMemberTable where MID = " + txtSearch.Text + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
            }
            else
            {
                MessageBox.Show("Field cannot be empty","Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
