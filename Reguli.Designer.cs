namespace PROIECT_SCOALA
{
    partial class Reguli
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
            this.tbr1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbr1
            // 
            this.tbr1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbr1.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbr1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbr1.Location = new System.Drawing.Point(-46, 117);
            this.tbr1.Multiline = true;
            this.tbr1.Name = "tbr1";
            this.tbr1.Size = new System.Drawing.Size(418, 355);
            this.tbr1.TabIndex = 0;
            // 
            // Reguli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::PROIECT_SCOALA.Properties.Resources._103311_OLVQU3_673;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(595, 506);
            this.Controls.Add(this.tbr1);
            this.Name = "Reguli";
            this.Text = "Reguli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbr1;
    }
}