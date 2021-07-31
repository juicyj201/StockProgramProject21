
namespace StockProgram
{
    partial class MainDatabase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.stockView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.returnBtn = new System.Windows.Forms.Button();
            this.UserControls = new System.Windows.Forms.TabControl();
            this.EditPriceStock = new System.Windows.Forms.TabPage();
            this.StockTracking = new System.Windows.Forms.TabPage();
            this.UpdateDatabase = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.stockView)).BeginInit();
            this.UserControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // stockView
            // 
            this.stockView.BackgroundColor = System.Drawing.Color.White;
            this.stockView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockView.DefaultCellStyle = dataGridViewCellStyle3;
            this.stockView.Location = new System.Drawing.Point(50, 115);
            this.stockView.Name = "stockView";
            this.stockView.RowHeadersWidth = 51;
            this.stockView.RowTemplate.Height = 24;
            this.stockView.Size = new System.Drawing.Size(932, 203);
            this.stockView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 48);
            this.label1.TabIndex = 18;
            this.label1.Text = "Main Database";
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(875, 12);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(131, 46);
            this.returnBtn.TabIndex = 19;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // UserControls
            // 
            this.UserControls.Controls.Add(this.EditPriceStock);
            this.UserControls.Controls.Add(this.StockTracking);
            this.UserControls.Controls.Add(this.UpdateDatabase);
            this.UserControls.Location = new System.Drawing.Point(50, 340);
            this.UserControls.Name = "UserControls";
            this.UserControls.SelectedIndex = 0;
            this.UserControls.Size = new System.Drawing.Size(932, 377);
            this.UserControls.TabIndex = 20;
            // 
            // EditPriceStock
            // 
            this.EditPriceStock.Location = new System.Drawing.Point(4, 25);
            this.EditPriceStock.Name = "EditPriceStock";
            this.EditPriceStock.Padding = new System.Windows.Forms.Padding(3);
            this.EditPriceStock.Size = new System.Drawing.Size(924, 348);
            this.EditPriceStock.TabIndex = 0;
            this.EditPriceStock.Text = "Editing and Calculations";
            this.EditPriceStock.UseVisualStyleBackColor = true;
            //this.EditPriceStock.Click += new System.EventHandler(this.EditPriceStock_Click);
            // 
            // StockTracking
            // 
            this.StockTracking.Location = new System.Drawing.Point(4, 25);
            this.StockTracking.Name = "StockTracking";
            this.StockTracking.Padding = new System.Windows.Forms.Padding(3);
            this.StockTracking.Size = new System.Drawing.Size(924, 315);
            this.StockTracking.TabIndex = 1;
            this.StockTracking.Text = "Stock Tracking";
            this.StockTracking.UseVisualStyleBackColor = true;
            // 
            // UpdateDatabase
            // 
            this.UpdateDatabase.Location = new System.Drawing.Point(4, 25);
            this.UpdateDatabase.Name = "UpdateDatabase";
            this.UpdateDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.UpdateDatabase.Size = new System.Drawing.Size(924, 315);
            this.UpdateDatabase.TabIndex = 2;
            this.UpdateDatabase.Text = "Update database";
            this.UpdateDatabase.UseVisualStyleBackColor = true;
            // 
            // MainDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 750);
            this.Controls.Add(this.UserControls);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stockView);
            this.Name = "MainDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainDatabase";
            ((System.ComponentModel.ISupportInitialize)(this.stockView)).EndInit();
            this.UserControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView stockView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.TabControl UserControls;
        private System.Windows.Forms.TabPage EditPriceStock;
        private System.Windows.Forms.TabPage StockTracking;
        private System.Windows.Forms.TabPage UpdateDatabase;
    }
}

