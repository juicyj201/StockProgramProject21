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
    public partial class UpdateDatabase : System.Windows.Forms.Form
    {
        public UpdateDatabase()
        {
            InitializeComponent();

            MainDatabase maindb = new MainDatabase();

            maindb.OpenConnection();
            maindb.ShowStock();
            maindb.CloseConnection();
        }
    }
}
