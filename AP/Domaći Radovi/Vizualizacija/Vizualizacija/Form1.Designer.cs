namespace Vizualizacija
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
            this.components = new System.ComponentModel.Container();
            this.btnCrtajTestni = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbCrtanje = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnBSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrtanje)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrtajTestni
            // 
            this.btnCrtajTestni.Location = new System.Drawing.Point(534, 20);
            this.btnCrtajTestni.Name = "btnCrtajTestni";
            this.btnCrtajTestni.Size = new System.Drawing.Size(136, 62);
            this.btnCrtajTestni.TabIndex = 0;
            this.btnCrtajTestni.Text = "Crtaj";
            this.btnCrtajTestni.UseVisualStyleBackColor = true;
            this.btnCrtajTestni.Click += new System.EventHandler(this.btnCrtajTestni_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbCrtanje
            // 
            this.pbCrtanje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCrtanje.BackColor = System.Drawing.Color.White;
            this.pbCrtanje.Location = new System.Drawing.Point(12, 88);
            this.pbCrtanje.Name = "pbCrtanje";
            this.pbCrtanje.Size = new System.Drawing.Size(684, 485);
            this.pbCrtanje.TabIndex = 1;
            this.pbCrtanje.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(392, 20);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(136, 62);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Merge Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnBSort
            // 
            this.btnBSort.Location = new System.Drawing.Point(250, 20);
            this.btnBSort.Name = "btnBSort";
            this.btnBSort.Size = new System.Drawing.Size(136, 62);
            this.btnBSort.TabIndex = 4;
            this.btnBSort.Text = "Bubble Sort";
            this.btnBSort.UseVisualStyleBackColor = true;
            this.btnBSort.Click += new System.EventHandler(this.btnBSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 592);
            this.Controls.Add(this.btnBSort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCrtanje);
            this.Controls.Add(this.btnCrtajTestni);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbCrtanje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrtajTestni;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbCrtanje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnBSort;
    }
}

