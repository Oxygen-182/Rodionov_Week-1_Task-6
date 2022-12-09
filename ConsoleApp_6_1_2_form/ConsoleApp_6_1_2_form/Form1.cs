using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp_6_1_2_form
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
                if (int.TryParse(textBox5.Text, out n) && n > 0)
                {
                }
                else
                {
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox3.Text += "Число n введено некорректно";
                    return;
                }

                int m;
                if (int.TryParse(textBox1.Text, out m) && m > 0)
                {
                }
                else
                {
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox3.Text += "Число m введено некорректно";
                    return;
                }

                string value = textBox2.Text;
                var sarrTest_ = value.Split(' ').Select(it => int.Parse(it)).ToArray();
                int [,] sarrTest = new int[n, m];
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
                textBox3.Text = STR;

                string RES = "";
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if ((i + j) % 2 == 0)
                            RES = RES + sarrTest[i, j] + " ";
                    }
                }
                textBox4.Text = RES;
            }
            catch (Exception ex)
            {
                textBox3.Clear();
                textBox4.Clear();
                textBox3.Text += ($"{ex.Message}\n\n");
            }
        }
    }
}
