using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockProgram.UserControls
{
    public partial class StockTrackingView : UserControl
    {
        private SQLiteConnection conn = new SQLiteConnection(@"data source=.\StockTracking.db");
        private string dateUse;
        private string datePurch;
        private string id;

        private string result;

        public StockTrackingView()
        {
            InitializeComponent();

            OpenConn();

            Select();


            CloseConn();
        }

        private void OpenConn() {
            conn.Open();
        }

        private void CloseConn() {
            conn.Close();
        }

        private void Select() {
            string sqlquery = "select (DateOfUse) from Tracking";

            Show(sqlquery);
        }

        private string Show(string sqlquery) {
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = sqlquery;
            result = cmd.ExecuteScalar().ToString();

            return result;


        }


    }
}
