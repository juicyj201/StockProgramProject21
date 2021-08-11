using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockProgram
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Settings.ActiveForm.BackColor = Color.White;
            Settings.ActiveForm.ForeColor = Color.Black;
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Settings.ActiveForm.BackColor = Color.White;
            Settings.ActiveForm.ForeColor = Color.Black;
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu menuCall = new StartMenu();
            menuCall.Show();
        }
    }
}
