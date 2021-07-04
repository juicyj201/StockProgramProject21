﻿
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
            ((System.ComponentModel.ISupportInitialize)(this.stockView)).BeginInit();
            this.SuspendLayout();
            // 
            // stockView
            // 
            this.stockView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockView.Location = new System.Drawing.Point(46, 146);
            this.stockView.Name = "stockView";
            this.stockView.RowHeadersWidth = 51;
            this.stockView.RowTemplate.Height = 24;
            this.stockView.Size = new System.Drawing.Size(1279, 422);
            this.stockView.TabIndex = 0;
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(46, 42);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(305, 57);
            this.sortBtn.TabIndex = 4;
            this.sortBtn.Text = "Sort stock";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // sortNameBtn
            // 
            this.sortNameBtn.Location = new System.Drawing.Point(390, 42);
            this.sortNameBtn.Name = "sortNameBtn";
            this.sortNameBtn.Size = new System.Drawing.Size(305, 57);
            this.sortNameBtn.TabIndex = 5;
            this.sortNameBtn.Text = "Sort stock by Name";
            this.sortNameBtn.UseVisualStyleBackColor = true;
            this.sortNameBtn.Click += new System.EventHandler(this.sortNameBtn_Click);
            // 
            // MainDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 600);
            this.Controls.Add(this.sortNameBtn);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.stockView);
            this.Name = "MainDatabase";
            this.Text = "MainDatabase";
            ((System.ComponentModel.ISupportInitialize)(this.stockView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView stockView;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Button sortNameBtn;
    }
}
