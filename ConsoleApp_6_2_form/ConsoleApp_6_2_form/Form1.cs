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

namespace ConsoleApp_6_2_form
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
                string value = textBox2.Text;
                var sarrTest = value.Split(' ').Select(it => double.Parse(it)).ToArray();
                string strArr = string.Empty;
                foreach (var substring in sarrTest)
                    strArr = strArr + substring + " ";

                textBox3.Text = strArr;

                double RES = 0;
                for (int i = 1; i < sarrTest.Length; i++)
                {
                    if (sarrTest[i - 1] % sarrTest[i] == 0)
                        RES++;
                }
                textBox4.Text = $"{RES}";
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
