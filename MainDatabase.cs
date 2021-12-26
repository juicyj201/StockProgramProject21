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
        /// These are the global variables for the MainDatabase class
        /// </summary>
        private SQLiteConnection conn = new SQLiteConnection(@"data source=.\StockDatabase.db");
        private DataTable table = new DataTable();

        private EditStockPriceView editstuff;
        private StockTrackingView stocktrackstuff;
        private UpdateDatabaseView updatestuff;

        private ArrayList tablelist = new ArrayList();

        public MainDatabase()
        {
            ///<summary>
            /// We initialise the components and reference the methods that the program uses, inside this constructor
            ///<summary>
            InitializeComponent();

            listBox1.Items.Add(tablelist.IndexOf(1));
            listBox1.Items.Add(tablelist.IndexOf(2));

            OpenConnection();
            ShowStock();
            AddControls();
            CloseConnection();
        }

        /// <summary>
        /// These are the methods used for opening and closing the connection to the sqlite database.
        /// </summary>
        public void OpenConnection() {
            conn.Open();
        }

        public void CloseConnection() {
            conn.Close();
        }

        /// <summary>
        /// This is a method used to show the items inside the sqlite database
        /// </summary>
        public void ShowStock() {
            //the command object used to retrieve all the rows in the database
            string selectStock = "SELECT* from Products";
            SQLiteCommand selectComm = new SQLiteCommand(selectStock, conn);

            //the data adapter used to fill the table
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectComm);
            adapter.Fill(table);

            //putting the datagrid in the table
            stockView.DataSource = table;

            //stockView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.None);
            //stockView.AutoResizeRows(DataGridViewAutoSizeRowsMode.None);
        }

        private void ShowTables() { 
            //retrieving all the tables from the database
            
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormControl.menu2.Show();
        }

        /// <summary>
        /// This is a method used to add the user controls, to the tab control in the MainDatabase form
        /// </summary>
        private void AddControls() {
            UserControls.SizeMode = TabSizeMode.FillToRight;
            UserControls.Appearance = TabAppearance.Normal;

            editstuff = new EditStockPriceView();
            editstuff.Dock = DockStyle.Fill;
            TabPage EditPriceStockPage = new TabPage();
            EditPriceStockPage.Controls.Add(editstuff);
            EditPriceStockPage.Text = "Editing and Calculations";
            EditPriceStockPage.ForeColor = Color.White;
            EditPriceStockPage.BackColor = Color.FromArgb(11, 23, 42);
            UserControls.TabPages.Add(EditPriceStockPage);

            stocktrackstuff = new StockTrackingView();
            stocktrackstuff.Dock = DockStyle.Fill;
            TabPage StockTrackingPage = new TabPage();
            StockTrackingPage.Controls.Add(stocktrackstuff);
            StockTrackingPage.Text = "Stock Tracking";
            StockTrackingPage.ForeColor = Color.White;
            EditPriceStockPage.BackColor = Color.FromArgb(11, 23, 42);
            UserControls.TabPages.Add(StockTrackingPage);

            updatestuff = new UpdateDatabaseView();
            updatestuff.Dock = DockStyle.Fill;
            TabPage UpdateDatabasePage = new TabPage();
            UpdateDatabasePage.Controls.Add(updatestuff);
            UpdateDatabasePage.Text = "Update Database";
            UpdateDatabasePage.ForeColor = Color.White;
            EditPriceStockPage.BackColor = Color.FromArgb(11, 23, 42);
            UserControls.TabPages.Add(UpdateDatabasePage);
        }

        /// <summary>
        /// This is a method used to display an item in a selected row.
        /// If you double click on a row in the dataGridView, then the item information will be displayed in seperate text boxes in the UpdateDatabaseView user control.
        /// 
        /// (Update)
        /// was previously used to retrieve items and display them in the textboxes, but wont be used anymore.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stockView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string idcell = stockView.CurrentCell.OwningRow.Cells[0].Value.ToString();
            string namecell = stockView.CurrentCell.OwningRow.Cells[1].Value.ToString();
            string pricecell = stockView.CurrentCell.OwningRow.Cells[2].Value.ToString();
            string quantitycell = stockView.CurrentCell.OwningRow.Cells[3].Value.ToString();
            string dateofusecell = stockView.CurrentCell.OwningRow.Cells[4].Value.ToString();
            string dateofpurchcell = stockView.CurrentCell.OwningRow.Cells[5].Value.ToString();

            //updatestuff.gettextBox1.Text = idcell;
            //updatestuff.gettextBox2.Text = namecell;
            //updatestuff.gettextBox3.Text = pricecell;
            //updatestuff.gettextBox4.Text = quantitycell;
            //updatestuff.gettextBox5.Text = dateofusecell;
            //updatestuff.gettextBox6.Text = dateofpurchcell;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //have a function that will change the database
            if (tablelist.Contains(listBox1.SelectedItem)) { 
                
            }
        }
    }
}
