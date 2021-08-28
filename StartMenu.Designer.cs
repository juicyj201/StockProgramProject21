
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuLbl = new System.Windows.Forms.Label();
            this.maindatabaseBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.aboutUsBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuLbl);
            this.panel1.Location = new System.Drawing.Point(319, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 74);
            this.panel1.TabIndex = 0;
            // 
            // menuLbl
            // 
            this.menuLbl.AutoSize = true;
            this.menuLbl.Location = new System.Drawing.Point(22, 19);
            this.menuLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.menuLbl.Name = "menuLbl";
            this.menuLbl.Size = new System.Drawing.Size(78, 33);
            this.menuLbl.TabIndex = 0;
            this.menuLbl.Text = "Menu";
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
            // helpBtn
            // 
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.Location = new System.Drawing.Point(235, 217);
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
            this.exitBtn.Location = new System.Drawing.Point(235, 637);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(299, 57);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // aboutUsBtn
            // 
            this.aboutUsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutUsBtn.Location = new System.Drawing.Point(235, 302);
            this.aboutUsBtn.Name = "aboutUsBtn";
            this.aboutUsBtn.Size = new System.Drawing.Size(299, 57);
            this.aboutUsBtn.TabIndex = 8;
            this.aboutUsBtn.Text = "About Us";
            this.aboutUsBtn.UseVisualStyleBackColor = true;
            this.aboutUsBtn.Click += new System.EventHandler(this.aboutUsBtn_Click);
            // 
            // registerBtn
            // 
            //this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            //this.registerBtn.Location = new System.Drawing.Point(235, 468);
            //this.registerBtn.Name = "registerBtn";
            //this.registerBtn.Size = new System.Drawing.Size(299, 57);
            //this.registerBtn.TabIndex = 10;
            //this.registerBtn.Text = "Register";
            //this.registerBtn.UseVisualStyleBackColor = true;
            //this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // loginBtn
            // 
            //this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            //this.loginBtn.Location = new System.Drawing.Point(235, 553);
            //this.loginBtn.Name = "loginBtn";
            //this.loginBtn.Size = new System.Drawing.Size(299, 57);
            //this.loginBtn.TabIndex = 11;
            //this.loginBtn.Text = "Login";
            //this.loginBtn.UseVisualStyleBackColor = true;
            //this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.ControlBox = false;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.ControlBox = false;
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.aboutUsBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.maindatabaseBtn);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Yi Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 550);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "StartMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        System.Windows.Forms.Panel panel1;
        System.Windows.Forms.Label menuLbl;
        System.Windows.Forms.Button maindatabaseBtn;
        System.Windows.Forms.Button helpBtn;
        System.Windows.Forms.Button exitBtn;
        System.Windows.Forms.Button aboutUsBtn;
        System.Windows.Forms.Button settingsBtn;
        System.Windows.Forms.Button registerBtn;
        System.Windows.Forms.Button loginBtn;
    }
}