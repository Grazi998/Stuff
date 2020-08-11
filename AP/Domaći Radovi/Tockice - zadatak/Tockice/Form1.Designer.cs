namespace Tockice
{
    partial class Form1
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
            this.pbCrtanje = new System.Windows.Forms.PictureBox();
            this.btnCrtaj = new System.Windows.Forms.Button();
            this.lblIspis = new System.Windows.Forms.Label();
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.Random = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrtanje)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCrtanje
            // 
            this.pbCrtanje.Location = new System.Drawing.Point(26, 48);
            this.pbCrtanje.Name = "pbCrtanje";
            this.pbCrtanje.Size = new System.Drawing.Size(867, 664);
            this.pbCrtanje.TabIndex = 0;
            this.pbCrtanje.TabStop = false;
            // 
            // btnCrtaj
            // 
            this.btnCrtaj.Location = new System.Drawing.Point(31, 3);
            this.btnCrtaj.Name = "btnCrtaj";
            this.btnCrtaj.Size = new System.Drawing.Size(107, 36);
            this.btnCrtaj.TabIndex = 1;
            this.btnCrtaj.Text = "Crtaj";
            this.btnCrtaj.UseVisualStyleBackColor = true;
            this.btnCrtaj.Click += new System.EventHandler(this.btnCrtaj_Click);
            // 
            // lblIspis
            // 
            this.lblIspis.AutoSize = true;
            this.lblIspis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIspis.Location = new System.Drawing.Point(370, 9);
            this.lblIspis.Name = "lblIspis";
            this.lblIspis.Size = new System.Drawing.Size(108, 24);
            this.lblIspis.TabIndex = 2;
            this.lblIspis.Text = "Udaljenost: ";
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(144, 3);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(107, 36);
            this.btnUcitaj.TabIndex = 3;
            this.btnUcitaj.Text = "Učitaj";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // Random
            // 
            this.Random.Location = new System.Drawing.Point(257, 3);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(107, 36);
            this.Random.TabIndex = 4;
            this.Random.Text = "Ucitaj Random";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.Click += new System.EventHandler(this.Random_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 733);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.btnUcitaj);
            this.Controls.Add(this.lblIspis);
            this.Controls.Add(this.btnCrtaj);
            this.Controls.Add(this.pbCrtanje);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbCrtanje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCrtanje;
        private System.Windows.Forms.Button btnCrtaj;
        private System.Windows.Forms.Label lblIspis;
        private System.Windows.Forms.Button btnUcitaj;
        private System.Windows.Forms.Button Random;
    }
}

