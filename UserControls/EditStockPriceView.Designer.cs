
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
            this.txtboxPrice = new System.Windows.Forms.TextBox();
            this.cmbx = new System.Windows.Forms.ComboBox();
            this.btnEditPrice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtboxPrice
            // 
            this.txtboxPrice.Location = new System.Drawing.Point(269, 201);
            this.txtboxPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxPrice.Multiline = true;
            this.txtboxPrice.Name = "txtboxPrice";
            this.txtboxPrice.Size = new System.Drawing.Size(231, 35);
            this.txtboxPrice.TabIndex = 2;
            this.txtboxPrice.TextChanged += new System.EventHandler(this.txtboxPrice_TextChanged);
            // 
            // cmbx
            // 
            this.cmbx.FormattingEnabled = true;
            this.cmbx.Location = new System.Drawing.Point(269, 144);
            this.cmbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbx.Name = "cmbx";
            this.cmbx.Size = new System.Drawing.Size(231, 24);
            this.cmbx.TabIndex = 5;
            this.cmbx.SelectedIndexChanged += new System.EventHandler(this.cmbx_SelectedIndexChanged);
            // 
            // btnEditPrice
            // 
            this.btnEditPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnEditPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPrice.ForeColor = System.Drawing.Color.White;
            this.btnEditPrice.Location = new System.Drawing.Point(302, 287);
            this.btnEditPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditPrice.Name = "btnEditPrice";
            this.btnEditPrice.Size = new System.Drawing.Size(195, 43);
            this.btnEditPrice.TabIndex = 3;
            this.btnEditPrice.Text = "Edit Item Price";
            this.btnEditPrice.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(73, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Item Id";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(65)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(-4, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(616, 98);
            this.panel2.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(160, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(293, 48);
            this.label9.TabIndex = 19;
            this.label9.Text = "Edit Item Price";
            // 
            // EditStockPriceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditPrice);
            this.Controls.Add(this.cmbx);
            this.Controls.Add(this.txtboxPrice);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditStockPriceView";
            this.Size = new System.Drawing.Size(612, 417);
            this.Load += new System.EventHandler(this.EditStockPriceView_Load);
            this.SizeChanged += new System.EventHandler(this.EditStockPriceView_SizeChanged);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtboxPrice;
        private System.Windows.Forms.ComboBox cmbx;
        private System.Windows.Forms.Button btnEditPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
    }
}
