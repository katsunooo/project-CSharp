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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Детская обувь", "Женская обувь", "Мужская обувь" });
            comboBox2.Items.AddRange(new string[] { "Кроссовки", "Сапоги", "Босоножки", "Туфли", "Ботинки" });
            comboBox3.Items.AddRange(new string[] { "Кожевенные традиции", "Модный силуэт", "Стиль и комфорт", "Топ-Топ", "Барбари" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 home;
            home = new Form1();
            home.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "entityDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.entityDataSet.Orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "entityDataSet.Products_import". При необходимости она может быть перемещена или удалена.
            this.products_importTableAdapter.Fill(this.entityDataSet.Products_import);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Model1 db = new Model1())
            {
                int serch = int.Parse(textBox1.Text);
                Orders o = db.Orders.FirstOrDefault(x => x.id == serch);
                if (o != null)
                {
                    label1.Text = "Заказ № " + o.num + "\nЗаказал пользователь:" + o.fio
                    + "\nКатегории: " + o.category
                    + "\nНазвание товара: " + o.name_tovar;
                }
                else
                {
                    label1.Text = "Такого заказа не существует";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Model1 db = new Model1())
            {
                Products_import obj = new Products_import();
                obj.category = comboBox1.Text;
                obj.podcategory = comboBox2.Text;
                obj.img = textBox4.Text;
                obj.name = textBox5.Text;
                obj.prod = comboBox3.Text;
                obj.descript = textBox7.Text;
                obj.sostav = textBox8.Text;
                obj.price = float.Parse(textBox9.Text);
                db.Products_import.Add(obj);
                db.SaveChanges();
            }

        }

        private void products_importBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.products_importBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.entityDataSet);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            if (ordersDataGridView.Visible == false)
            {
                ordersDataGridView.Visible = true;
                button4.Text = "Убрать";
            }
            else
            {
                ordersDataGridView.Visible = false;
                button4.Text = "Показать";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Model1 db = new Model1())
            {
                string serch = textBox1.Text;

                db.Database.ExecuteSqlCommand($"DELETE FROM dbo.Orders WHERE num={serch}");
                MessageBox.Show("Удалилось");
                db.SaveChanges();
                ordersDataGridView.DataSource = db.Orders.ToList();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RedForm red;
            red = new RedForm((textBoxr.Text));
            red.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}