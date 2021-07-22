
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.stockView = new System.Windows.Forms.DataGridView();
            this.sortBtn = new System.Windows.Forms.Button();
            this.sortNameBtn = new System.Windows.Forms.Button();
            this.submitStockBtn = new System.Windows.Forms.Button();
            this.enterNameTb = new System.Windows.Forms.TextBox();
            this.enterNameLbl = new System.Windows.Forms.Label();
            this.enterPriceTb = new System.Windows.Forms.TextBox();
            this.enterPriceLbl = new System.Windows.Forms.Label();
            this.enterQuantityTb = new System.Windows.Forms.TextBox();
            this.enterQuantityLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.returnBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stockView)).BeginInit();
            this.SuspendLayout();
            // 
            // stockView
            // 
            this.stockView.BackgroundColor = System.Drawing.Color.White;
            this.stockView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockView.DefaultCellStyle = dataGridViewCellStyle2;
            this.stockView.Location = new System.Drawing.Point(46, 193);
            this.stockView.Name = "stockView";
            this.stockView.RowHeadersWidth = 51;
            this.stockView.RowTemplate.Height = 24;
            this.stockView.Size = new System.Drawing.Size(932, 245);
            this.stockView.TabIndex = 0;
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(46, 114);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(453, 57);
            this.sortBtn.TabIndex = 4;
            this.sortBtn.Text = "Sort stock";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // sortNameBtn
            // 
            this.sortNameBtn.Location = new System.Drawing.Point(519, 114);
            this.sortNameBtn.Name = "sortNameBtn";
            this.sortNameBtn.Size = new System.Drawing.Size(459, 57);
            this.sortNameBtn.TabIndex = 5;
            this.sortNameBtn.Text = "Sort stock by Name";
            this.sortNameBtn.UseVisualStyleBackColor = true;
            this.sortNameBtn.Click += new System.EventHandler(this.sortNameBtn_Click);
            // 
            // submitStockBtn
            // 
            this.submitStockBtn.Location = new System.Drawing.Point(770, 478);
            this.submitStockBtn.Name = "submitStockBtn";
            this.submitStockBtn.Size = new System.Drawing.Size(208, 121);
            this.submitStockBtn.TabIndex = 8;
            this.submitStockBtn.Text = "Submit Stock";
            this.submitStockBtn.UseVisualStyleBackColor = true;
            // 
            // enterNameTb
            // 
            this.enterNameTb.Location = new System.Drawing.Point(327, 478);
            this.enterNameTb.Name = "enterNameTb";
            this.enterNameTb.Size = new System.Drawing.Size(422, 22);
            this.enterNameTb.TabIndex = 10;
            // 
            // enterNameLbl
            // 
            this.enterNameLbl.AutoSize = true;
            this.enterNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterNameLbl.Location = new System.Drawing.Point(44, 468);
            this.enterNameLbl.Name = "enterNameLbl";
            this.enterNameLbl.Size = new System.Drawing.Size(230, 31);
            this.enterNameLbl.TabIndex = 9;
            this.enterNameLbl.Text = "Enter stock Name";
            // 
            // enterPriceTb
            // 
            this.enterPriceTb.Location = new System.Drawing.Point(327, 527);
            this.enterPriceTb.Name = "enterPriceTb";
            this.enterPriceTb.Size = new System.Drawing.Size(422, 22);
            this.enterPriceTb.TabIndex = 13;
            // 
            // enterPriceLbl
            // 
            this.enterPriceLbl.AutoSize = true;
            this.enterPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterPriceLbl.Location = new System.Drawing.Point(44, 517);
            this.enterPriceLbl.Name = "enterPriceLbl";
            this.enterPriceLbl.Size = new System.Drawing.Size(206, 31);
            this.enterPriceLbl.TabIndex = 12;
            this.enterPriceLbl.Text = "Enter item Price";
            // 
            // enterQuantityTb
            // 
            this.enterQuantityTb.Location = new System.Drawing.Point(327, 577);
            this.enterQuantityTb.Name = "enterQuantityTb";
            this.enterQuantityTb.Size = new System.Drawing.Size(422, 22);
            this.enterQuantityTb.TabIndex = 16;
            // 
            // enterQuantityLbl
            // 
            this.enterQuantityLbl.AutoSize = true;
            this.enterQuantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterQuantityLbl.Location = new System.Drawing.Point(45, 567);
            this.enterQuantityLbl.Name = "enterQuantityLbl";
            this.enterQuantityLbl.Size = new System.Drawing.Size(246, 31);
            this.enterQuantityLbl.TabIndex = 15;
            this.enterQuantityLbl.Text = "Enter item Quantity";
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
            // MainDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 645);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterQuantityTb);
            this.Controls.Add(this.enterQuantityLbl);
            this.Controls.Add(this.enterPriceTb);
            this.Controls.Add(this.enterPriceLbl);
            this.Controls.Add(this.enterNameTb);
            this.Controls.Add(this.enterNameLbl);
            this.Controls.Add(this.submitStockBtn);
            this.Controls.Add(this.sortNameBtn);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.stockView);
            this.Name = "MainDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainDatabase";
            ((System.ComponentModel.ISupportInitialize)(this.stockView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView stockView;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Button sortNameBtn;
        private System.Windows.Forms.Button submitStockBtn;
        private System.Windows.Forms.TextBox enterNameTb;
        private System.Windows.Forms.Label enterNameLbl;
        private System.Windows.Forms.TextBox enterPriceTb;
        private System.Windows.Forms.Label enterPriceLbl;
        private System.Windows.Forms.TextBox enterQuantityTb;
        private System.Windows.Forms.Label enterQuantityLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button returnBtn;
    }
}

