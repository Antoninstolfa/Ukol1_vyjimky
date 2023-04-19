using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukol1_Vyjimky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Random rng = new Random();
                int n = Convert.ToInt32(numericUpDown1.Value);
                int[] cislo = new int[n];
                if (n < 6)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        cislo[i] = rng.Next(1, 20);
                    }
                    int N = cislo[5];
                    int vysledek = cislo[0];
                    while (N != 0)
                    {
                        vysledek *= N;
                        N--;
                    }
                    label2.Text = vysledek.ToString();
                }
            }
            catch(OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
