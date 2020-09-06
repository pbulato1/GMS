using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class AddStaff : Form
    {
        public AddStaff(){
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtMobile.Clear();
            txtEmail.Clear();
            txtState.Clear();
            dateTimePickerJoinDate.ResetText();
            dateTimePickerDOB.ResetText();
            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJoinDate.Value = DateTime.Now;
            txtState.Clear();
            txtCity.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String fName = txtFirstName.Text;
            String lName = txtLastName.Text;
            String gender = " ";
            bool isChecked = radioButton1.Checked;
            if (isChecked) gender = radioButton1.Text;
            else gender = radioButton2.Text;
            String dob = dateTimePickerDOB.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String email = txtEmail.Text;
            String joinDate = dateTimePickerJoinDate.Text;
            String state = txtState.Text;
            String city = txtCity.Text;
            
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "data source = DESKTOP-OAPL2HR\\SQLEXPRESS; database = Gym; integrated security = true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "insert into NewStaffTable(Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,Statee,City) values ('" + fName + "','" + lName + "','" + gender + "','" + dob + "'," + mobile + ",'" + email + "','" + joinDate + "' , '" + state + "','" + city + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data Saved");
        }

    }
}
