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
