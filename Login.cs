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
using System.Text.RegularExpressions;

namespace StockProgram
{
    public partial class Login : Form {

        private SQLiteConnection conn = new SQLiteConnection(@"Data Source=.\Login_Registration.db; Version = 3;");
        //regex
        private Regex regEmail = new Regex(@"^([a-zA-Z0-9_])+@([a-zA-Z])+\.([a-zA-Z])+$");
        private Regex regPass = new Regex(@"^(\w|\W|\S){0,8}$");

        public Login()
        {
            InitializeComponent();
        }

        private bool CheckText()
        {
            if (regEmail.IsMatch(textBox1.Text) && regPass.IsMatch(textBox2.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "")
            {
                // This works by checking if the value is actually inside the database.
                // If it returns a password, then that means the password exists and the user will be logged in.
                conn.Open();
                SQLiteCommand icom = conn.CreateCommand();
                icom.CommandText = "SELECT * FROM users WHERE Password = @pass AND Email = @email";
                icom.Parameters.AddWithValue("pass", textBox2.Text);
                icom.Parameters.AddWithValue("email", textBox1.Text);
                icom.ExecuteNonQuery();

                SQLiteDataReader reader = icom.ExecuteReader();

                if (reader.Read() && CheckText())
                {
                    LoggedIn.loggedSet = true;
                    MessageBox.Show("You are Logged in", "Login successful");
                    ClearForm();
                    this.Hide();
                    FormControl.menu2.Show();
                }
                else
                {
                    LoggedIn.loggedSet = false;
                    MessageBox.Show("Login Failed", "An error has occured");
                    ClearForm();
                }
                conn.Close();
            }
            else {
                MessageBox.Show("Empty Fields", "Error");
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormControl.menu2.Show();
            ClearForm();
        }

        private void ClearForm() {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }
    }
}
