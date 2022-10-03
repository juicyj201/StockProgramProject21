using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using StockProgram.UserControls;
using System.Collections;

namespace StockProgram
{
    public partial class MainDatabase : Form
    {
        /// <summary>
        ///     <para>
        ///         These are the global variables for the MainDatabase class
        ///     </para>
        /// </summary>
        private SQLiteConnection conn = new SQLiteConnection(@"data source=.\StockDatabase.db");
        private DataTable table = new DataTable();

        private EditStockPriceView edit;
        private StockTrackingView stocktrack;
        private UpdateDatabaseView updateprod;
        private UpdateCustListView updatecust;

        private ArrayList tablelist = new ArrayList();

        public MainDatabase()
        {
            ///init method call 
            InitializeComponent();

            OpenConnection();
            ShowTables();
            AddControls();
            CloseConnection();
        }

        /// <summary>
        ///     <para>
        ///         These are the methods used for opening and closing the connection to the sqlite database.
        ///     </para>
        /// </summary>
        public void OpenConnection() {
            conn.Open();
        }

        public void CloseConnection() {
            conn.Close();
        }

        /// <summary>
        ///     <para>
        ///         This method is used to retrieve Product table data directly from the sqlite database
        ///     </para>
        /// </summary>
        public void ShowStock() {

            //the command object used to retrieve all the rows in the database
            string selectStock = "select * from Products";
            SQLiteCommand selectComm = new SQLiteCommand(selectStock, conn);

            //the data adapter used to fill the table
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectComm);
            adapter.Fill(table);

            //putting the datagrid in the table
            stockView.DataSource = table;
        }

        /// <summary>
        ///     <para>
        ///         This method is used to retrieve CustomerList table data directly from the sqlite database
        ///     </para>
        /// </summary>
        public void ShowCustList() {

            //the command object used to retrieve all the rows in the database
            string selectCustomer = "select * from CustomerList";
            SQLiteCommand selectComm = new SQLiteCommand(selectCustomer, conn);

            //the data adapter used to fill the table
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectComm);
            adapter.Fill(table);

            //putting the datagrid in the table
            stockView.DataSource = table;
        }

        /// <summary>
        ///     <para>
        ///         This Method is used to show either CustomerList or Product tables respectively        
        ///     </para>
        /// </summary>
        private void ShowTables() {
            //retrieving all the tables from the database
            string productTable = "Products";
            string customerListTable = "CustomerList";

            tablelist.Add(productTable);
            tablelist.Add(customerListTable);

            listBox1.Items.Add(tablelist[0]);
            listBox1.Items.Add(tablelist[1]);
        }

        /// <summary>
        ///     <para>
        ///         This is a method used to add the user controls, to the tab control in the MainDatabase form
        ///     </para>
        /// </summary>
        private void AddControls() {
            UserControls.SizeMode = TabSizeMode.FillToRight;
            UserControls.Appearance = TabAppearance.Normal;

            edit = new EditStockPriceView();
            edit.Dock = DockStyle.Fill;
            TabPage EditPriceStockPage = new TabPage();
            EditPriceStockPage.Controls.Add(edit);
            EditPriceStockPage.Text = "Editing and Calculations";
            EditPriceStockPage.ForeColor = Color.White;
            EditPriceStockPage.BackColor = Color.FromArgb(11, 23, 42);
            UserControls.TabPages.Add(EditPriceStockPage);

            stocktrack = new StockTrackingView();
            stocktrack.Dock = DockStyle.Fill;
            TabPage StockTrackingPage = new TabPage();
            StockTrackingPage.Controls.Add(stocktrack);
            StockTrackingPage.Text = "Stock Tracking";
            StockTrackingPage.ForeColor = Color.White;
            StockTrackingPage.BackColor = Color.FromArgb(11, 23, 42);
            UserControls.TabPages.Add(StockTrackingPage);

            updateprod = new UpdateDatabaseView();
            updateprod.Dock = DockStyle.Fill;
            TabPage UpdateDatabasePage = new TabPage();
            UpdateDatabasePage.Controls.Add(updateprod);
            UpdateDatabasePage.Text = "Update Database";
            UpdateDatabasePage.ForeColor = Color.White;
            UpdateDatabasePage.BackColor = Color.FromArgb(11, 23, 42);
            UserControls.TabPages.Add(UpdateDatabasePage);

            updatecust = new UpdateCustListView();
            updatecust.Dock = DockStyle.Fill;
            TabPage UpdateCustListPage = new TabPage();
            UpdateCustListPage.Controls.Add(updatecust);
            UpdateCustListPage.Text = "Update Customer List";
            UpdateCustListPage.ForeColor = Color.White;
            UpdateCustListPage.BackColor = Color.FromArgb(11, 23, 42);
            UserControls.TabPages.Add(UpdateCustListPage);

            /**
            if (listBox1.SelectedItem == tablelist[0])
            {
                ((Control)UpdateCustListPage).Enabled = false;
            }
            **/
        }

        /// <summary>
        ///     <para>
        ///         This is a method used to display an item in a selected row.
        ///         If you double click on a row in the dataGridView, then the item information will be displayed in seperate text boxes in the UpdateDatabaseView user control.
        /// 
        ///         (Update)
        ///         This method was previously used to retrieve items and display them in the textboxes, but wont be used anymore.
        ///     </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stockView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            /**
            if (listBox1.SelectedItem == tablelist[0])
            {
                string idcell = stockView.CurrentCell.OwningRow.Cells[0].Value.ToString();
                string namecell = stockView.CurrentCell.OwningRow.Cells[1].Value.ToString();
                string pricecell = stockView.CurrentCell.OwningRow.Cells[2].Value.ToString();
                string quantitycell = stockView.CurrentCell.OwningRow.Cells[3].Value.ToString();
                string dateofusecell = stockView.CurrentCell.OwningRow.Cells[4].Value.ToString();
                string dateofpurchcell = stockView.CurrentCell.OwningRow.Cells[5].Value.ToString();
            } else if(listBox1.SelectedItem == tablelist[1]) { 
                string idcell = stockView.CurrentCell.OwningRow.Cells[0].Value.ToString();
                string namecell = stockView.CurrentCell.OwningRow.Cells[1].Value.ToString();
                string emailcell = stockView.CurrentCell.OwningRow.Cells[2].Value.ToString();
                string phonecell = stockView.CurrentCell.OwningRow.Cells[3].Value.ToString();
            }
            **/
        }

        /// <summary>
        ///     <para>
        ///         This method is used to change the list box to the seperate CustomerList and Products tables, within SQlite
        ///     </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO - Make sure that this method is either only called once, or multiple times that resets the table but still shows the data at least
            table.Reset();
            int counter = 0;
            counter += 1;
            
            if (listBox1.SelectedItem == tablelist[0] && counter != 2)
            {
                ShowStock();
            }
            else if (listBox1.SelectedItem == tablelist[1] && counter != 2)
            {
                ShowCustList();
            }
        }


        /// <summary>
        ///     <para>
        ///         This button method returns the user to the menu screen
        ///     </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormControl.menu2.Show();
        }
    }
}
