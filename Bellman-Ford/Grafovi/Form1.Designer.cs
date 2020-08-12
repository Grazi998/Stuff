namespace Grafovi
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
            this.rtbIspis = new System.Windows.Forms.RichTextBox();
            this.btnDatoteka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbIspis
            // 
            this.rtbIspis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbIspis.Location = new System.Drawing.Point(25, 120);
            this.rtbIspis.Name = "rtbIspis";
            this.rtbIspis.Size = new System.Drawing.Size(593, 490);
            this.rtbIspis.TabIndex = 1;
            this.rtbIspis.Text = "";
            // 
            // btnDatoteka
            // 
            this.btnDatoteka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDatoteka.Location = new System.Drawing.Point(25, 31);
            this.btnDatoteka.Name = "btnDatoteka";
            this.btnDatoteka.Size = new System.Drawing.Size(120, 62);
            this.btnDatoteka.TabIndex = 2;
            this.btnDatoteka.Text = "Datoteka";
            this.btnDatoteka.UseVisualStyleBackColor = true;
            this.btnDatoteka.Click += new System.EventHandler(this.btnDatoteka_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 643);
            this.Controls.Add(this.btnDatoteka);
            this.Controls.Add(this.rtbIspis);
            this.Name = "Form1";
            this.Text = "Bellman Ford";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbIspis;
        private System.Windows.Forms.Button btnDatoteka;
    }
}

