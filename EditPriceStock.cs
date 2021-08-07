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
using StockProgram;

namespace StockProgram
{
    public partial class EditPriceStock : Form
    {
        public EditPriceStock()
        {
            InitializeComponent();

            MainDatabase maindb = new MainDatabase();

            maindb.OpenConnection();
            maindb.ShowStock();
            maindb.CloseConnection();
        }

    }
}
