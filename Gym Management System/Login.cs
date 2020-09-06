using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class Login : Form
    {
        public Login(){
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                this.Hide();
                MainMenu mm = new MainMenu();
                mm.Show();                     
            }
            else MessageBox.Show("Invalid credentials!", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);        
        }

        private void btnExit_Click(object sender, EventArgs e){
            Application.Exit();
        }  
    }
}
