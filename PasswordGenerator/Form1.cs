using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {

        bool kucukHarfVarmi;
        bool buyukHarfVarmi;
        bool RakamVarmi;
        bool OzelKarakterVarmi;
        int sifreUzunlugu, sifreSayisi;

        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnÜret_Click(object sender, EventArgs e)
        {
            kucukHarfVarmi = chkKucukHarf.Checked;
            buyukHarfVarmi = chkBuyukHarf.Checked;
            RakamVarmi = chkRakam.Checked;
            OzelKarakterVarmi = chkOzelKarakter.Checked; ;
            sifreUzunlugu = (int)nmrSifreUzunlugu.Value;
            sifreSayisi = (int)nmrSifreSayisi.Value;
            txtSifreler.Text = "";

            if (!(kucukHarfVarmi || buyukHarfVarmi || RakamVarmi || OzelKarakterVarmi))
            {
                MessageBox.Show("Lütfen bir parametre seçiniz.");
                return;
            }

            string secilenKarakterler = "";

            if (OzelKarakterVarmi)
            {
                for (int i = 33; i < 48; i++)
                {
                    secilenKarakterler += Convert.ToChar(i);
                }
                for (int i = 58; i < 65; i++)
                {
                    secilenKarakterler += Convert.ToChar(i);
                }
                for (int i = 97; i < 97; i++)
                {
                    secilenKarakterler += Convert.ToChar(i);
                }
                for (int i = 123; i < 127; i++)
                {
                    secilenKarakterler += Convert.ToChar(i);
                }
            }
            if (RakamVarmi)
            {
                for (int i = 48; i < 58; i++)
                {
                    secilenKarakterler += Convert.ToChar(i);
                }
            }
            if (buyukHarfVarmi)
            {
                for (int i = 65; i < 90; i++)
                {
                    secilenKarakterler += Convert.ToChar(i);
                }
            }
            if (kucukHarfVarmi)
            {
                for (int i = 97; i < 123; i++)
                {
                    secilenKarakterler += Convert.ToChar(i);
                }
            }
            for (int i = 0; i < sifreSayisi; i++)
            {
                string sifre = "";
                for (int j = 0; j < sifreUzunlugu; j++)
                {
                    sifre += secilenKarakterler[rnd.Next(0, secilenKarakterler.Length)];
                }
                txtSifreler.Text += sifre;
                txtSifreler.Text += "\r\n\r\n";

            }

        }
        //4 tane seçenek (küçük harf-büyük harf-sayı-özel karakter)
        //seçili olan seçenekler , şifre uzunluğu ve şifre sayısına göre rastgele şifre oluşturup textboxa yazdırınız.
    }
}
