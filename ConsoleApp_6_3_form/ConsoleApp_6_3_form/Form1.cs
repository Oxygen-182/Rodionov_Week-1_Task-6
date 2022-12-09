using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp_6_3_form
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
                int n;
                if (int.TryParse(textBox1.Text, out n) && n > 0)
                {
                }
                else
                {
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox4.Text += "Число n введено некорректно";
                    return;
                }

                int m;
                if (int.TryParse(textBox2.Text, out m) && m > 0)
                {
                }
                else
                {
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox4.Text += "Число m введено некорректно";
                    return;
                }

                string value = textBox3.Text;
                var sarrTest_ = value.Split(' ').Select(it => int.Parse(it)).ToArray();
                int[,] sarrTest = new int[n, m];
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                    {
                        sarrTest[i, j] = sarrTest_[i * m + j];
                    }
                string strArr = string.Empty;

                string STR = "";
                for (int i = 0; i < sarrTest.GetLength(0); i++)
                {
                    for (int j = 0; j < sarrTest.GetLength(1); j++)
                    {
                        STR += sarrTest[i, j] + " ";
                    }
                    STR += Environment.NewLine;
                }
                textBox4.Text = STR;

                string RES = "";
                int max;
                for (int i = 0; i < sarrTest.GetLength(0); i++)
                {
                    max = int.MinValue;
                    for (int j = 0; j < sarrTest.GetLength(1); j++)
                    {
                        if (sarrTest[i, j] > max)
                        {
                            max = sarrTest[i, j];
                        }
                    }
                    for (int j = 0; j < sarrTest.GetLength(1); j++)
                    {
                        if (max == sarrTest[i, j])
                        {
                            sarrTest[i, j] = -sarrTest[i, j];
                            break;
                        }
                    }
                }
                for (int i = 0; i < sarrTest.GetLength(0); i++)
                {
                    for (int j = 0; j < sarrTest.GetLength(1); j++)
                    {
                        RES += sarrTest[i, j] + " ";
                    }
                    RES += Environment.NewLine;
                }
                textBox5.Text = RES;
            }
            catch (Exception ex)
            {
                textBox4.Clear();
                textBox5.Clear();
                textBox4.Text += ($"{ex.Message}\n\n");
            }
        }
    }
}
