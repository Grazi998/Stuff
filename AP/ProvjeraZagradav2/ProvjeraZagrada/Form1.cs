using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvjeraZagrada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProvjeri_Click(object sender, EventArgs e)
        {
            if (txtUnos.Text == "")
            {
                rtbIspis.Text = "Niste nista upisali!";
                return;
            }

            string unos = txtUnos.Text;

            Stack<char> otvorene = new Stack<char>();
            bool zatvoreneOk = true;
            bool otvoreneOk = true;
            foreach (char z in unos)
            {
                if (z == '(')
                    otvorene.Push(z);
                if (z == ')')
                {
                    if (otvorene.Count > 0)
                        otvorene.Pop();
                    else
                    {
                        //ako je više zatvorenih
                        zatvoreneOk = false;
                        break;
                    }
                }
            }
            //ako je ostalo otvorenih
            if (otvorene.Count > 0)
            {
                otvoreneOk = false;
            }

            if (otvoreneOk && zatvoreneOk)
            {
                rtbIspis.Text = "Zagrade su ispravno napisane!";
            }
            else
            {
                rtbIspis.Text = "Zagrade nisu ispravno napisane!";
                if (!zatvoreneOk)
                {
                    rtbIspis.AppendText("\nProblem je u zatvorenim!");
                }
                else
                {
                    rtbIspis.AppendText("\nProblem je u otvorenim!");
                }
            }
            

        }//btnProvjeri
    }
}
