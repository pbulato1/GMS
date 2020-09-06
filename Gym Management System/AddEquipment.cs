using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class AddEquipment : Form
    {
        public AddEquipment()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String eqName = txtEqName.Text;
            String eqDescription = txtEqDescription.Text;
            String MUsed = txtMusclesUsed.Text;
            String DDate = dateTimePickerDelDate.Text;
            Int64 Cost = Int64.Parse(txtCost.Text);

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "data source = DESKTOP-OAPL2HR\\SQLEXPRESS; database = Gym; integrated security = true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "insert into NewEquipmentTable(EquipName,EqDescription,MUsed,DDate,Cost) values ('" + eqName + "','" + eqDescription + "','" + MUsed + "','" + DDate + "'," + Cost + ")";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data Saved");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEqName.Clear();
            txtEqDescription.Clear();
            txtMusclesUsed.Clear();
            txtCost.Clear();
            dateTimePickerDelDate.ResetText();
            dateTimePickerDelDate.Value = DateTime.Now;

        }

        private void btnViewEq_Click(object sender, EventArgs e)
        {
            ViewEquipment ve = new ViewEquipment();
            ve.Show();
        }

    }
}
