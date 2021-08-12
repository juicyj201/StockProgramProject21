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
    public partial class SplashScreen : Form
    {
        /// <summary>
        /// This is the Splash screen.
        /// It loads for a couple of seconds, and once it is finished loading it closes and the Start menu opens.
        /// </summary>

        public SplashScreen()
        {
            InitializeComponent();
        }

        private void LoadTimer_Tick(object sender, EventArgs e)
        {
            loadBar.Increment(20);
            if (loadBar.Value == 100)
            {
                this.Close();
            }
            
        }
    }
}
