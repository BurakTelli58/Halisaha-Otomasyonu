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
    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        VeritabaniIslemleri db = new VeritabaniIslemleri();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource =  db.Select("select * from Seanslar");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into Randevular values(" + textBox1.Text + "," + textBox2.Text + ",'" + dateTimePicker1.Value.ToShortDateString() + "')";
             db.Insert(sorgu);
            MessageBox.Show("Randevunuz Başarıyla Eklenmiştir");
            button6_Click(sender, e);
            textBox1.Clear();
            textBox2.Clear();
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Select("select * from Maclar");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Select("select * from Krallar");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           var gelen = db.UpdateDelete("delete from Randevular where randevu_id = " + textBox4.Text);
            MessageBox.Show("Randevunuz Başarıyla İptal Edilmiştir");
           
            button6_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Select("select * from Randevular");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = dataGridView1.CurrentRow.Cells["randevu_id"].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ynform = new Form1();
            ynform.ShowDialog();
        }
    }
}
