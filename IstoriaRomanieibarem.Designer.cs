﻿namespace PROIECT_SCOALA
{
    partial class IstoriaRomanieibarem
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
            this.btbarem1 = new System.Windows.Forms.Button();
            this.tbbarem2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btbarem1);
            this.panel1.Controls.Add(this.tbbarem2);
            this.panel1.Location = new System.Drawing.Point(175, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 386);
            this.panel1.TabIndex = 1;
            // 
            // btbarem1
            // 
            this.btbarem1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btbarem1.AutoSize = true;
            this.btbarem1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btbarem1.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbarem1.ForeColor = System.Drawing.Color.Blue;
            this.btbarem1.Location = new System.Drawing.Point(189, 16);
            this.btbarem1.Name = "btbarem1";
            this.btbarem1.Size = new System.Drawing.Size(217, 41);
            this.btbarem1.TabIndex = 1;
            this.btbarem1.Text = "Descarca baremul ";
            this.btbarem1.UseVisualStyleBackColor = false;
            this.btbarem1.Click += new System.EventHandler(this.btbarem1_Click);
            // 
            // tbbarem2
            // 
            this.tbbarem2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbbarem2.Font = new System.Drawing.Font("Bernard MT Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbbarem2.Location = new System.Drawing.Point(1, -1);
            this.tbbarem2.Multiline = true;
            this.tbbarem2.Name = "tbbarem2";
            this.tbbarem2.Size = new System.Drawing.Size(418, 384);
            this.tbbarem2.TabIndex = 0;
            // 
            // IstoriaRomanieibarem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROIECT_SCOALA.Properties.Resources.fundP1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(763, 378);
            this.Controls.Add(this.panel1);
            this.Name = "IstoriaRomanieibarem";
            this.Text = "Istoria Romaniei - Barem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btbarem1;
        private System.Windows.Forms.TextBox tbbarem2;
    }
}