using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Trazilica t;
        private void button1_Click(object sender, EventArgs e)
        {
            string tekst = "AABAACAADAABAABA";
            rtbTekst.Text = tekst;
            
        }
        List<int> rijesenje= new List<int>();
        private void button2_Click(object sender, EventArgs e)
        {
            lblIspis.Text = "";
            rijesenje.Clear();
            rtbTekst.Select(0, rtbTekst.Text.Length);
            rtbTekst.SelectionColor = Color.Black;
            t = new Trazilica(rtbTekst.Text,txtUzorak.Text);
            rijesenje = t.Pronadi();
            foreach(int i in rijesenje)
            {
                
                rtbTekst.Select(i, txtUzorak.Text.Length);
                rtbTekst.SelectionColor = Color.Red;
                lblIspis.Text += i.ToString() + " ";
            }
            
        }
    }
}
