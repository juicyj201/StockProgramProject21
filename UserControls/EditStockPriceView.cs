using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace StockProgram.UserControls
{
    public partial class EditStockPriceView : UserControl
    {
        public static SqlConnection myConnection = new SqlConnection(@"Data Source=CSLID;Initial Catalog=ProductCombobox;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public EditStockPriceView()
        {
            InitializeComponent();
        }
        private void EditStockPriceView_Load(object sender, EventArgs e)
        {
            myConnection.Open();
            SqlCommand myCommand = myConnection.CreateCommand();
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = "Select ProdPrice from [pdr].tProducts ";
            myCommand.ExecuteNonQuery();
            DataTable myDataTable = new DataTable();
            SqlDataAdapter myDataAdapter = new SqlDataAdapter();
            myDataAdapter.Fill(myDataTable);
            foreach (DataRow dataRow in myDataTable.Rows)
            {
                cmblistId.Items.Add(dataRow["Id"].ToString());
            }


            myConnection.Close();
        }

        private void cmblistId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
