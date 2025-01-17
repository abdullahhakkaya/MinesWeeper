using System;
using System.Windows.Forms;

namespace MinesWeeper
{
    public partial class Form1 : Form
    {
        private Oyun oyun;
        public Timer oyunSuresi;
        private int Sure;
        private Skorboard skorboard;

        public Form1()
        {
            InitializeComponent();
            oyunSuresi = new Timer();
            oyunSuresi.Interval = 1000;
            oyunSuresi.Tick += timer1_Tick;
            skorboard = new Skorboard();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oyun = new Oyun(this); // Oyun nesnesini oluştur
            bool basla = oyun.degerAl();
            if (basla)
            {
                oyun.Init(); // Init metodunu çağır
                oyun.CreateButtons(this); // Butonları Oyun sınıfından oluştur
                Sure = 0;
                oyunSuresi.Start();
            }
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            Sure++;
            sureLabel.Text = Sure.ToString();
            oyun.OyunSuresi = Sure;
        }

        private void SkorButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(skorboard.EnYuksekSkorlar());
            form2.Show();
        }
    }

}
