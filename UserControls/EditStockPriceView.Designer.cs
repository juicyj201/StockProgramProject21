
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmblistId = new System.Windows.Forms.ComboBox();
            this.btnEditPrice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcomboTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(19, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(258, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Edit Product Price";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 125);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 33);
            this.textBox1.TabIndex = 2;
            // 
            // cmblistId
            // 
            this.cmblistId.FormattingEnabled = true;
            this.cmblistId.Location = new System.Drawing.Point(479, 125);
            this.cmblistId.Name = "cmblistId";
            this.cmblistId.Size = new System.Drawing.Size(230, 24);
            this.cmblistId.TabIndex = 5;
            // 
            // btnEditPrice
            // 
            this.btnEditPrice.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEditPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPrice.ForeColor = System.Drawing.Color.White;
            this.btnEditPrice.Location = new System.Drawing.Point(161, 188);
            this.btnEditPrice.Name = "btnEditPrice";
            this.btnEditPrice.Size = new System.Drawing.Size(182, 43);
            this.btnEditPrice.TabIndex = 3;
            this.btnEditPrice.Text = "Edit ";
            this.btnEditPrice.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Price";
            // 
            // lblcomboTitle
            // 
            this.lblcomboTitle.AutoSize = true;
            this.lblcomboTitle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomboTitle.Location = new System.Drawing.Point(475, 63);
            this.lblcomboTitle.Name = "lblcomboTitle";
            this.lblcomboTitle.Size = new System.Drawing.Size(231, 22);
            this.lblcomboTitle.TabIndex = 4;
            this.lblcomboTitle.Text = "Select an id to edit price";
            // 
            // EditStockPriceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblcomboTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditPrice);
            this.Controls.Add(this.cmblistId);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTitle);
            this.Name = "EditStockPriceView";
            this.Size = new System.Drawing.Size(726, 293);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmblistId;
        private System.Windows.Forms.Button btnEditPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcomboTitle;
    }
}
