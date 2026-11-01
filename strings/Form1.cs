using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace strings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            string stror = textBox4.Text;
            string res = stror;
            string str1 = textBox5.Text;
            string str2 = textBox6.Text;
            

            int sindex=0;
            while (true)
            {
                int index = res.IndexOf(str1, sindex);
                if (index == -1) break;
                res = res.Substring(0, index) + str2 + res.Substring(index + str1.Length);
                sindex = index + str2.Length;
            }
            textBox7.Text = res;

            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
