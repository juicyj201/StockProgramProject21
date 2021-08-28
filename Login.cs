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
            this.Hide();
            FormControl.menu2.Show();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" && textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Empty Fields", "Error");
            }
            else
            {
                //string query = "SELECT * FROM users WHERE email = @textBox1 AND password = @textBox2";
                string query = "SELECT * FROM users WHERE Password = @Password";
                SQLiteConnection conn = new SQLiteConnection(@"Data Source = Login_Registration.db; Version = 3;");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                int alright = 0;
                cmd.ExecuteNonQuery();
                alright = cmd.ExecuteNonQuery();

                if (alright > 0)
                {
                    MessageBox.Show("You are Logged in", "Login successful");
                    CloseForm();
                }
                else
                {
                    MessageBox.Show("Login Failed", "An error occurs");
                }
                conn.Close();
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm();
        }
    }   
}
