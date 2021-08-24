
namespace Ikälaskuri
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
            this.SyntymaAikaDT = new System.Windows.Forms.DateTimePicker();
            this.VuosinaLB = new System.Windows.Forms.Label();
            this.KuukausinaLB = new System.Windows.Forms.Label();
            this.PaivinaLB = new System.Windows.Forms.Label();
            this.TunteinaLB = new System.Windows.Forms.Label();
            this.MinuutteinaLB = new System.Windows.Forms.Label();
            this.SekunteinaLB = new System.Windows.Forms.Label();
            this.LaskeBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SyntymaAikaDT
            // 
            this.SyntymaAikaDT.Location = new System.Drawing.Point(238, 93);
            this.SyntymaAikaDT.Name = "SyntymaAikaDT";
            this.SyntymaAikaDT.Size = new System.Drawing.Size(209, 23);
            this.SyntymaAikaDT.TabIndex = 0;
            this.SyntymaAikaDT.Value = new System.DateTime(1996, 5, 15, 0, 0, 0, 0);
            // 
            // VuosinaLB
            // 
            this.VuosinaLB.AutoSize = true;
            this.VuosinaLB.Location = new System.Drawing.Point(238, 137);
            this.VuosinaLB.Name = "VuosinaLB";
            this.VuosinaLB.Size = new System.Drawing.Size(41, 15);
            this.VuosinaLB.TabIndex = 1;
            this.VuosinaLB.Text = "vuotta";
            this.VuosinaLB.Visible = false;
            // 
            // KuukausinaLB
            // 
            this.KuukausinaLB.AutoSize = true;
            this.KuukausinaLB.Location = new System.Drawing.Point(238, 173);
            this.KuukausinaLB.Name = "KuukausinaLB";
            this.KuukausinaLB.Size = new System.Drawing.Size(60, 15);
            this.KuukausinaLB.TabIndex = 2;
            this.KuukausinaLB.Text = "kuukautta";
            this.KuukausinaLB.Visible = false;
            // 
            // PaivinaLB
            // 
            this.PaivinaLB.AutoSize = true;
            this.PaivinaLB.Location = new System.Drawing.Point(238, 208);
            this.PaivinaLB.Name = "PaivinaLB";
            this.PaivinaLB.Size = new System.Drawing.Size(41, 15);
            this.PaivinaLB.TabIndex = 3;
            this.PaivinaLB.Text = "päivää";
            this.PaivinaLB.Visible = false;
            // 
            // TunteinaLB
            // 
            this.TunteinaLB.AutoSize = true;
            this.TunteinaLB.Location = new System.Drawing.Point(381, 137);
            this.TunteinaLB.Name = "TunteinaLB";
            this.TunteinaLB.Size = new System.Drawing.Size(38, 15);
            this.TunteinaLB.TabIndex = 4;
            this.TunteinaLB.Text = "tuntia";
            this.TunteinaLB.Visible = false;
            // 
            // MinuutteinaLB
            // 
            this.MinuutteinaLB.AutoSize = true;
            this.MinuutteinaLB.Location = new System.Drawing.Point(381, 173);
            this.MinuutteinaLB.Name = "MinuutteinaLB";
            this.MinuutteinaLB.Size = new System.Drawing.Size(59, 15);
            this.MinuutteinaLB.TabIndex = 5;
            this.MinuutteinaLB.Text = "minuuttia";
            this.MinuutteinaLB.Visible = false;
            // 
            // SekunteinaLB
            // 
            this.SekunteinaLB.AutoSize = true;
            this.SekunteinaLB.Location = new System.Drawing.Point(381, 208);
            this.SekunteinaLB.Name = "SekunteinaLB";
            this.SekunteinaLB.Size = new System.Drawing.Size(51, 15);
            this.SekunteinaLB.TabIndex = 6;
            this.SekunteinaLB.Text = "sekuntia";
            this.SekunteinaLB.Visible = false;
            // 
            // LaskeBT
            // 
            this.LaskeBT.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LaskeBT.Location = new System.Drawing.Point(477, 79);
            this.LaskeBT.Name = "LaskeBT";
            this.LaskeBT.Size = new System.Drawing.Size(79, 47);
            this.LaskeBT.TabIndex = 7;
            this.LaskeBT.Text = "Laske";
            this.LaskeBT.UseVisualStyleBackColor = true;
            this.LaskeBT.Click += new System.EventHandler(this.LaskeBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LaskeBT);
            this.Controls.Add(this.SekunteinaLB);
            this.Controls.Add(this.MinuutteinaLB);
            this.Controls.Add(this.TunteinaLB);
            this.Controls.Add(this.PaivinaLB);
            this.Controls.Add(this.KuukausinaLB);
            this.Controls.Add(this.VuosinaLB);
            this.Controls.Add(this.SyntymaAikaDT);
            this.Name = "Form1";
            this.Text = "Ikälaskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker SyntymaAikaDT;
        private System.Windows.Forms.Label VuosinaLB;
        private System.Windows.Forms.Label KuukausinaLB;
        private System.Windows.Forms.Label PaivinaLB;
        private System.Windows.Forms.Label TunteinaLB;
        private System.Windows.Forms.Label MinuutteinaLB;
        private System.Windows.Forms.Label SekunteinaLB;
        private System.Windows.Forms.Button LaskeBT;
    }
}

