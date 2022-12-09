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

namespace ConsoleApp_6_1_1_form
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
                var sarrTest = value.Split(' ').Select(it => int.Parse(it)).ToArray();
                string strArr = string.Empty;
                foreach (var substring in sarrTest)
                    strArr = strArr + substring + " ";

                textBox3.Text = strArr;

                string RES = "";
                for (int i = 0; i < sarrTest.Length; i += 2)
                {
                    RES = RES + sarrTest[i] + " ";
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
