
namespace StockProgram.UserControls
{
    partial class HelpView
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
            this.HelpPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // HelpPanel
            // 
            this.HelpPanel.Location = new System.Drawing.Point(28, 20);
            this.HelpPanel.Name = "HelpPanel";
            this.HelpPanel.Size = new System.Drawing.Size(549, 355);
            this.HelpPanel.TabIndex = 0;
            // 
            // HelpView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HelpPanel);
            this.Name = "HelpView";
            this.Size = new System.Drawing.Size(616, 406);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HelpPanel;
    }
}
