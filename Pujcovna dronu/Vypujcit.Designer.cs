namespace Pujcovna_dronu
{
    partial class Vypujcit
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
            this.VypucjCenaDen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.VypujcZaloha = new System.Windows.Forms.TextBox();
            this.VypujcDatumVypujcky = new System.Windows.Forms.TextBox();
            this.VypujcDron = new System.Windows.Forms.TextBox();
            this.VypujcZakJmeno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.VratBVypujcit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VypucjCenaDen
            // 
            this.VypucjCenaDen.Enabled = false;
            this.VypucjCenaDen.Location = new System.Drawing.Point(770, 110);
            this.VypucjCenaDen.Name = "VypucjCenaDen";
            this.VypucjCenaDen.ReadOnly = true;
            this.VypucjCenaDen.Size = new System.Drawing.Size(100, 22);
            this.VypucjCenaDen.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(597, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 61;
            this.label7.Text = "Cena za den";
            // 
            // VypujcZaloha
            // 
            this.VypujcZaloha.Enabled = false;
            this.VypujcZaloha.Location = new System.Drawing.Point(770, 72);
            this.VypujcZaloha.Name = "VypujcZaloha";
            this.VypujcZaloha.ReadOnly = true;
            this.VypujcZaloha.Size = new System.Drawing.Size(100, 22);
            this.VypujcZaloha.TabIndex = 59;
            // 
            // VypujcDatumVypujcky
            // 
            this.VypujcDatumVypujcky.Enabled = false;
            this.VypujcDatumVypujcky.Location = new System.Drawing.Point(770, 156);
            this.VypujcDatumVypujcky.Name = "VypujcDatumVypujcky";
            this.VypujcDatumVypujcky.ReadOnly = true;
            this.VypujcDatumVypujcky.Size = new System.Drawing.Size(100, 22);
            this.VypujcDatumVypujcky.TabIndex = 58;
            // 
            // VypujcDron
            // 
            this.VypujcDron.Enabled = false;
            this.VypujcDron.Location = new System.Drawing.Point(241, 151);
            this.VypujcDron.Name = "VypujcDron";
            this.VypujcDron.ReadOnly = true;
            this.VypujcDron.Size = new System.Drawing.Size(147, 22);
            this.VypujcDron.TabIndex = 57;
            // 
            // VypujcZakJmeno
            // 
            this.VypujcZakJmeno.Enabled = false;
            this.VypujcZakJmeno.Location = new System.Drawing.Point(241, 77);
            this.VypujcZakJmeno.Name = "VypujcZakJmeno";
            this.VypujcZakJmeno.ReadOnly = true;
            this.VypujcZakJmeno.Size = new System.Drawing.Size(147, 22);
            this.VypujcZakJmeno.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(596, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 54;
            this.label6.Text = "Datum vypůjčení";
            // 
            // VratBVypujcit
            // 
            this.VratBVypujcit.Location = new System.Drawing.Point(124, 229);
            this.VratBVypujcit.Name = "VratBVypujcit";
            this.VratBVypujcit.Size = new System.Drawing.Size(746, 36);
            this.VratBVypujcit.TabIndex = 52;
            this.VratBVypujcit.Text = "Vypujcit";
            this.VratBVypujcit.UseVisualStyleBackColor = true;
            this.VratBVypujcit.Click += new System.EventHandler(this.VratBVypujcit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "Záloha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "Dron";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Zákazník";
            // 
            // Vypujcit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 303);
            this.Controls.Add(this.VypucjCenaDen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.VypujcZaloha);
            this.Controls.Add(this.VypujcDatumVypujcky);
            this.Controls.Add(this.VypujcDron);
            this.Controls.Add(this.VypujcZakJmeno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.VratBVypujcit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "Vypujcit";
            this.Text = "Vypujcit";
            this.Load += new System.EventHandler(this.Vypujcit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox VypucjCenaDen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox VypujcZaloha;
        private System.Windows.Forms.TextBox VypujcDatumVypujcky;
        private System.Windows.Forms.TextBox VypujcDron;
        private System.Windows.Forms.TextBox VypujcZakJmeno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button VratBVypujcit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}