using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arastirmaodev_836
{
    public partial class Form1 : Form
    {
        List<int> Sayilar = new List<int>();
    public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                int sayi = rnd.Next(1, 101);
                Sayilar.Add(sayi);
            }

            lbSayi.DataSource = Sayilar.ToList();
        }

        private void btnİlk_Click(object sender, EventArgs e)
        {
            int sayi = Sayilar[0];
            MessageBox.Show("İlk sayı: " + sayi);
        }

        private void btnKucuk_Click(object sender, EventArgs e)
        {
            int sayi = Sayilar.Min();
            MessageBox.Show("EN KUÇUK SAYI: "+sayi);
        }

        private void btnSon_Click(object sender, EventArgs e)
        {
            int sayi = Sayilar[Sayilar.Count-1];
            MessageBox.Show("Son sayı: "+sayi);

        }

        private void btnBuyuk_Click(object sender, EventArgs e)
        {
            int sayi = Sayilar.Max();
            MessageBox.Show("EN BÜYÜK SAYI: " + sayi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            
            Sayilar.Remove(sayi);
            lbSayi.DataSource = Sayilar.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox2.Text);

            Sayilar.RemoveAt (sayi);
            lbSayi.DataSource = Sayilar.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sayilar.Clear();

            lbSayi.DataSource = Sayilar.ToList();
        }
    }
}
