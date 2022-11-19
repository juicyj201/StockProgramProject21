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
    public partial class Registration : Form
    {
        private SQLiteConnection conn = new SQLiteConnection(@"Data Source=.\Login_Registration.db; Version = 3;");

        //regex
        private Regex regName = new Regex(@"^([a-zA-Z0-9 ])+$");
        private Regex regEmail = new Regex(@"^([a-zA-Z0-9_])+@([a-zA-Z])+\.([a-zA-Z])+$");
        private Regex regPass = new Regex(@"^(\w|\W|\S){0,8}$");

        public Registration()
        {
            InitializeComponent();
        }

        private bool CheckText() {
            if (regName.IsMatch(txtName.Text) && regEmail.IsMatch(txtEmail.Text) && regPass.IsMatch(txtPass.Text) && regPass.IsMatch(txtCPass.Text))
            {
                return true;
            }
            else {
                return false;
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            //We use dependency injection here to prevent from possible injection attacks
            conn.Open();
            SQLiteCommand icom = conn.CreateCommand();
            icom.CommandText = "INSERT INTO users VALUES(@name, @email, @pass)";
            icom.Parameters.AddWithValue("name", txtName.Text);
            icom.Parameters.AddWithValue("email", txtEmail.Text);
            icom.Parameters.AddWithValue("pass", txtPass.Text);
            
            int ok = icom.ExecuteNonQuery();

            if (ok > 0 && CheckText())
            {
                MessageBox.Show("Your account has been successfully created", "Registration Success");
                LoggedIn.loggedSet = true;
                this.Hide();
                FormControl.menu2.Show();
            }
            else if (txtName.Text.Length == 0 || txtEmail.Text.Length == 0 || txtPass.Text.Length == 0 || txtCPass.Text.Length == 0)
            {
                MessageBox.Show("Fields are empty", "Registration Failed");
                LoggedIn.loggedSet = false;
                ClearForm();
            }
            else
            {
                MessageBox.Show("Passwords do not match, Please Re-enter", "Registration Failed");
                LoggedIn.loggedSet = false;
                ClearForm();
            }

            conn.Close();
        }
        
        private void ClearForm() {
            txtName.Text = "";
            txtEmail.Text = "";
            txtPass.Text = "";
            txtCPass.Text = "";
            txtPass.Focus();
            
            //return to menu
            this.Hide();
            FormControl.menu2.Show();
        }

        
        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormControl.menu2.Show();
            ClearForm();
        }
    }
}
