using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            using (Model1 db = new Model1())
            {
                var list = db.Products_import.Select(p => p.name).ToArray();
                comboBox1.Items.AddRange(list);
              

                
            }
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 home;
            home = new Form1();
            home.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            using (Model1 db = new Model1())
            {
                string comb = comboBox1.Text;
                Products_import p = db.Products_import.FirstOrDefault(x => x.name == comb );
                
                Orders obj = new Orders();
                Products_import prod = new Products_import();
                obj.date_order = DateTime.Now;
                obj.fio = textBox1.Text;
                obj.category = p.category;
                obj.name_tovar = comboBox1.Text;
                obj.proizv = p.prod;
                obj.price = (int)p.price;
                obj.countt = (int)numericUpDown1.Value;
                obj.size = int.Parse(comboBox2.Text);
                obj.num = (int)numericUpDown2.Value;

                
               



                
                db.Orders.Add(obj);
                db.SaveChanges();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void R_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox2.Text, out int orderNum)) return;

            using(Model1 db = new Model1())
            {
                decimal sumTotal = db.Orders
                    .Where(o => o.num == orderNum)
                    .Sum(o => (decimal)o.price * (decimal)o.countt);
                label3.Text = sumTotal.ToString();

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Model1 db = new Model1())
            {


                Products_import pi = db.Products_import.FirstOrDefault(x => x.name == comboBox1.Text);
                if (pi != null)
                {
                    label7.Text = "Производитель " + pi.prod
                    + "\nКатегория: " + pi.category
                    + "\nПодкатегория: " + pi.podcategory
                    + "\nЦена: " + pi.price;
                }

            }
        }
    }
}
