
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
            this.stockView = new System.Windows.Forms.DataGridView();
            this.sortBtn = new System.Windows.Forms.Button();
            this.sortNameBtn = new System.Windows.Forms.Button();
            this.IdLbl = new System.Windows.Forms.Label();
            this.enterIdTb = new System.Windows.Forms.TextBox();
            this.submitStockBtn = new System.Windows.Forms.Button();
            this.enterNameTb = new System.Windows.Forms.TextBox();
            this.enterNameLbl = new System.Windows.Forms.Label();
            this.enterPriceTb = new System.Windows.Forms.TextBox();
            this.enterPriceLbl = new System.Windows.Forms.Label();
            this.enterQuantityTb = new System.Windows.Forms.TextBox();
            this.enterQuantityLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockView)).BeginInit();
            this.SuspendLayout();
            // 
            // stockView
            // 
            this.stockView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLbl.Location = new System.Drawing.Point(43, 491);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(167, 31);
            this.IdLbl.TabIndex = 6;
            this.IdLbl.Text = "Enter item Id";
            // 
            // enterIdTb
            // 
            this.enterIdTb.Location = new System.Drawing.Point(326, 501);
            this.enterIdTb.Name = "enterIdTb";
            this.enterIdTb.Size = new System.Drawing.Size(422, 22);
            this.enterIdTb.TabIndex = 7;
            // 
            // submitStockBtn
            // 
            this.submitStockBtn.Location = new System.Drawing.Point(770, 500);
            this.submitStockBtn.Name = "submitStockBtn";
            this.submitStockBtn.Size = new System.Drawing.Size(208, 174);
            this.submitStockBtn.TabIndex = 8;
            this.submitStockBtn.Text = "Submit Stock";
            this.submitStockBtn.UseVisualStyleBackColor = true;
            this.submitStockBtn.Click += new System.EventHandler(this.submitStockBtn_Click);
            // 
            // enterNameTb
            // 
            this.enterNameTb.Location = new System.Drawing.Point(326, 553);
            this.enterNameTb.Name = "enterNameTb";
            this.enterNameTb.Size = new System.Drawing.Size(422, 22);
            this.enterNameTb.TabIndex = 10;
            // 
            // enterNameLbl
            // 
            this.enterNameLbl.AutoSize = true;
            this.enterNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterNameLbl.Location = new System.Drawing.Point(43, 543);
            this.enterNameLbl.Name = "enterNameLbl";
            this.enterNameLbl.Size = new System.Drawing.Size(230, 31);
            this.enterNameLbl.TabIndex = 9;
            this.enterNameLbl.Text = "Enter stock Name";
            // 
            // enterPriceTb
            // 
            this.enterPriceTb.Location = new System.Drawing.Point(326, 602);
            this.enterPriceTb.Name = "enterPriceTb";
            this.enterPriceTb.Size = new System.Drawing.Size(422, 22);
            this.enterPriceTb.TabIndex = 13;
            // 
            // enterPriceLbl
            // 
            this.enterPriceLbl.AutoSize = true;
            this.enterPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterPriceLbl.Location = new System.Drawing.Point(43, 592);
            this.enterPriceLbl.Name = "enterPriceLbl";
            this.enterPriceLbl.Size = new System.Drawing.Size(206, 31);
            this.enterPriceLbl.TabIndex = 12;
            this.enterPriceLbl.Text = "Enter item Price";
            // 
            // enterQuantityTb
            // 
            this.enterQuantityTb.Location = new System.Drawing.Point(326, 652);
            this.enterQuantityTb.Name = "enterQuantityTb";
            this.enterQuantityTb.Size = new System.Drawing.Size(422, 22);
            this.enterQuantityTb.TabIndex = 16;
            // 
            // enterQuantityLbl
            // 
            this.enterQuantityLbl.AutoSize = true;
            this.enterQuantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterQuantityLbl.Location = new System.Drawing.Point(44, 642);
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
            // MainDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 758);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterQuantityTb);
            this.Controls.Add(this.enterQuantityLbl);
            this.Controls.Add(this.enterPriceTb);
            this.Controls.Add(this.enterPriceLbl);
            this.Controls.Add(this.enterNameTb);
            this.Controls.Add(this.enterNameLbl);
            this.Controls.Add(this.submitStockBtn);
            this.Controls.Add(this.enterIdTb);
            this.Controls.Add(this.IdLbl);
            this.Controls.Add(this.sortNameBtn);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.stockView);
            this.Name = "MainDatabase";
            this.Text = "MainDatabase";
            ((System.ComponentModel.ISupportInitialize)(this.stockView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView stockView;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Button sortNameBtn;
        private System.Windows.Forms.Label IdLbl;
        private System.Windows.Forms.TextBox enterIdTb;
        private System.Windows.Forms.Button submitStockBtn;
        private System.Windows.Forms.TextBox enterNameTb;
        private System.Windows.Forms.Label enterNameLbl;
        private System.Windows.Forms.TextBox enterPriceTb;
        private System.Windows.Forms.Label enterPriceLbl;
        private System.Windows.Forms.TextBox enterQuantityTb;
        private System.Windows.Forms.Label enterQuantityLbl;
        private System.Windows.Forms.Label label1;
    }
}

