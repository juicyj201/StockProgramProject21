
using System;

namespace StockProgram.UserControls
{
    partial class StockTrackingView
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
            this.monthLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.monthCb = new System.Windows.Forms.ComboBox();
            this.reportText = new System.Windows.Forms.RichTextBox();
            this.yearCb = new System.Windows.Forms.ComboBox();
            this.yearLbl = new System.Windows.Forms.Label();
            this.monthlyReportBox = new System.Windows.Forms.GroupBox();
            this.genReportBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.monthlyReportBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthLbl
            // 
            this.monthLbl.AutoSize = true;
            this.monthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLbl.ForeColor = System.Drawing.Color.White;
            this.monthLbl.Location = new System.Drawing.Point(51, 200);
            this.monthLbl.Name = "monthLbl";
            this.monthLbl.Size = new System.Drawing.Size(201, 20);
            this.monthLbl.TabIndex = 4;
            this.monthLbl.Text = "Month for inventory report";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(65)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(630, 98);
            this.panel2.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(164, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(297, 48);
            this.label9.TabIndex = 19;
            this.label9.Text = "Stock Tracking";
            // 
            // monthCb
            // 
            this.monthCb.FormattingEnabled = true;
            this.monthCb.Location = new System.Drawing.Point(281, 196);
            this.monthCb.Name = "monthCb";
            this.monthCb.Size = new System.Drawing.Size(292, 24);
            this.monthCb.TabIndex = 23;
            this.monthCb.SelectedIndexChanged += new System.EventHandler(this.monthCb_SelectedIndexChanged);
            // 
            // reportText
            // 
            this.reportText.Location = new System.Drawing.Point(6, 38);
            this.reportText.Name = "reportText";
            this.reportText.Size = new System.Drawing.Size(506, 210);
            this.reportText.TabIndex = 24;
            this.reportText.Text = "";
            // 
            // yearCb
            // 
            this.yearCb.FormattingEnabled = true;
            this.yearCb.Location = new System.Drawing.Point(281, 142);
            this.yearCb.Name = "yearCb";
            this.yearCb.Size = new System.Drawing.Size(292, 24);
            this.yearCb.TabIndex = 26;
            this.yearCb.SelectedIndexChanged += new System.EventHandler(this.yearCb_SelectedIndexChanged);
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLbl.ForeColor = System.Drawing.Color.White;
            this.yearLbl.Location = new System.Drawing.Point(51, 146);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(189, 20);
            this.yearLbl.TabIndex = 25;
            this.yearLbl.Text = "Year for inventory report";
            // 
            // monthlyReportBox
            // 
            this.monthlyReportBox.Controls.Add(this.reportText);
            this.monthlyReportBox.ForeColor = System.Drawing.Color.White;
            this.monthlyReportBox.Location = new System.Drawing.Point(55, 315);
            this.monthlyReportBox.Name = "monthlyReportBox";
            this.monthlyReportBox.Size = new System.Drawing.Size(518, 254);
            this.monthlyReportBox.TabIndex = 27;
            this.monthlyReportBox.TabStop = false;
            this.monthlyReportBox.Text = "Monthly Report";
            // 
            // genReportBtn
            // 
            this.genReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.genReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.genReportBtn.ForeColor = System.Drawing.Color.White;
            this.genReportBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.genReportBtn.Location = new System.Drawing.Point(55, 251);
            this.genReportBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genReportBtn.Name = "genReportBtn";
            this.genReportBtn.Size = new System.Drawing.Size(518, 39);
            this.genReportBtn.TabIndex = 28;
            this.genReportBtn.Text = "Generate Monthly Report";
            this.genReportBtn.UseVisualStyleBackColor = false;
            this.genReportBtn.Click += new System.EventHandler(this.genReportBtn_Click);
            // 
            // StockTrackingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.genReportBtn);
            this.Controls.Add(this.monthlyReportBox);
            this.Controls.Add(this.yearCb);
            this.Controls.Add(this.yearLbl);
            this.Controls.Add(this.monthCb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.monthLbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StockTrackingView";
            this.Size = new System.Drawing.Size(620, 600);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.monthlyReportBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label monthLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox monthCb;
        private System.Windows.Forms.RichTextBox reportText;
        private System.Windows.Forms.ComboBox yearCb;
        private System.Windows.Forms.Label yearLbl;
        private System.Windows.Forms.GroupBox monthlyReportBox;
        private System.Windows.Forms.Button genReportBtn;
    }
}
