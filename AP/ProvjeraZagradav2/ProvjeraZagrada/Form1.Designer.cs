namespace ProvjeraZagrada
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
            this.btnProvjeri = new System.Windows.Forms.Button();
            this.txtUnos = new System.Windows.Forms.TextBox();
            this.lblUpute = new System.Windows.Forms.Label();
            this.rtbIspis = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnProvjeri
            // 
            this.btnProvjeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProvjeri.Location = new System.Drawing.Point(183, 80);
            this.btnProvjeri.Name = "btnProvjeri";
            this.btnProvjeri.Size = new System.Drawing.Size(111, 44);
            this.btnProvjeri.TabIndex = 0;
            this.btnProvjeri.Text = "Provjeri";
            this.btnProvjeri.UseVisualStyleBackColor = true;
            this.btnProvjeri.Click += new System.EventHandler(this.btnProvjeri_Click);
            // 
            // txtUnos
            // 
            this.txtUnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUnos.Location = new System.Drawing.Point(117, 39);
            this.txtUnos.Name = "txtUnos";
            this.txtUnos.Size = new System.Drawing.Size(238, 26);
            this.txtUnos.TabIndex = 1;
            // 
            // lblUpute
            // 
            this.lblUpute.AutoSize = true;
            this.lblUpute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUpute.Location = new System.Drawing.Point(93, 9);
            this.lblUpute.Name = "lblUpute";
            this.lblUpute.Size = new System.Drawing.Size(305, 20);
            this.lblUpute.TabIndex = 2;
            this.lblUpute.Text = "Unesi izraz sa zagradama (samo okrugle!)";
            // 
            // rtbIspis
            // 
            this.rtbIspis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbIspis.Location = new System.Drawing.Point(97, 160);
            this.rtbIspis.Name = "rtbIspis";
            this.rtbIspis.Size = new System.Drawing.Size(281, 173);
            this.rtbIspis.TabIndex = 3;
            this.rtbIspis.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 385);
            this.Controls.Add(this.rtbIspis);
            this.Controls.Add(this.lblUpute);
            this.Controls.Add(this.txtUnos);
            this.Controls.Add(this.btnProvjeri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProvjeri;
        private System.Windows.Forms.TextBox txtUnos;
        private System.Windows.Forms.Label lblUpute;
        private System.Windows.Forms.RichTextBox rtbIspis;
    }
}

