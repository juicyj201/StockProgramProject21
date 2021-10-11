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
    public partial class Login : Form {

        public Login()
        {
            InitializeComponent();
        }

        private void CloseForm() {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" && textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Empty Fields", "Error");
            }
            else
            {
                // This works by checking if the value is actually inside the database.
                // If it returns a password, then that means the password exists and the user will be logged in.
                string query = "SELECT * FROM users WHERE Password = '"+textBox2.Text+"' AND Email='"+textBox1.Text+"'";
                SQLiteConnection conn = new SQLiteConnection(@"Data Source=.\Login_Registration.db; Version = 3;");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.ExecuteNonQuery();
                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    logg.loggedSet = true;
                    MessageBox.Show("You are Logged in", "Login successful");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox1.Focus();
                    CloseForm();
                }
                else
                {
                    MessageBox.Show("Login Failed", "An error occurs");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox1.Focus();
                }
                conn.Close();
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Close();
            this.Dispose();
            Application.Exit();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormControl.menu2.Show();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }
    }
}
