﻿
namespace Harjoitus_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.TulostusLB = new System.Windows.Forms.Label();
            this.ViestiTB = new System.Windows.Forms.TextBox();
            this.TulostaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OtsikkoLB.Location = new System.Drawing.Point(333, 175);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(282, 33);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Anna tulostettava teksti";
            // 
            // TulostusLB
            // 
            this.TulostusLB.AutoSize = true;
            this.TulostusLB.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TulostusLB.Location = new System.Drawing.Point(333, 227);
            this.TulostusLB.Name = "TulostusLB";
            this.TulostusLB.Size = new System.Drawing.Size(72, 33);
            this.TulostusLB.TabIndex = 1;
            this.TulostusLB.Text = "xxxx";
            this.TulostusLB.Visible = false;
            // 
            // ViestiTB
            // 
            this.ViestiTB.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViestiTB.Location = new System.Drawing.Point(621, 175);
            this.ViestiTB.Name = "ViestiTB";
            this.ViestiTB.Size = new System.Drawing.Size(591, 41);
            this.ViestiTB.TabIndex = 2;
            // 
            // TulostaBT
            // 
            this.TulostaBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TulostaBT.Location = new System.Drawing.Point(1095, 230);
            this.TulostaBT.Name = "TulostaBT";
            this.TulostaBT.Size = new System.Drawing.Size(117, 31);
            this.TulostaBT.TabIndex = 3;
            this.TulostaBT.Text = "Tulosta teksti";
            this.TulostaBT.UseVisualStyleBackColor = true;
            this.TulostaBT.Click += new System.EventHandler(this.TulostaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1289, 642);
            this.Controls.Add(this.TulostaBT);
            this.Controls.Add(this.ViestiTB);
            this.Controls.Add(this.TulostusLB);
            this.Controls.Add(this.OtsikkoLB);
            this.ForeColor = System.Drawing.Color.MintCream;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OtsikkoLB;
        private System.Windows.Forms.Label TulostusLB;
        private System.Windows.Forms.TextBox ViestiTB;
        private System.Windows.Forms.Button TulostaBT;
    }
}

