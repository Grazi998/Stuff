using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Heap02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] A;

        private void button1_Click(object sender, EventArgs e)
        {
            if (A == null) 
                return;
            HeapKlasa h = new HeapKlasa();

            if (rbtBubble.Checked)
                h.Bubble(A);
            else
            {
                h.NapraviHeap(A);
                h.Heap_Sort(A);
            }

            MessageBox.Show("Gotovo!");
            if (A.Length > 10000)
                richTextBox1.Text = "Sortirano... Niz je prevelik za ispis...";
            else
            {
                richTextBox1.Text += "\nSortirano:\n";
                Ispis(A);
            }
        }

        private void Ispis(int[] A)
        {
            foreach (int i in A)
                richTextBox1.AppendText(i + ", ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (A == null)
                return;

            HeapKlasa h = new HeapKlasa();

            h.NapraviHeap(A);

            if (A.Length > 10000)
                richTextBox1.Text = "Niz je prevelik za ispis...";
            else
            {
                richTextBox1.Text += "\nHeap: ";
                Ispis(A);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            int n;

            try { n = int.Parse(textBox1.Text); }
            catch { return; }

            A = new int[n];

            for (int i = 0; i < n; i++)
                A[i] = r.Next(1, 1000);
            if (A.Length > 10000)
                richTextBox1.Text = "Gotovo... Niz je prevelik za ispis...";
            else
            {
                richTextBox1.Text = "Niz:\n";
                Ispis(A);
            }
        }
    }
}
