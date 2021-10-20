using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace StockProgram
{
    public partial class Registration : Form
    {
        private SQLiteConnection conn = new SQLiteConnection(@"Data Source=.\Login_Registration.db; Version = 3;");
        //SQLiteCommand cmd = new SQLiteCommand();

        public Registration()
        {
            InitializeComponent();
        }

        private void CloseForm()
        {
        }

        private void ClearForm() {
            txtName.Text = "";
            txtEmail.Text = "";
            txtPass.Text = "";
            txtCPass.Text = "";
            txtPass.Focus();
        }

        //wrong one
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string register = "INSERT INTO users VALUES(" + txtName.Text + ", " + txtEmail.Text + ", " + txtPass + ")";
            SQLiteCommand cmd = new SQLiteCommand(register, conn);
            //cmd.ExecuteNonQuery();

            int ok = cmd.ExecuteNonQuery();

            if (ok > 0)
            {
                MessageBox.Show("Your account has been successfully created", "Registration Success");
            }
            else
            {
                MessageBox.Show("Passwords do not match, Please Re-enter", "Registration Failed");
                ClearForm();
            }

            conn.Close();

            if (txtName.Text.Length == 0 || txtEmail.Text.Length == 0 || txtPass.Text.Length == 0 || txtCPass.Text.Length == 0)
            {
                MessageBox.Show("Fields are empty", "Registration Failed");

                ClearForm();
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            ClearForm();

            this.Hide();
            FormControl.menu2.Show();
        }

        private void RegisterBtn_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            string register = "INSERT INTO users VALUES('" + txtName.Text + "', '" + txtEmail.Text + "', '" + txtPass.Text + "')";
            SQLiteCommand cmd = new SQLiteCommand(register, conn);
            //cmd.ExecuteNonQuery();

            int ok = cmd.ExecuteNonQuery();

            if (ok > 0)
            {
                MessageBox.Show("Your account has been successfully created", "Registration Success");
            }
            else
            {
                MessageBox.Show("Passwords do not match, Please Re-enter", "Registration Failed");
                ClearForm();
            }

            conn.Close();

            if (txtName.Text.Length == 0 || txtEmail.Text.Length == 0 || txtPass.Text.Length == 0 || txtCPass.Text.Length == 0)
            {
                MessageBox.Show("Fields are empty", "Registration Failed");

                ClearForm();
            }
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Close();
            this.Dispose();
            Application.Exit();
        }
    }
}
