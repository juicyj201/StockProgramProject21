
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDatabase));
            this.stockView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.returnBtn = new System.Windows.Forms.Button();
            this.UserControls = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.stockView)).BeginInit();
            this.SuspendLayout();
            // 
            // stockView
            // 
            this.stockView.BackgroundColor = System.Drawing.Color.White;
            this.stockView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockView.DefaultCellStyle = dataGridViewCellStyle1;
            this.stockView.Location = new System.Drawing.Point(53, 111);
            this.stockView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stockView.Name = "stockView";
            this.stockView.RowHeadersWidth = 51;
            this.stockView.RowTemplate.Height = 24;
            this.stockView.Size = new System.Drawing.Size(870, 546);
            this.stockView.TabIndex = 0;
            this.stockView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockView_CellContentClick);
            this.stockView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.stockView_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 48);
            this.label1.TabIndex = 18;
            this.label1.Text = "Main Database";
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.ForeColor = System.Drawing.Color.White;
            this.returnBtn.Location = new System.Drawing.Point(792, 35);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(131, 46);
            this.returnBtn.TabIndex = 19;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // UserControls
            // 
            this.UserControls.Location = new System.Drawing.Point(974, 33);
            this.UserControls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserControls.Name = "UserControls";
            this.UserControls.SelectedIndex = 0;
            this.UserControls.Size = new System.Drawing.Size(611, 624);
            this.UserControls.TabIndex = 20;
            // 
            // MainDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1636, 699);
            this.ControlBox = false;
            this.Controls.Add(this.UserControls);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stockView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainDatabase";
            ((System.ComponentModel.ISupportInitialize)(this.stockView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView stockView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.TabControl UserControls;
    }
}

