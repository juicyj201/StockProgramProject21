
namespace StockProgram.UserControls
{
    partial class EditStockPriceView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtboxPrice = new System.Windows.Forms.TextBox();
            this.cmbx = new System.Windows.Forms.ComboBox();
            this.btnEditPrice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(203, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(252, 34);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Edit Product Price";
            // 
            // txtboxPrice
            // 
            this.txtboxPrice.Location = new System.Drawing.Point(209, 240);
            this.txtboxPrice.Multiline = true;
            this.txtboxPrice.Name = "txtboxPrice";
            this.txtboxPrice.Size = new System.Drawing.Size(230, 35);
            this.txtboxPrice.TabIndex = 2;
            // 
            // cmbx
            // 
            this.cmbx.FormattingEnabled = true;
            this.cmbx.Location = new System.Drawing.Point(209, 174);
            this.cmbx.Name = "cmbx";
            this.cmbx.Size = new System.Drawing.Size(230, 24);
            this.cmbx.TabIndex = 5;
            this.cmbx.SelectedIndexChanged += new System.EventHandler(this.cmblistId_SelectedIndexChanged);
            // 
            // btnEditPrice
            // 
            this.btnEditPrice.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEditPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPrice.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPrice.ForeColor = System.Drawing.Color.White;
            this.btnEditPrice.Location = new System.Drawing.Point(209, 305);
            this.btnEditPrice.Name = "btnEditPrice";
            this.btnEditPrice.Size = new System.Drawing.Size(230, 43);
            this.btnEditPrice.TabIndex = 3;
            this.btnEditPrice.Text = "Edit Item Price";
            this.btnEditPrice.UseVisualStyleBackColor = false;
            this.btnEditPrice.Click += new System.EventHandler(this.btnEditPrice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.label1.Location = new System.Drawing.Point(14, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Price";
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.BackColor = System.Drawing.Color.Red;
            this.btnCloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseApp.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseApp.ForeColor = System.Drawing.Color.White;
            this.btnCloseApp.Location = new System.Drawing.Point(209, 381);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(230, 41);
            this.btnCloseApp.TabIndex = 6;
            this.btnCloseApp.Text = "Close Application";
            this.btnCloseApp.UseVisualStyleBackColor = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.label2.Location = new System.Drawing.Point(14, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Item Id";
            // 
            // EditStockPriceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditPrice);
            this.Controls.Add(this.cmbx);
            this.Controls.Add(this.txtboxPrice);
            this.Controls.Add(this.lblTitle);
            this.Name = "EditStockPriceView";
            this.Size = new System.Drawing.Size(663, 510);
            this.Load += new System.EventHandler(this.EditStockPriceView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtboxPrice;
        private System.Windows.Forms.ComboBox cmbx;
        private System.Windows.Forms.Button btnEditPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseApp;
        private System.Windows.Forms.Label label2;
    }
}
