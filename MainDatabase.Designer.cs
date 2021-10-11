
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDatabase));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.stockView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.returnBtn = new System.Windows.Forms.Button();
            this.UserControls = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.stockView)).BeginInit();
            this.SuspendLayout();
            // 
            // stockView
            // 
            resources.ApplyResources(this.stockView, "stockView");
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
            this.stockView.Name = "stockView";
            this.stockView.RowTemplate.Height = 24;
            this.stockView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.stockView_MouseDoubleClick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            resources.ApplyResources(this.returnBtn, "returnBtn");
            this.returnBtn.ForeColor = System.Drawing.Color.White;
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // UserControls
            // 
            resources.ApplyResources(this.UserControls, "UserControls");
            this.UserControls.Name = "UserControls";
            this.UserControls.SelectedIndex = 0;
            // 
            // MainDatabase
            // 
            resources.ApplyResources(this, "$this");
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ControlBox = false;
            this.Controls.Add(this.UserControls);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stockView);
            this.Name = "MainDatabase";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainDatabase_FormClosed);
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

