namespace Pujcovna_dronu
{
    partial class DronVypujcen
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
            this.btnObsazenAno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObsazenNe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnObsazenAno
            // 
            this.btnObsazenAno.Location = new System.Drawing.Point(52, 167);
            this.btnObsazenAno.Name = "btnObsazenAno";
            this.btnObsazenAno.Size = new System.Drawing.Size(86, 34);
            this.btnObsazenAno.TabIndex = 0;
            this.btnObsazenAno.Text = "Ano";
            this.btnObsazenAno.UseVisualStyleBackColor = true;
            this.btnObsazenAno.Click += new System.EventHandler(this.btnObsazenAno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(21, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dron je již vypůjčen. \r\nChcete při uvolnění informovat?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnObsazenNe
            // 
            this.btnObsazenNe.Location = new System.Drawing.Point(178, 167);
            this.btnObsazenNe.Name = "btnObsazenNe";
            this.btnObsazenNe.Size = new System.Drawing.Size(86, 34);
            this.btnObsazenNe.TabIndex = 3;
            this.btnObsazenNe.Text = "Ne";
            this.btnObsazenNe.UseVisualStyleBackColor = true;
            this.btnObsazenNe.Click += new System.EventHandler(this.btnObsazenNe_Click);
            // 
            // DronVypujcen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 248);
            this.Controls.Add(this.btnObsazenNe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObsazenAno);
            this.Name = "DronVypujcen";
            this.Text = "Dron vypujce";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObsazenAno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObsazenNe;
    }
}