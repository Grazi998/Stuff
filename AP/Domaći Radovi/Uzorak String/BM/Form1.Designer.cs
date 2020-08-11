namespace BM
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
            this.txtUzorak = new System.Windows.Forms.TextBox();
            this.rtbTekst = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblIspis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUzorak
            // 
            this.txtUzorak.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUzorak.Location = new System.Drawing.Point(80, 35);
            this.txtUzorak.Name = "txtUzorak";
            this.txtUzorak.Size = new System.Drawing.Size(244, 29);
            this.txtUzorak.TabIndex = 0;
            this.txtUzorak.Text = "AABA";
            // 
            // rtbTekst
            // 
            this.rtbTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbTekst.Location = new System.Drawing.Point(78, 105);
            this.rtbTekst.Name = "rtbTekst";
            this.rtbTekst.Size = new System.Drawing.Size(733, 476);
            this.rtbTekst.TabIndex = 1;
            this.rtbTekst.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(433, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "Učitaj tekst";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(558, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 62);
            this.button2.TabIndex = 3;
            this.button2.Text = "Traži";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblIspis
            // 
            this.lblIspis.AutoSize = true;
            this.lblIspis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIspis.Location = new System.Drawing.Point(79, 600);
            this.lblIspis.Name = "lblIspis";
            this.lblIspis.Size = new System.Drawing.Size(80, 24);
            this.lblIspis.TabIndex = 4;
            this.lblIspis.Text = "Pozicije:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 771);
            this.Controls.Add(this.lblIspis);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbTekst);
            this.Controls.Add(this.txtUzorak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUzorak;
        private System.Windows.Forms.RichTextBox rtbTekst;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblIspis;
    }
}

