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
        /// <summary>
        /// This is an experimental form, that allows the user to change the colour scheme of the program.
        /// There are only two colour themes currently: White and Black.
        /// (In future, I would like to add more settings and more colour themes to the program)
        /// 
        /// Currently, I will not implement the form as it still needs to be worked on and as I said, it is still experimental.
        /// After creating a release for the program, I will implement the settings section as a new feature.
        /// </summary>

        private StartMenu menu;


        public Settings()
        {
            InitializeComponent();

            blackBtn.Checked = true;
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormControl.menu2.Show();
        }

        private void blackBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (blackBtn.Checked == true && whiteBtn.Checked == false)
            {
                //settings
                Settings.ActiveForm.BackColor = Color.FromArgb(11, 23, 42);
                Settings.ActiveForm.ForeColor = Color.FromArgb(188, 65, 35);
                settingsLbl.ForeColor = Color.White;
                colourGb.ForeColor = Color.White;
                blackBtn.ForeColor = Color.White;
                whiteBtn.ForeColor = Color.White;
                returnBtn.BackColor = Color.FromArgb(188, 65, 35);
                returnBtn.FlatStyle = FlatStyle.Flat;

                //menu
                FormControl.menu2.BackColor = Color.FromArgb(11, 23, 42);
                FormControl.menu2.getPanel2.BackColor = Color.FromArgb(11, 23, 42);
                FormControl.menu2.getPanel3.BackColor = Color.FromArgb(188, 65, 35);
                FormControl.menu2.getSettingsBtn.BackColor = Color.FromArgb(11, 23, 42);
                FormControl.menu2.getPanel1.BackColor = Color.FromArgb(188, 65, 35);
                FormControl.menu2.getMenuLbl.ForeColor = Color.White;
                FormControl.menu2.getMaindatabaseBtn.BackColor = Color.FromArgb(11, 23, 42);
                FormControl.menu2.getExitBtn.BackColor = Color.FromArgb(11, 23, 42);
                FormControl.menu2.getAboutUsBtn.BackColor = Color.FromArgb(11, 23, 42);
                FormControl.menu2.getRegisterBtn.BackColor = Color.FromArgb(11, 23, 42);
                FormControl.menu2.getLoginBtn.BackColor = Color.FromArgb(11, 23, 42);
            }
        }
        private void whiteBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (whiteBtn.Checked == true && blackBtn.Checked == false)
            {
                //settings
                Settings.ActiveForm.BackColor = Color.Black;
                Settings.ActiveForm.ForeColor = Color.White;
                settingsLbl.ForeColor = Color.White;
                colourGb.ForeColor = Color.White;
                blackBtn.ForeColor = Color.White;
                whiteBtn.ForeColor = Color.White;
                returnBtn.ForeColor = Color.White;
                returnBtn.BackColor = Color.Black;
                returnBtn.FlatStyle = FlatStyle.Flat;

                //menu
                FormControl.menu2.BackColor = Color.Black;
                FormControl.menu2.getPanel2.BackColor = Color.Black;
                FormControl.menu2.getPanel3.BackColor = Color.Black;
                FormControl.menu2.getSettingsBtn.BackColor = Color.Black;
                FormControl.menu2.getPanel1.BackColor = Color.Black;
                FormControl.menu2.getMenuLbl.ForeColor = Color.White;
                FormControl.menu2.getMaindatabaseBtn.BackColor = Color.Black;
                FormControl.menu2.getExitBtn.BackColor = Color.Black;
                FormControl.menu2.getAboutUsBtn.BackColor = Color.Black;
                FormControl.menu2.getRegisterBtn.BackColor = Color.Black;
                FormControl.menu2.getLoginBtn.BackColor = Color.Black;
            }
        }
    }
}
