namespace animacja_ukladu_slonecznego
{
    partial class SunSetSpace
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
            this.bs_ZegarUkladuSlonecznego = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bs_ZegarUkladuSlonecznego
            // 
            this.bs_ZegarUkladuSlonecznego.Enabled = true;
            this.bs_ZegarUkladuSlonecznego.Tick += new System.EventHandler(this.bs_ZegarUkladuSlonecznego_Tick);
            // 
            // PrzestrzenUkladuSlonecznego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 322);
            this.Name = "PrzestrzenUkladuSlonecznego";
            this.Text = "Animacja układu słonecznego";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PrzestrzenUkladuSlonecznego_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer bs_ZegarUkladuSlonecznego;
    }
}

