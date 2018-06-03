using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_ornekleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {


            comboBox2.Items.Add("+");
            comboBox2.Items.Add("-");
            comboBox2.Items.Add("/");
            comboBox2.Items.Add("*");
            this.Text = "Ders Örnekleri";
            tabPage1.Text = "1. Örnek";
            tabPage2.Text = "2. Örnek";
            tabPage3.Text = "3. Örnek";
            tabPage4.Text = "4. Örnek";
            comboBox1.Items.Add("İlkbahar");
            comboBox1.Items.Add("Yaz");
            comboBox1.Items.Add("Sonbahar");
            comboBox1.Items.Add("Kış");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add("Isparta");
            listBox1.Items.Add("Burdur");
            listBox1.Items.Add("Antalya");
            listBox1.Items.Add("Antep");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.Items.Count.ToString(); // Listbox ta kaç adet eleman olduğunu gösterir.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // verileri temizler
            textBox1.Text = "";

            
            
        }

        private void button4_Click(object sender, EventArgs e) // index aramalarında aranan index değeri bulunamazsa -1 yazar textbox'a
        {
            textBox2.Text = listBox1.Items.ToString(); // listbox taki verileri textboxa aktarır.
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Text = listBox1.Items.IndexOf(textBox3.Text).ToString(); // indexleme işlemi
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.IndexOf(textBox3.Text) != -1) // Aranan kelime listbox'ta mevcut ise messagebox ile mevcut yazdırır.
                MessageBox.Show("Mevcut !");
            else
                listBox1.Items.Add(textBox3.Text); // Değilse Listbox'a ekler.

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox4.Text = listBox1.Items.Contains(textBox3.Text).ToString(); // True veya False işlemi işlemi

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox4.Text = listBox1.FindString(textBox3.Text).ToString(); // Otomatik bulma

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (comboBox1.SelectedIndex == 0)
                listBox2.Items.Add("İlkbahar");
            else if (comboBox1.SelectedIndex == 1)
                listBox2.Items.Add("Yaz");
            else if (comboBox1.SelectedIndex == 2)
                listBox2.Items.Add("Sonbahar");
            else if (comboBox1.SelectedIndex == 3)
                listBox2.Items.Add("Kış");
            else
            MessageBox.Show("Boş");
        }

      
        private void button9_Click(object sender, EventArgs e)
        {
        
               



            
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {

        
        }

        private void listBox1_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
