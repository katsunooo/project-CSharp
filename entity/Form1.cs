using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "entityDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.entityDataSet.users);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Model1 db = new Model1())
            {
                user userObj = new user();
                userObj.login = textBox1.Text;
                userObj.roleid = 2;
                userObj.password = textBox2.Text;
                db.users.Add(userObj);
                db.SaveChanges();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Model1 db = new Model1())
            {
                user userObj = db.users.FirstOrDefault(user => user.login.Equals(textBox1.Text) && user.password.Equals(textBox2.Text));
                if (userObj != null)
                {
                    MessageBox.Show(userObj.login);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Model1 db = new Model1())
            {
                user userObj = db.users.FirstOrDefault(user => user.login.Equals(textBox1.Text) && user.password.Equals(textBox2.Text));
                if (userObj != null)
                {
                    db.users.Remove(userObj);
                }
                db.SaveChanges();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Model1 db = new Model1())
            {
                user user = db.users.FirstOrDefault(p => p.login == textBox1.Text && p.password == textBox2.Text);
                if (user != null)
                {
                    user.password = textBox3.Text;
                }
                db.SaveChanges();

            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Model1 db = new Model1())
            {
                dataGridView1.DataSource = db.users.ToList();
            }
                
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.entityDataSet);

        }

        private void usersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
