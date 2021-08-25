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
        public Registration()
        {
            InitializeComponent();
        }

        private void CloseForm()
        {
            this.Hide();
            FormControl.menu2.Show();
        }

        SQLiteConnection conn = new SQLiteConnection("Data Source = Login.db; Version = 3;");
        SQLiteCommand cmd = new SQLiteCommand();

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" && txtEmail.Text == "" && txtPass.Text == "" && txtCPass.Text == "")
            {
                MessageBox.Show("Fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPass.Text == txtCPass.Text)
            {
                conn.Open();
                //string register = "INSERT INTO users VALUES('" + txtName.Text + "', '" + txtEmail.Text + "', '" + txtPass.Text + "')";
                string register = "insert into users values(@id, @email, @password)";
                cmd = new SQLiteCommand(register, conn);
                cmd.Parameters.AddWithValue("@id", userIncrement());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@password", txtPass.Text);
                int yer = 0;
                cmd.ExecuteNonQuery();
                yer = cmd.ExecuteNonQuery();

                if (yer != 0) { 
                    MessageBox.Show("Your account has been successfully created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CloseForm();
                }

                conn.Close();

                
            }
            else 
            {
                MessageBox.Show("Passwords do not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Text = "";
                txtCPass.Text = "";
                txtPass.Focus();
            }
        }

        private int userIncrement() {
            int userNum = 1;
            bool userNumActive = true;
            if (userNumActive) {
                userNum += 1;
            }

            return userNum;
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseForm();
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm();
        }
    }
}
