using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string[][][] Facult = new string[][][]{
                new string[][]{new string[] {"1ис","2ис","3ис"}},
                new string[][]{new string[] {"1э", "2э", "3э"}},
                new string[][]{new string[] {"1иир", "2иир", "3иир","4иир" } }
            };
        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label1.Text = "";
            int count=0;
                for (int j = 0; j < Facult[0].Length; j++)
                {
                    for (int k = 0; k < Facult[0][j].Length; k++)
                    {
                        label1.Text += Facult[0][j][k]+"\n";
                        count += 1;
                    }
            }
            label2.Text = "" + count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label1.Text = "";
            int count = 0;
            for (int j = 0; j < Facult[1].Length; j++)
            {
                for (int k = 0; k < Facult[1][j].Length; k++)
                {
                    label1.Text += Facult[1][j][k] + "\n";
                    count += 1;
                }
            }
            label2.Text = "" + count;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label1.Text = "";
            int count = 0;
            for (int j = 0; j < Facult[2].Length; j++)
            {
                for (int k = 0; k < Facult[2][j].Length; k++)
                {
                    label1.Text += Facult[2][j][k] + "\n";
                    count += 1;
                }
            }
            label2.Text = "" + count;
        }
    }
}
