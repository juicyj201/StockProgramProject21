//SERGE
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
    public partial class EditPriceStock : Form
    {
        public EditPriceStock()
        {
            InitializeComponent();

            openConnection();
            showStock();
            closeConnection();
        }

        private void showStock() {
            getTable();
        }
    }
}