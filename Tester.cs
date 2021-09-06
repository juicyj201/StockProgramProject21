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

namespace StockProgram
{
    public partial class Tester : Form
    {
        private SQLiteConnection con = new SQLiteConnection(@"Data Source =.\StockDatabase.db");
        private Product productObj = new Product();

        public Tester()
        {
            InitializeComponent();
        }

        private void SQLstuff()
        {
            try {
                //open connection
                con.Open();

                //create sql query
                string query = "SELECT * from Products WHERE ProdName = @ProdName";

                //create command and reader object
                SQLiteCommand comm = new SQLiteCommand(query, con);
                comm.Parameters.AddWithValue("@ProdName", NameTb.Text);
                SQLiteDataReader reader = comm.ExecuteReader();
                
                //set the values inside the returned row, to the product object
                while (reader.Read() == true) {
                    productObj.setId = reader.GetInt32(0);
                    productObj.setName = reader.GetString(1);
                    productObj.setPrice = reader.GetInt32(2);
                    productObj.setQuantity = reader.GetInt32(3);
                }

                //do error checking - make sure that there are values. If there are no changes to the product object, display a message
                if (productObj.getId != 0 || productObj.getName != null || productObj.getPrice != 0 || productObj.getQuantity != 0) {
                    MessageBox.Show("Product object has been changed");
                }
                
                //close the reader
                reader.Close();
                
                //close the connection
                con.Close();
            }
            catch (SQLiteException sqle) {
                MessageBox.Show(sqle.Message);
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text.Length > 0) {
                SQLstuff();
            }
        }

        private void Tester_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }

    public class Product {
        private int Id;
        private string Name;
        private int Price;
        private int Quantity;
        private string DOU;
        private string DOP;

        public int getId { get {return Id; } }
        public int setId { set { this.Id = Id; } }
        public string getName { get { return Name; } }
        public string setName { set { this.Name = Name; } }
        public int getPrice { get { return Price; } }
        public int setPrice { set { this.Price = Price; } }
        public int getQuantity { get { return Quantity; } }
        public int setQuantity { set { this.Quantity = Quantity; } }
        public string getDOU { get { return DOU; } }
        public string setDOU { set { this.DOU = DOU; } }
        public string getDOP { get { return DOP; } }
        public string setDOP { set { this.DOP = DOP; } }

        public Product() { 
            //ctor
        }
    }
}
