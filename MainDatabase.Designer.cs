
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
            this.DatabaseSelectionBox = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.stockView)).BeginInit();
            this.DatabaseSelectionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // stockView
            // 
            resources.ApplyResources(this.stockView, "stockView");
            this.stockView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            // DatabaseSelectionBox
            // 
            this.DatabaseSelectionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(65)))), ((int)(((byte)(35)))));
            this.DatabaseSelectionBox.Controls.Add(this.listBox1);
            resources.ApplyResources(this.DatabaseSelectionBox, "DatabaseSelectionBox");
            this.DatabaseSelectionBox.Name = "DatabaseSelectionBox";
            this.DatabaseSelectionBox.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // MainDatabase
            // 
            resources.ApplyResources(this, "$this");
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ControlBox = false;
            this.Controls.Add(this.DatabaseSelectionBox);
            this.Controls.Add(this.UserControls);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stockView);
            this.Name = "MainDatabase";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.stockView)).EndInit();
            this.DatabaseSelectionBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView stockView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.TabControl UserControls;
        private System.Windows.Forms.GroupBox DatabaseSelectionBox;
        private System.Windows.Forms.ListBox listBox1;

        public System.Windows.Forms.DataGridView getStockView { get { return stockView; } }
        public System.Windows.Forms.Label getLabel1 { get { return label1; } }
        public System.Windows.Forms.Button getReturnBtn { get { return returnBtn; } }
        public System.Windows.Forms.TabControl getUserControls { get { return UserControls; } }
        public System.Windows.Forms.GroupBox getDatabaseSelectionBox { get { return DatabaseSelectionBox; } }
        public System.Windows.Forms.ListBox getListBox1 { get { return listBox1; } }
    }
}

