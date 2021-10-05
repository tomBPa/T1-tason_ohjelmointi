
namespace Paivakirja
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
            this.syottoTB = new System.Windows.Forms.TextBox();
            this.TallennaTB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // syottoTB
            // 
            this.syottoTB.Location = new System.Drawing.Point(55, 12);
            this.syottoTB.Multiline = true;
            this.syottoTB.Name = "syottoTB";
            this.syottoTB.Size = new System.Drawing.Size(789, 245);
            this.syottoTB.TabIndex = 0;
            // 
            // TallennaTB
            // 
            this.TallennaTB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TallennaTB.Location = new System.Drawing.Point(55, 263);
            this.TallennaTB.Name = "TallennaTB";
            this.TallennaTB.Size = new System.Drawing.Size(789, 114);
            this.TallennaTB.TabIndex = 1;
            this.TallennaTB.Text = "Tallenna päiväkirjaan";
            this.TallennaTB.UseVisualStyleBackColor = true;
            this.TallennaTB.Click += new System.EventHandler(this.TallennaTB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 408);
            this.Controls.Add(this.TallennaTB);
            this.Controls.Add(this.syottoTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox syottoTB;
        private System.Windows.Forms.Button TallennaTB;
    }
}

