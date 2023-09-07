namespace Pujcovna_dronu
{
    partial class Menu
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
            this.BZobrazObsluhu = new System.Windows.Forms.Button();
            this.BZobrazZakazniky = new System.Windows.Forms.Button();
            this.BZobrazVypujcky = new System.Windows.Forms.Button();
            this.BZobrazDrony = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BZobrazObsluhu
            // 
            this.BZobrazObsluhu.Location = new System.Drawing.Point(69, 215);
            this.BZobrazObsluhu.Name = "BZobrazObsluhu";
            this.BZobrazObsluhu.Size = new System.Drawing.Size(280, 48);
            this.BZobrazObsluhu.TabIndex = 10;
            this.BZobrazObsluhu.Text = "Zobrazit pracovníky obsluhy";
            this.BZobrazObsluhu.UseVisualStyleBackColor = true;
            this.BZobrazObsluhu.Click += new System.EventHandler(this.BZobrazObsluhu_Click);
            // 
            // BZobrazZakazniky
            // 
            this.BZobrazZakazniky.Location = new System.Drawing.Point(69, 169);
            this.BZobrazZakazniky.Name = "BZobrazZakazniky";
            this.BZobrazZakazniky.Size = new System.Drawing.Size(280, 40);
            this.BZobrazZakazniky.TabIndex = 9;
            this.BZobrazZakazniky.Text = "Zobrazit zakazníky";
            this.BZobrazZakazniky.UseVisualStyleBackColor = true;
            this.BZobrazZakazniky.Click += new System.EventHandler(this.BZobrazZakazniky_Click);
            // 
            // BZobrazVypujcky
            // 
            this.BZobrazVypujcky.Location = new System.Drawing.Point(69, 121);
            this.BZobrazVypujcky.Name = "BZobrazVypujcky";
            this.BZobrazVypujcky.Size = new System.Drawing.Size(280, 42);
            this.BZobrazVypujcky.TabIndex = 8;
            this.BZobrazVypujcky.Text = "Zobrazit vypujčky";
            this.BZobrazVypujcky.UseVisualStyleBackColor = true;
            this.BZobrazVypujcky.Click += new System.EventHandler(this.BZobrazVypujcky_Click);
            // 
            // BZobrazDrony
            // 
            this.BZobrazDrony.Location = new System.Drawing.Point(69, 71);
            this.BZobrazDrony.Name = "BZobrazDrony";
            this.BZobrazDrony.Size = new System.Drawing.Size(280, 44);
            this.BZobrazDrony.TabIndex = 6;
            this.BZobrazDrony.Text = "Zobrazit drony";
            this.BZobrazDrony.UseVisualStyleBackColor = true;
            this.BZobrazDrony.Click += new System.EventHandler(this.BZobrazDrony_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 351);
            this.Controls.Add(this.BZobrazObsluhu);
            this.Controls.Add(this.BZobrazZakazniky);
            this.Controls.Add(this.BZobrazVypujcky);
            this.Controls.Add(this.BZobrazDrony);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BZobrazObsluhu;
        private System.Windows.Forms.Button BZobrazZakazniky;
        private System.Windows.Forms.Button BZobrazVypujcky;
        private System.Windows.Forms.Button BZobrazDrony;
    }
}