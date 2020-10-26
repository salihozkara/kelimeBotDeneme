using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace text_bot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool btnKontrol;
        public int mesajSayisi = 0;
        void key()
        {
            double bekle = Convert.ToDouble(zaman.Text) * 1000;
            string sayi = "";
            while (btnKontrol)
            {
                sayi=sayma.Checked? mesajSayisi.ToString() : null;
                Thread.Sleep((int)bekle);
                SendKeys.SendWait(metin.Text +sayi+ "{Enter}");
                mesajSayisi++;
            }
        }

        private void btnbaslat_Click(object sender, EventArgs e)
        {
            mesajSayisi = 0;
            keyBaslat();
        }

        private void keyBaslat()
        {
            if (Convert.ToDouble(zaman.Text) < (0.3))
            {
                MessageBox.Show("lütfen 0,2 den büyük bir değer giriniz");
            }
            else
            {

                btnKontrol = true;
                Thread thread = new Thread(new ThreadStart(key));
                thread.Start();
            }
        }

        private void btndurdur_Click(object sender, EventArgs e)
        {
            btnKontrol = false;
        }

        private void btndevam_Click(object sender, EventArgs e)
        {
            keyBaslat();
        }
    }
}
