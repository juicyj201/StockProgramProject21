using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockProgram.UserControls
{
    public partial class UpdateCustListView : UserControl
    {
        private SQLiteConnection conn = new SQLiteConnection(@"data source=.\StockDatabase.db");
        public bool custupdated = false; 

        //regex
        private Regex regName = new Regex(@"^([a-zA-Z0-9 ])+$");
        private Regex regEmail = new Regex(@"^([a-zA-Z0-9_])+@([a-zA-Z])+\.([a-zA-Z])+$");
        private Regex regPhone = new Regex(@"^([0-9+]){0,10}$");

        /// <summary>
        ///     <para>
        ///         The methoded to initialise the view form of UpdateCustList
        ///     </para>
        /// </summary>
        public UpdateCustListView()
        {
            InitializeComponent();
        }

        private bool CheckText()
        {
            if (regName.IsMatch(custBox2.Text) && regEmail.IsMatch(custBox3.Text) && regPhone.IsMatch(custBox4.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CheckIfItemIsEntered() {
            if (custBox1.Text.Length == 0 && custBox2.Text.Length == 0 && custBox3.Text.Length == 0 && custBox4.Text.Length == 0)
            {
                ResetBtn.Enabled = false;
                custBtn1.Enabled = false;
                custBtn2.Enabled = false;
                custBtn3.Enabled = false;
            }
            else if (custBox1.Text.Length != 0 && custBox2.Text.Length != 0 && custBox3.Text.Length != 0 && custBox4.Text.Length != 0)
            {
                ResetBtn.Enabled = true;
                custBtn1.Enabled = true;
                custBtn2.Enabled = true;
                custBtn3.Enabled = true;
            }
        }

        private void openConn()
        {
            conn.Open();
        }

        private void closeConn()
        {
            conn.Close();
        }

        private void custBtn1_Click_1(object sender, EventArgs e)
        {
            //ADD
            if (custBox2.Text.Length > 0 && custBox3.Text.Length > 0 && custBox4.Text.Length > 0 && CheckText())
            {
                try
                {
                    openConn();

                    string sql = "insert into CustomerList (CustName, CustEmail, CustPhone) values (@CustName, @CustEmail, @CustPhone);";
                    SQLiteCommand comm = new SQLiteCommand(sql, conn);

                    comm.Parameters.AddWithValue("@CustName", custBox2.Text);
                    comm.Parameters.AddWithValue("@CustEmail", custBox3.Text);
                    comm.Parameters.AddWithValue("@CustPhone", custBox4.Text);

                    int ok = 0;
                    ok = comm.ExecuteNonQuery();

                    queryCheck(ok, "created");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else {
                MessageBox.Show("User data is not valid. Enter correct details before proceeding.");
            }
        }

        private void custBtn2_Click(object sender, EventArgs e)
        {
            //UPDATE
            if (custBox2.Text.Length > 0 && custBox3.Text.Length > 0 && custBox4.Text.Length > 0 && CheckText())
            {
                try
                {
                    openConn();

                    string sql = "update CustomerList set CustName = @CustName, CustEmail = @CustEmail, CustPhone = @CustPhone where CustName = @CustName, CustEmail = @CustEmail, CustPhone = @CustPhone;";
                    SQLiteCommand comm = new SQLiteCommand(sql, conn);

                    comm.Parameters.AddWithValue("@CustName", custBox2.Text);
                    comm.Parameters.AddWithValue("@CustEmail", custBox3.Text);
                    comm.Parameters.AddWithValue("@CustPhone", custBox4.Text);

                    int ok = comm.ExecuteNonQuery();

                    queryCheck(ok, "updated");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("User data is not valid. Enter correct details before proceeding.");
            }
        }

        private void custBtn3_Click(object sender, EventArgs e)
        {
            //DELETE
            if (custBox2.Text.Length > 0 && custBox3.Text.Length > 0 && custBox4.Text.Length > 0 && CheckText()) {
                try
                {
                    openConn();

                    string sql = "delete from CustomerList where CustName = @CustName, CustEmail = @CustEmail, CustPhone = @CustPhone;";
                    SQLiteCommand comm = new SQLiteCommand(sql, conn);

                    comm.Parameters.AddWithValue("@ProdName", custBox2.Text);
                    comm.Parameters.AddWithValue("@ProdPrice", custBox3.Text);
                    comm.Parameters.AddWithValue("@ProdQuantity", custBox4.Text);

                    int ok = comm.ExecuteNonQuery();

                    queryCheck(ok, "deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("User data is not valid. Enter correct details before proceeding.");
            }
        }

        private void queryCheck(int ok, string type) {
            if (ok > 0)
            {
                MessageBox.Show("Customer has successfully been "+type+".");
                custupdated = true;
            }
            else
            {
                MessageBox.Show("Customer has not been "+type+". Please try again. ");
            }

            closeConn();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            custBox1.Text = "";
            custBox2.Text = "";
            custBox3.Text = "";
            custBox4.Text = "";
        }

        private void UpdateDatabaseView_Load(object sender, EventArgs e)
        {
            //CheckIfItemIsEntered();
        }
    }
}
