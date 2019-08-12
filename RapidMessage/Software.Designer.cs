namespace RapidMessage
{
    partial class Software
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
            this.SWToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button_MobileReq
            // 
            this.button_MobileReq.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_MobileReq.FlatAppearance.BorderSize = 0;
            this.SWToolTip.SetToolTip(this.button_MobileReq, "Új szoftver igénylés\r\nNew software request\r\nНовий запит програмного забезпечення");
            // 
            // button_MobilIssue
            // 
            this.button_MobilIssue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_MobilIssue.FlatAppearance.BorderSize = 0;
            this.SWToolTip.SetToolTip(this.button_MobilIssue, "Szoftver probléma\r\nSoftware issue\r\nПроблема програмного забезпечення");
            // 
            // Themebutton
            // 
            this.Themebutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Themebutton.FlatAppearance.BorderSize = 0;
            // 
            // Software
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(290, 189);
            this.Name = "Software";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip SWToolTip;
    }
}
