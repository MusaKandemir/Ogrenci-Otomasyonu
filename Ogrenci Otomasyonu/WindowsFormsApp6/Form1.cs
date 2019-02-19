using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
           
            int sonuc;
            int sayi1;
            int sayi2;
            sayi1 = Convert.ToInt32(textBox2.Text);
            sayi2 = Convert.ToInt32(textBox3.Text);
            sonuc = (sayi1 + sayi2) / 2;
            listBox4.Items.Add(sonuc);
            if (sonuc>=50)
            {
                listBox5.Items.Add("geçti");
                    
            }
            else
                listBox5.Items.Add("kaldı"); 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
