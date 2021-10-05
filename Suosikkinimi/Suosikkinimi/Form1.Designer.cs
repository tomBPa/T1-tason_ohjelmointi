
namespace Suosikkinimi
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
            this.label1 = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.NimiTB = new System.Windows.Forms.TextBox();
            this.TarkistaTB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna nimesi, niin tarkastan, onko se 50 suosituimman joukossa:";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VastausLB.Location = new System.Drawing.Point(44, 71);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(76, 25);
            this.VastausLB.TabIndex = 1;
            this.VastausLB.Text = "Vastaus";
            // 
            // NimiTB
            // 
            this.NimiTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NimiTB.Location = new System.Drawing.Point(592, 23);
            this.NimiTB.Name = "NimiTB";
            this.NimiTB.Size = new System.Drawing.Size(159, 29);
            this.NimiTB.TabIndex = 2;
            // 
            // TarkistaTB
            // 
            this.TarkistaTB.Location = new System.Drawing.Point(635, 71);
            this.TarkistaTB.Name = "TarkistaTB";
            this.TarkistaTB.Size = new System.Drawing.Size(116, 42);
            this.TarkistaTB.TabIndex = 3;
            this.TarkistaTB.Text = "Tarkista";
            this.TarkistaTB.UseVisualStyleBackColor = true;
            this.TarkistaTB.Click += new System.EventHandler(this.TarkistaTB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 395);
            this.Controls.Add(this.TarkistaTB);
            this.Controls.Add(this.NimiTB);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.TextBox NimiTB;
        private System.Windows.Forms.Button TarkistaTB;
    }
}

