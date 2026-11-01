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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox1.Text == ""))
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }

            
            try
            {
                 Model1 db = new Model1();

                
                users u = db.users.FirstOrDefault(x => x.login == textBox1.Text && x.password == textBox2.Text);
                if (u != null)
                {
                     
                    switch (u.roleid)
                    {
                        case 1: MessageBox.Show("Вы вошли как Администратор"); label1.Text = "Администратор";
                            Form2 f;
                            f = new Form2();
                            f.Show();
                            this.Hide();

                            break;
                        case 2: MessageBox.Show("Вы вошли как Пользователь"); label1.Text = "Пользователь" ;
                            Form3 f2;
                            f2 = new Form3();
                            f2.Show();
                            this.Hide();
                            break;
                        case 1002:
                            MessageBox.Show("Вы вошли как Менеджер"); label1.Text = "Менеджер";
                            Form4 f3;
                            f3 = new Form4();
                            f3.Show();
                            this.Hide();
                            break;
                    }
                    label2.Text = u.name;
                    label3.Text = u.last_name;

                }
                else
                {
                    MessageBox.Show("Неверный логин/пароль");
                    return;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Произошла ошибка: \n" + err.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
