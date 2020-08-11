namespace Heap02
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbtHeap = new System.Windows.Forms.RadioButton();
            this.rbtBubble = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(44, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(355, 213);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbtHeap
            // 
            this.rbtHeap.AutoSize = true;
            this.rbtHeap.Checked = true;
            this.rbtHeap.Location = new System.Drawing.Point(150, 279);
            this.rbtHeap.Name = "rbtHeap";
            this.rbtHeap.Size = new System.Drawing.Size(71, 17);
            this.rbtHeap.TabIndex = 2;
            this.rbtHeap.TabStop = true;
            this.rbtHeap.Text = "Heap sort";
            this.rbtHeap.UseVisualStyleBackColor = true;
            // 
            // rbtBubble
            // 
            this.rbtBubble.AutoSize = true;
            this.rbtBubble.Location = new System.Drawing.Point(150, 316);
            this.rbtBubble.Name = "rbtBubble";
            this.rbtBubble.Size = new System.Drawing.Size(78, 17);
            this.rbtBubble.TabIndex = 3;
            this.rbtBubble.Text = "Bubble sort";
            this.rbtBubble.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(289, 298);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Broj slučajnih";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 55);
            this.button2.TabIndex = 6;
            this.button2.Text = "Napravi heap";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(289, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 42);
            this.button3.TabIndex = 7;
            this.button3.Text = "Napuni niz";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 534);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rbtBubble);
            this.Controls.Add(this.rbtHeap);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbtHeap;
        private System.Windows.Forms.RadioButton rbtBubble;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

