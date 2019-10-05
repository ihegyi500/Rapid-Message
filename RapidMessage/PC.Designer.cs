namespace RapidMessage
{
    partial class PC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PC));
            this.PCToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button_MobileReq
            // 
            this.button_MobileReq.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_MobileReq.FlatAppearance.BorderSize = 0;
            this.button_MobileReq.Image = ((System.Drawing.Image)(resources.GetObject("button_MobileReq.Image")));
            this.PCToolTip.SetToolTip(this.button_MobileReq, "Új PC/Laptop igénylés\r\nNew PC/laptop request\r\nНовий запит на ПК / ноутбук");
            // 
            // button_MobilIssue
            // 
            this.button_MobilIssue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_MobilIssue.FlatAppearance.BorderSize = 0;
            this.button_MobilIssue.Image = ((System.Drawing.Image)(resources.GetObject("button_MobilIssue.Image")));
            this.PCToolTip.SetToolTip(this.button_MobilIssue, "PC/Laptop probléma\r\nPC/laptop issue\r\nПитання для ПК / ноутбука");
            // 
            // Themebutton
            // 
            this.Themebutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Themebutton.FlatAppearance.BorderSize = 0;
            this.Themebutton.Image = ((System.Drawing.Image)(resources.GetObject("Themebutton.Image")));
            // 
            // Mainlabel
            // 
            this.Mainlabel.Size = new System.Drawing.Size(215, 19);
            this.Mainlabel.Text = "PC-vel/laptoppal kapcsolatos?";
            // 
            // PC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(289, 189);
            this.Name = "PC";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip PCToolTip;
    }
}
