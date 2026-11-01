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
    public partial class RedForm : Form
    {
        public string rec;
        public RedForm(string id)
        {
            InitializeComponent();

            rec = id;
            using (Model1 db = new Model1())
            {
                int f = int.Parse(rec);
                Orders o = db.Orders.FirstOrDefault(x => x.id == f);
                if (o != null)
                {
                    textBox1.Text = o.fio;
                    textBox2.Text = o.category;
                    textBox3.Text = o.name_tovar;
                    textBox4.Text = o.proizv;
                    textBox5.Text = o.size.ToString();
                    textBox6.Text = o.countt.ToString();
                    textBox7.Text = o.price.ToString();
                }
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (Model1 db = new Model1())
            {
                int v = int.Parse(textBox5.Text);
                int b = int.Parse(textBox6.Text);
                int n=int.Parse(textBox7.Text);

                int f = int.Parse(rec);
                db.Database.ExecuteSqlCommand("UPDATE Orders SET fio={0},category={1},name_tovar={2},proizv={3},size = {4},countt = {5},price = {6} WHERE id={7}", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,v, b, n,f);
                MessageBox.Show("Успех");
               
           
            }
        }
    }
}