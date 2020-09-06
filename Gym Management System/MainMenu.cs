using System;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class MainMenu : Form
    {
        public MainMenu()        {
            InitializeComponent();
        }

        bool horizontal = true;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (horizontal)
            {
                menuStrip1.Dock = DockStyle.Left;
                toolStripMenuItem1.Text = "Switch to Horizontal View";
                horizontal = false;

            }
            else
            {
                menuStrip1.Dock = DockStyle.Top;
                toolStripMenuItem1.Text = " Switch to Vertical View";
                horizontal = true;
            }
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMember nm = new AddMember();
            nm.Show();
        }

        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStaff ns = new AddStaff();
            ns.Show();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEquipment eq = new AddEquipment();
            eq.Show();
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchMember sm = new SearchMember();
            sm.Show();
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteMember dm = new DeleteMember();
            dm.Show();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Dialog Title", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }
    }
}
