
namespace StockProgram
{
    partial class Settings
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
            this.returnBtn = new System.Windows.Forms.Button();
            this.settingsLbl = new System.Windows.Forms.Label();
            this.colourGb = new System.Windows.Forms.GroupBox();
            this.blackBtn = new System.Windows.Forms.RadioButton();
            this.whiteBtn = new System.Windows.Forms.RadioButton();
            this.colourGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // returnBtn
            // 
            this.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBtn.ForeColor = System.Drawing.Color.White;
            this.returnBtn.Location = new System.Drawing.Point(371, 14);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(153, 54);
            this.returnBtn.TabIndex = 0;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // settingsLbl
            // 
            this.settingsLbl.AutoSize = true;
            this.settingsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLbl.ForeColor = System.Drawing.Color.White;
            this.settingsLbl.Location = new System.Drawing.Point(28, 29);
            this.settingsLbl.Name = "settingsLbl";
            this.settingsLbl.Size = new System.Drawing.Size(140, 39);
            this.settingsLbl.TabIndex = 2;
            this.settingsLbl.Text = "Settings";
            // 
            // colourGb
            // 
            this.colourGb.Controls.Add(this.whiteBtn);
            this.colourGb.Controls.Add(this.blackBtn);
            this.colourGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colourGb.ForeColor = System.Drawing.Color.White;
            this.colourGb.Location = new System.Drawing.Point(67, 119);
            this.colourGb.Name = "colourGb";
            this.colourGb.Size = new System.Drawing.Size(401, 151);
            this.colourGb.TabIndex = 3;
            this.colourGb.TabStop = false;
            this.colourGb.Text = "Colour theme";
            // 
            // blackBtn
            // 
            this.blackBtn.AutoSize = true;
            this.blackBtn.Location = new System.Drawing.Point(33, 48);
            this.blackBtn.Name = "blackBtn";
            this.blackBtn.Size = new System.Drawing.Size(167, 29);
            this.blackBtn.TabIndex = 2;
            this.blackBtn.TabStop = true;
            this.blackBtn.Text = "Black (Modern)";
            this.blackBtn.UseVisualStyleBackColor = true;
            this.blackBtn.CheckedChanged += new System.EventHandler(this.blackBtn_CheckedChanged);
            // 
            // whiteBtn
            // 
            this.whiteBtn.AutoSize = true;
            this.whiteBtn.Location = new System.Drawing.Point(33, 96);
            this.whiteBtn.Name = "whiteBtn";
            this.whiteBtn.Size = new System.Drawing.Size(170, 29);
            this.whiteBtn.TabIndex = 3;
            this.whiteBtn.TabStop = true;
            this.whiteBtn.Text = "White (Modern)";
            this.whiteBtn.UseVisualStyleBackColor = true;
            this.whiteBtn.CheckedChanged += new System.EventHandler(this.whiteBtn_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(536, 307);
            this.Controls.Add(this.colourGb);
            this.Controls.Add(this.settingsLbl);
            this.Controls.Add(this.returnBtn);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.colourGb.ResumeLayout(false);
            this.colourGb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Label settingsLbl;
        private System.Windows.Forms.GroupBox colourGb;
        private System.Windows.Forms.RadioButton whiteBtn;
        private System.Windows.Forms.RadioButton blackBtn;
    }
}