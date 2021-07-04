
namespace StockProgram
{
    partial class StartMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.maindatabaseBtn = new System.Windows.Forms.Button();
            this.stockeditingBtn = new System.Windows.Forms.Button();
            this.stockupdatingBtn = new System.Windows.Forms.Button();
            this.stocktrackingBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(319, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 74);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // maindatabaseBtn
            // 
            this.maindatabaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maindatabaseBtn.Location = new System.Drawing.Point(235, 125);
            this.maindatabaseBtn.Name = "maindatabaseBtn";
            this.maindatabaseBtn.Size = new System.Drawing.Size(299, 67);
            this.maindatabaseBtn.TabIndex = 1;
            this.maindatabaseBtn.Text = "Main Database";
            this.maindatabaseBtn.UseVisualStyleBackColor = true;
            this.maindatabaseBtn.Click += new System.EventHandler(this.maindatabaseBtn_Click);
            // 
            // stockeditingBtn
            // 
            this.stockeditingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockeditingBtn.Location = new System.Drawing.Point(235, 212);
            this.stockeditingBtn.Name = "stockeditingBtn";
            this.stockeditingBtn.Size = new System.Drawing.Size(299, 62);
            this.stockeditingBtn.TabIndex = 2;
            this.stockeditingBtn.Text = "Stock Editing";
            this.stockeditingBtn.UseVisualStyleBackColor = true;
            this.stockeditingBtn.Click += new System.EventHandler(this.stockeditingBtn_Click);
            // 
            // stockupdatingBtn
            // 
            this.stockupdatingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockupdatingBtn.Location = new System.Drawing.Point(235, 294);
            this.stockupdatingBtn.Name = "stockupdatingBtn";
            this.stockupdatingBtn.Size = new System.Drawing.Size(299, 58);
            this.stockupdatingBtn.TabIndex = 3;
            this.stockupdatingBtn.Text = "Stock Updating";
            this.stockupdatingBtn.UseVisualStyleBackColor = true;
            this.stockupdatingBtn.Click += new System.EventHandler(this.stockupdatingBtn_Click);
            // 
            // stocktrackingBtn
            // 
            this.stocktrackingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stocktrackingBtn.Location = new System.Drawing.Point(235, 371);
            this.stocktrackingBtn.Name = "stocktrackingBtn";
            this.stocktrackingBtn.Size = new System.Drawing.Size(299, 57);
            this.stocktrackingBtn.TabIndex = 4;
            this.stocktrackingBtn.Text = "Stock Tracking";
            this.stocktrackingBtn.UseVisualStyleBackColor = true;
            this.stocktrackingBtn.Click += new System.EventHandler(this.stocktrackingBtn_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.Location = new System.Drawing.Point(235, 449);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(299, 59);
            this.helpBtn.TabIndex = 5;
            this.helpBtn.Text = "Help";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Location = new System.Drawing.Point(235, 528);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(299, 57);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(782, 640);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.stocktrackingBtn);
            this.Controls.Add(this.stockupdatingBtn);
            this.Controls.Add(this.stockeditingBtn);
            this.Controls.Add(this.maindatabaseBtn);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Yi Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "StartMenu";
            this.Text = "StartMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button maindatabaseBtn;
        private System.Windows.Forms.Button stockeditingBtn;
        private System.Windows.Forms.Button stockupdatingBtn;
        private System.Windows.Forms.Button stocktrackingBtn;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}