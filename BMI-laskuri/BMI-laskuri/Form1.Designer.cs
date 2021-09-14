
namespace BMI_laskuri
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
            this.label2 = new System.Windows.Forms.Label();
            this.painoTB = new System.Windows.Forms.TextBox();
            this.pituusTB = new System.Windows.Forms.TextBox();
            this.BMIBT = new System.Windows.Forms.Button();
            this.BmiLB = new System.Windows.Forms.Label();
            this.KuvausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(120, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna paino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(120, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anna pituus:";
            // 
            // painoTB
            // 
            this.painoTB.Location = new System.Drawing.Point(278, 51);
            this.painoTB.Name = "painoTB";
            this.painoTB.Size = new System.Drawing.Size(100, 23);
            this.painoTB.TabIndex = 2;
            // 
            // pituusTB
            // 
            this.pituusTB.Location = new System.Drawing.Point(278, 91);
            this.pituusTB.Name = "pituusTB";
            this.pituusTB.Size = new System.Drawing.Size(100, 23);
            this.pituusTB.TabIndex = 3;
            // 
            // BMIBT
            // 
            this.BMIBT.Location = new System.Drawing.Point(152, 139);
            this.BMIBT.Name = "BMIBT";
            this.BMIBT.Size = new System.Drawing.Size(194, 23);
            this.BMIBT.TabIndex = 4;
            this.BMIBT.Text = "Laske painoindeksi";
            this.BMIBT.UseVisualStyleBackColor = true;
            this.BMIBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // BmiLB
            // 
            this.BmiLB.AutoSize = true;
            this.BmiLB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BmiLB.Location = new System.Drawing.Point(191, 186);
            this.BmiLB.Name = "BmiLB";
            this.BmiLB.Size = new System.Drawing.Size(83, 30);
            this.BmiLB.TabIndex = 5;
            this.BmiLB.Text = "Vastaus";
            this.BmiLB.Visible = false;
            // 
            // KuvausLB
            // 
            this.KuvausLB.AutoSize = true;
            this.KuvausLB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KuvausLB.Location = new System.Drawing.Point(191, 221);
            this.KuvausLB.Name = "KuvausLB";
            this.KuvausLB.Size = new System.Drawing.Size(83, 30);
            this.KuvausLB.TabIndex = 6;
            this.KuvausLB.Text = "Vastaus";
            this.KuvausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KuvausLB);
            this.Controls.Add(this.BmiLB);
            this.Controls.Add(this.BMIBT);
            this.Controls.Add(this.pituusTB);
            this.Controls.Add(this.painoTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox painoTB;
        private System.Windows.Forms.TextBox pituusTB;
        private System.Windows.Forms.Button BMIBT;
        private System.Windows.Forms.Label BmiLB;
        private System.Windows.Forms.Label KuvausLB;
    }
}

