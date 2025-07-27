using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_3
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ServerName.Text) || string.IsNullOrEmpty(DatabaseName.Text) || 
                string.IsNullOrEmpty(UserName.Text) || string.IsNullOrEmpty(Password.Text))
            {
                MessageBox.Show("Please provide all necessary login information.", "Login Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string server = ServerName.Text;
                string database = DatabaseName.Text;
                string user = UserName.Text;
                string pass = Password.Text;

                Data data = new Data(server, database, user, pass);
                if (data.TestConnection())
                {
                    Form1 form1 = new Form1(server, database, user, pass);
                    this.Hide();
                    form1.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Data Connection was unsuccessful. Please make sure your server, database name, user ID, " +
                        "and password are all correct.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
