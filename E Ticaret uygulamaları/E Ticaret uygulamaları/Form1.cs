using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Ticaret_uygulamaları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox2.Text == "123")
            {
                MessageBox.Show("Giriş Başarılı");
                this.Hide();
                Form3 ynform = new Form3();
                ynform.ShowDialog();
            }
            else if (textBox1.Text == "Burak Yılmaz" && textBox2.Text == "123")
            {
                MessageBox.Show("Giriş Başarılı");
                this.Hide();
                Form2 ynform = new Form2();
                ynform.ShowDialog();
            }
            else if (textBox1.Text == "Mehmet Şahin" && textBox2.Text == "123")
            {
                MessageBox.Show("Giriş Başarılı");
                this.Hide();
                Form2 ynform = new Form2();
                ynform.ShowDialog();
            }
            else if (textBox1.Text == "Mert Şahin" && textBox2.Text == "123")
            {
                MessageBox.Show("Giriş Başarılı");
                this.Hide();
                Form2 ynform = new Form2();
                ynform.ShowDialog();
            }
            else if (textBox1.Text == "Mehmet Arslan" && textBox2.Text == "123")
            {
                MessageBox.Show("Giriş Başarılı");
                this.Hide();
                Form2 ynform = new Form2();
                ynform.ShowDialog();
            }
            else if (textBox1.Text == "Emre Demir" && textBox2.Text == "123")
            {
                MessageBox.Show("Giriş Başarılı");
                this.Hide();
                Form2 ynform = new Form2();
                ynform.ShowDialog();
            }
            else if (textBox1.Text == "Can Öztürk" && textBox2.Text == "123")
            {
                MessageBox.Show("Giriş Başarılı");
                this.Hide();
                Form2 ynform = new Form2();
                ynform.ShowDialog();
            }
            else if (textBox1.Text == "Ahmet Çelik" && textBox2.Text == "123")
            {
                MessageBox.Show("Giriş Başarılı");
                this.Hide();
                Form2 ynform = new Form2();
                ynform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
        
    

