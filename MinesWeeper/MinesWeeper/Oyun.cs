using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace MinesWeeper
{
    public class Oyun : Skorboard
    {
        public int ButonBoyutu=25,hücreSayisi,mayinSayisi,Skor,Sayac=0;
        public int OyunSuresi=0;
        public string KullaniciAdi;
        private int bayrakSayisi = 0,bayrakForm;
        public int[,] Field;//m { get; private set; }
        public Button[,] Buttons { get; private set; }
        Skorboard skorboard = new Skorboard();
        private Form1 form;
        public Oyun(Form1 form)
        {
            this.form = form;
        }

        public bool degerAl()
        {
            bool KontrolKullanici = false;
            bool KontrolHucre = false;
            bool KontrolMayin = false;
            if (!string.IsNullOrWhiteSpace(form.KullaniciAdiTextBox.Text) && !KontrolKullanici)
            {
                KullaniciAdi = form.KullaniciAdiTextBox.Text;
                form.KullaniciAdiTextBox.Enabled = false;
                KontrolKullanici = true;
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Giriniz!");
                form.KullaniciAdiTextBox.Focus();
                form.KullaniciAdiTextBox.Clear();
            }
            if (!string.IsNullOrEmpty(form.HücreTextBox.Text) && int.TryParse(form.HücreTextBox.Text, out hücreSayisi) && !KontrolHucre)
            {
                if (hücreSayisi > 30 || hücreSayisi < 10)
                {
                    MessageBox.Show("Alan 10-30 Arasında Değer Alır!\nTekrar Giriniz.");
                    form.HücreTextBox.Focus();
                    form.HücreTextBox.Clear();
                }
                else
                {
                    form.HücreTextBox.Enabled = false;
                    KontrolHucre = true;
                }
            }
            else
            {
                MessageBox.Show("Hücre Sayısı Giriniz!");
                form.HücreTextBox.Focus();
                form.HücreTextBox.Clear();
            }
            if (!string.IsNullOrEmpty(form.MayinTextBox.Text) && int.TryParse(form.MayinTextBox.Text, out mayinSayisi) && !KontrolMayin)
            {
                int maxMayin = (hücreSayisi - 1) * (hücreSayisi - 1);
                if (mayinSayisi < 10 || mayinSayisi >= maxMayin)
                {
                    MessageBox.Show("Mayın En Az 10,\n"+"En Fazla "+maxMayin+" Olabilir!\nTekrar Giriniz.");
                    form.MayinTextBox.Focus();
                    form.MayinTextBox.Clear();
                }
                else
                {
                    form.MayinTextBox.Enabled = false;
                    KontrolMayin = true;
                }
            }
            else
            {
                MessageBox.Show("Mayın Sayısı Giriniz!");
                form.MayinTextBox.Focus();
                form.MayinTextBox.Clear();
            }
            if (KontrolKullanici && KontrolHucre && KontrolMayin) return true;
            else return false;
        }

        public void Init()
        {
            FormBoyutuAyarla();
            Field = new int[hücreSayisi, hücreSayisi];
            Buttons = new Button[hücreSayisi, hücreSayisi];
            int mayin = mayinSayisi;
            Random random = new Random();

            while (mayin > 0)
            {
                int x = random.Next(hücreSayisi);
                int y = random.Next(hücreSayisi);
                if (Field[x, y] == -1) continue;
                Field[x, y] = -1;

                for (int dx = -1; dx <= 1; dx++)
                {
                    for (int dy = -1; dy <= 1; dy++)
                    {
                        if (x + dx < 0 || y + dy < 0) continue;
                        if (x + dx >= hücreSayisi || y + dy >= hücreSayisi) continue;
                        if (Field[x + dx, y + dy] != -1)
                        {
                            Field[x + dx, y + dy]++;
                        }
                    }
                }
                mayin--;
            }
        }

        public void CreateButtons(Control parent)
        {
            for (int x = 0; x < Field.GetLength(0); x++)
            {
                for (int y = 0; y < Field.GetLength(1); y++)
                {
                    Button b = new Button();
                    Buttons[x, y] = b;
                    if(hücreSayisi<=10)b.Left = (x * 25)+60;
                    else b.Left = x * 25;
                    b.Top = (y * 25)+80;
                    b.Width = 25;
                    b.Height = 25;
                    b.Margin = new Padding(0);
                    b.BackColor = Color.Gray;
                    b.FlatStyle = FlatStyle.System;
                    b.Font = new Font("Arial", 10);
                    b.Text = "";
                    parent.Controls.Add(b);
                    b.Click += B_click;
                    b.MouseDown += Button_MouseDown;
                }
            }
        }

        public void FormBoyutuAyarla()
        {
            int Genislik = hücreSayisi * ButonBoyutu;
            int Yukseklik = hücreSayisi * ButonBoyutu + 100;
            if (hücreSayisi <= 10)
            {
                Genislik += 120;
            }
            this.form.panel2.Width = Genislik;
            this.form.panel1.Left = (Genislik - this.form.panel1.Width) / 2;
            Form form = (Form)Control.FromHandle(System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle);
            form.ClientSize = new Size(Genislik, Yukseklik);
            
        }

        public void B_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "🚩")
            {
                return; // Hiçbir işlem yapma
            }

            b.BackColor = Color.LightGray;
            int x, y;
            if (hücreSayisi <= 10) x = (b.Left - 60) / 25;
            else x = b.Left / 25;
            y = (b.Top - 80) / 25;

            if (Field[x, y] == -1)
            {
                mayinlariGöster(x, y);
                OyunuBitir();
                return;
            }
            else
            {
                if (Field[x, y] == 0)
                {
                    b.Text = "";
                    OtoAcilma(x, y);
                }
                else
                {
                    b.Text = "" + Field[x, y];
                }
            }
            b.Enabled = false;
            Sayac++;
            form.SayacLabel.Text = "HAMLE :" + Sayac;
            if (KontrolOyunBitti())
            {
                OyunuBitir();
            }
        }
        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            int x, y;
            if (hücreSayisi <= 10) x = (b.Left - 60) / 25;
            else x = b.Left / 25;
            y = (b.Top - 80) / 25;
            if (e.Button == MouseButtons.Right)
            {
                if (b.Text == "🚩") 
                {
                    b.Text = "";
                    bayrakSayisi--;
                    bayrakForm--;
                }
                else if (b.Enabled)
                {
                    b.Text = "🚩";
                    bayrakForm++;
                    if (Field[x, y] == -1) bayrakSayisi++;
                }
            }
            form.BayrakLabel.Text = "🚩:"+bayrakForm;
        }

        private void OtoAcilma(int x, int y)
        {
            Stack<Point> stack = new Stack<Point>();
            stack.Push(new Point(x, y));

            while (stack.Count > 0)
            {
                Point p = stack.Pop();
                if (p.X < 0 || p.Y < 0) continue;
                if (p.X >= Field.GetLength(0) || p.Y >= Field.GetLength(1)) continue;
                if (!Buttons[p.X, p.Y].Enabled) continue;

                Buttons[p.X, p.Y].Enabled = false;
                if (Field[p.X, p.Y] != 0)
                {
                    Buttons[p.X, p.Y].Text = "" + Field[p.X, p.Y];
                }
                if (Field[p.X, p.Y] != 0) continue;

                stack.Push(new Point(p.X - 1, p.Y));
                stack.Push(new Point(p.X + 1, p.Y));
                stack.Push(new Point(p.X, p.Y - 1));
                stack.Push(new Point(p.X, p.Y + 1));
            }
        }
        private void mayinlariGöster(int x, int y)
        {
            for (int X = 0; X < Field.GetLength(0); X++)
            {
                for (int Y = 0; Y < Field.GetLength(1); Y++)
                {
                    if (Field[X, Y] == -1)
                    {
                        Buttons[X, Y].Text = "\U0001F4A3";
                        Buttons[X, Y].Enabled = false;
                    }
                    else if (Buttons[X, Y].Text == "🚩" && Field[X, Y] == -1) // Bayrak altında mayın varsa
                    {
                        Buttons[X, Y].Text = "\U0001F4A3"; // Bayrağın yerine mayın simgesini göster                        
                        Buttons[X, Y].Enabled = false; // Butonu devre dışı bırak
                    }
                }
            }
        }

        private bool KontrolOyunBitti()
        {
            for (int x = 0; x < hücreSayisi; x++)
            {
                for (int y = 0; y < hücreSayisi; y++)
                {
                    if (Field[x, y] != -1 && Buttons[x, y].Enabled) // Mayın değilse ve buton açıksa
                    {
                        return false; // Oyun bitmedi
                    }
                }
            }
            return true; // Oyun bitti
        }
        private void OyunuBitir()
        {
            for (int X = 0; X < Field.GetLength(0); X++)
            {
                for (int Y = 0; Y < Field.GetLength(1); Y++)
                {
                    Buttons[X, Y].Enabled = false;
                }
            }
            form.timer1.Stop();
            form.oyunSuresi.Stop();
            Skor = skorboard.HesaplaSkor(bayrakSayisi, OyunSuresi);
            skorboard.KaydetSkor(KullaniciAdi, Skor);
            form.SkorLabel.Text ="SKOR:"+ Convert.ToString(Skor);
        }
    }
    
}
