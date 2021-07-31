
namespace StockProgram
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.returnBtn = new System.Windows.Forms.Button();
            this.UserControls = new System.Windows.Forms.TabControl();
            this.EditPriceStock = new System.Windows.Forms.TabPage();
            this.StockTracking = new System.Windows.Forms.TabPage();
            this.UpdateDatabase = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.UserControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(966, 302);
            this.dataGridView1.TabIndex = 0;
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(852, 25);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(159, 46);
            this.returnBtn.TabIndex = 1;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // UserControls
            // 
            this.UserControls.Controls.Add(this.EditPriceStock);
            this.UserControls.Controls.Add(this.StockTracking);
            this.UserControls.Controls.Add(this.UpdateDatabase);
            this.UserControls.Location = new System.Drawing.Point(45, 454);
            this.UserControls.Name = "UserControls";
            this.UserControls.SelectedIndex = 0;
            this.UserControls.Size = new System.Drawing.Size(966, 300);
            this.UserControls.TabIndex = 21;
            // 
            // EditPriceStock
            // 
            this.EditPriceStock.Location = new System.Drawing.Point(4, 25);
            this.EditPriceStock.Name = "EditPriceStock";
            this.EditPriceStock.Padding = new System.Windows.Forms.Padding(3);
            this.EditPriceStock.Size = new System.Drawing.Size(958, 271);
            this.EditPriceStock.TabIndex = 0;
            this.EditPriceStock.Text = "Editing and Calculations";
            this.EditPriceStock.UseVisualStyleBackColor = true;
            // 
            // StockTracking
            // 
            this.StockTracking.Location = new System.Drawing.Point(4, 25);
            this.StockTracking.Name = "StockTracking";
            this.StockTracking.Padding = new System.Windows.Forms.Padding(3);
            this.StockTracking.Size = new System.Drawing.Size(924, 348);
            this.StockTracking.TabIndex = 1;
            this.StockTracking.Text = "Stock Tracking";
            this.StockTracking.UseVisualStyleBackColor = true;
            // 
            // UpdateDatabase
            // 
            this.UpdateDatabase.Location = new System.Drawing.Point(4, 25);
            this.UpdateDatabase.Name = "UpdateDatabase";
            this.UpdateDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.UpdateDatabase.Size = new System.Drawing.Size(924, 348);
            this.UpdateDatabase.TabIndex = 2;
            this.UpdateDatabase.Text = "Update database";
            this.UpdateDatabase.UseVisualStyleBackColor = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 786);
            this.Controls.Add(this.UserControls);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.UserControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.TabControl UserControls;
        private System.Windows.Forms.TabPage EditPriceStock;
        private System.Windows.Forms.TabPage StockTracking;
        private System.Windows.Forms.TabPage UpdateDatabase;
    }
}