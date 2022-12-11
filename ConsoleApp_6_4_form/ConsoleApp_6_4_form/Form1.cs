using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ConsoleApp_6_4_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int F(int[] a)
        {
            int el = 0;
            for (int i = 1; i < a.GetLength(0); i++)
            {
                if (a[i - 1] != a[i])
                {
                    el = i;
                    break;
                }
            }
            return el;
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
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox3.Text += "Число n введено некорректно";
                    return;
                }

                string value = textBox2.Text;
                var sarrTest_ = value.Split(' ').Select(it => int.Parse(it)).ToArray();
                int[][] sarrTest = new int[n][];

                int k = 0;
                for (int i = 0; i < n; i++)
                {
                    sarrTest[i] = new int[n];
                    for (int j = 0; j < n; j++)
                    {
                        sarrTest[i][j] = sarrTest_[k];
                        k++;
                    }
                }
                string strArr = string.Empty;

                string STR = "";
                for (int i = 0; i < sarrTest.GetLength(0); i++)
                {
                    for (int j = 0; j < sarrTest.GetLength(0); j++)
                    {
                        STR += sarrTest[i][j] + " ";
                    }
                    STR += Environment.NewLine;
                }
                textBox3.Text = STR;

                int[] rez = new int[n];

                for (int i = 0; i < sarrTest.Length; ++i)
                    rez[i] = F(sarrTest[i]);

                string RES = "";

                for (int i = 0; i < rez.Length; i++)
                {
                    RES += rez[i] + " ";
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
