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
                string register = "INSERT INTO users VALUES('" + txtName.Text + "', '" + txtEmail.Text + "', '" + txtPass.Text + "')";
                cmd = new SQLiteCommand(register, conn);
                cmd.ExecuteNonQuery();
                conn.Close();


                MessageBox.Show("Your account has been successfully created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Passwords do not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Text = "";
                txtCPass.Text = "";
                txtPass.Focus();
            }
        }
    }
}
