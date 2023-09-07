namespace Pujcovna_dronu
{
    partial class PotvrzeniNavratu
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
            this.btnAno = new System.Windows.Forms.Button();
            this.btnNe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAno
            // 
            this.btnAno.Location = new System.Drawing.Point(54, 118);
            this.btnAno.Name = "btnAno";
            this.btnAno.Size = new System.Drawing.Size(88, 33);
            this.btnAno.TabIndex = 0;
            this.btnAno.Text = "Ano";
            this.btnAno.UseVisualStyleBackColor = true;
            this.btnAno.Click += new System.EventHandler(this.btnAno_Click);
            // 
            // btnNe
            // 
            this.btnNe.Location = new System.Drawing.Point(197, 118);
            this.btnNe.Name = "btnNe";
            this.btnNe.Size = new System.Drawing.Size(88, 33);
            this.btnNe.TabIndex = 1;
            this.btnNe.Text = "Ne";
            this.btnNe.UseVisualStyleBackColor = true;
            this.btnNe.Click += new System.EventHandler(this.btnNe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Opravdu si přejete vrátit dron?";
            // 
            // PotvrzeniNavratu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 210);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNe);
            this.Controls.Add(this.btnAno);
            this.Name = "PotvrzeniNavratu";
            this.Text = "Opravdu vrátit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAno;
        private System.Windows.Forms.Button btnNe;
        private System.Windows.Forms.Label label1;
    }
}