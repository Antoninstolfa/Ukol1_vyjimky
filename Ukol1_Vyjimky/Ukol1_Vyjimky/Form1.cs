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
            listBox1.Items.Clear();
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
                        listBox1.Items.Add(cislo[i]);
                    }
                    int vysledek = Convert.ToInt32(Math.Pow(cislo[0], cislo[5]));
                    odpoved.Text = vysledek.ToString();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Gold;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.LawnGreen;
        }
    }
}
