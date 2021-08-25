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

        private SQLiteConnection conn = new SQLiteConnection(@"Data Source = C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Desktop\StockProgramProject21(develop branch)\bin\Debug\Login_Registration.db; Version = 3;");
        //SQLiteCommand cmd = new SQLiteCommand();

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            //if (txtPass.Text == txtCPass.Text)
            //{
            //string register = "INSERT INTO users VALUES('" + txtName.Text + "', '" + txtEmail.Text + "', '" + txtPass.Text + "')";
            if (txtName.TextLength != 0 && txtEmail.TextLength != 0 && txtPass.TextLength != 0 && txtCPass.TextLength != 0)
            {
                string register = "INSERT INTO users VALUES(@name, @email, @password)";
                try
                {
                    using (conn = new SQLiteConnection(conn))
                    using (SQLiteCommand cmd = new SQLiteCommand(register, conn))
                    {
                        conn.Open();

                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@password", txtPass.Text);
                        int ok = cmd.ExecuteNonQuery();
                        if (ok != 0)
                        {
                            MessageBox.Show("Your account has been successfully created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Passwords do not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtName.Text = "";
                            txtEmail.Text = "";
                            txtPass.Text = "";
                            txtCPass.Text = "";
                            txtPass.Focus();
                        }
                        conn.Close();

                        /**
                        cmd = new SQLiteCommand(register, conn);
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
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
                        **/
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //}
            }

            if (txtName.Text == "" && txtEmail.Text == "" && txtPass.Text == "" && txtCPass.Text == "")
            {
                MessageBox.Show("Fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
