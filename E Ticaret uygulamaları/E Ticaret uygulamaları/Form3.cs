using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Ticaret_uygulamaları
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        VeritabaniIslemleri db = new VeritabaniIslemleri();
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Select("select * from Oyuncular");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.Insert("insert into Krallar values(" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "')");        
                }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Select("select * from Takimlar");
        }

        private void button5_Click(object sender, EventArgs e)
        {
           var gelen = db.UpdateDelete("delete from Oyuncular where oyuncu_id = " + textBox4.Text);
            MessageBox.Show("Oyuncu Başarıyla Silinmiştir");
            textBox4.Clear();
            button1_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into Oyuncular values('" + textBox5.Text + "','" + textBox6.Text + "'," + textBox7.Text + "," + textBox8.Text + "," + textBox9.Text + "," + textBox10.Text + "," + textBox11.Text + "," + textBox12.Text + ")";
            db.Insert(sorgu);
            MessageBox.Show("Oyuncu Başarıyla Eklenmiştir");
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            button1_Click(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = dataGridView1.CurrentRow.Cells["oyuncu_id"].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            db.UpdateDelete("update Seanslar set baslangic_saati='"+textBox13.Text+"',bitis_saati='"+textBox14.Text+"' where seans_id="+textBox15.Text+"");
            MessageBox.Show("Seans Saatleri Başarıyla Güncellenmiştir");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Select("select * from Seanslar");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ynform = new Form1();
            ynform.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Select("select * from Maclar");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            db.Insert("insert into Maclar values(" + textBox16.Text + "," + textBox17.Text + ",'" + textBox18.Text + "','" + textBox19.Text + "')");
            MessageBox.Show("Maç Başarıyla Eklenmiştir");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            db.UpdateDelete("delete from Oyuncular where oyuncu_id = " + textBox20.Text);
            MessageBox.Show("Maç Başarıyla Silinmiştir");
        }
    }
}
