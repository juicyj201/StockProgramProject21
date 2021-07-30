using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;

// a test form that will allow us to see how the main database works and if it works

namespace StockProgram
{
    public partial class TestForm : Form
    {
        private SQLiteConnection conn = new SQLiteConnection(@"Data source=.\TestDatabase.db");

        private List<Product> product { get; set; }

        public TestForm()
        {
            //open
            OpenConnection();

            //giving the product list items to show
            product = GetProduct();
            InitializeComponent();

            //close
            CloseConnection();
        }

        private void OpenConnection() {
            conn.Open();
        }

        private void CloseConnection() {
            conn.Close();
        }

        private void AddData() { 
            
        }

        private List<Product> GetProduct() {
            var list = new List<Product>();

            list.Add(new Product()
            {
                ProdId = 1,
                ProdName = "Flour",
                ProdPrice = 25,
                ProdQuantity = 1
            });
            list.Add(new Product()
            {
                ProdId = 2,
                ProdName = "Sugar",
                ProdPrice = 30,
                ProdQuantity = 3
            });
            list.Add(new Product()
            {
                ProdId = 3,
                ProdName = "Beans",
                ProdPrice = 22,
                ProdQuantity = 5
            });


            return list;
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu startMenuCall = new StartMenu();
            startMenuCall.Show();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = this.product;
        }
    }
}
