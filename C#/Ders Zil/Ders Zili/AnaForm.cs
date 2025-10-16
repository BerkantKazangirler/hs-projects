using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Ders_Zili
{
	public partial class AnaForm : Form
	{
		#region Değişkenler & Nesneler
		enum Durum
		{
			Beklemede,
			Ders,
			Ara
		}

		Durum durum = Durum.Beklemede;
		int kalanZaman = 0;
		System.Media.SoundPlayer zil;
        System.Media.SoundPlayer istiklal_marşı;
		RegistryKey kayıtAnahtarı;
		#endregion

		#region Metodlar
		private void göster()
		{
			ShowInTaskbar = true;
			Show();
			WindowState = FormWindowState.Normal;
		}

		private void gizle()
		{
			ShowInTaskbar = false;
			Hide();
			WindowState = FormWindowState.Minimized;
		}

		public void başlat(bool gizliMi)
		{
			if (gizliMi)
			{
				gizle();
			}
			durum = Durum.Ders;
			kalanZaman = (int)dersSüresi.Value * 60;
			süreyiGöster(kalanZaman / 3600, (kalanZaman / 60) - ((kalanZaman / 3600) * 60), kalanZaman % 60);
			zamanlayıcı.Start();
			başla.Enabled = false;
		}

		private void zilÇal(string metin, int süre)
		{
			zil = new System.Media.SoundPlayer(Kaynaklar.Zil);
            zil.Play();
			simge.BalloonTipText = metin;
			simge.ShowBalloonTip(süre * 1000);
			if (durum == Durum.Ders)
			{
				durum = Durum.Ara;
				kalanZaman = (int)araSüresi.Value * 60;
			}
			else if (durum == Durum.Ara)
			{
				durum = Durum.Ders;
				kalanZaman = (int)dersSüresi.Value * 60;
			}
		}

		private void herŞeyiSıfırla()
		{
			durum = Durum.Beklemede;
			dersSüresi.Value = 45;
			araSüresi.Value = 15;
			zamanlayıcı.Stop();
			süre.Text = durum.ToString();
			başla.Enabled = true;
		}

		private void süreyiGöster(int saat, int dakika, int saniye)
		{
			string sonuç = "";

			if (saat >= 0 && saat < 100)
			{
				if (saat < 10)
				{
					sonuç += "0" + saat;
				}
				else
				{
					sonuç += saat;
				}
			}
			else
			{
				sonuç += "00";
			}

			sonuç += ":";

			if (dakika >= 0 && dakika < 60)
			{
				if (dakika < 10)
				{
					sonuç += "0" + dakika;
				}
				else
				{
					sonuç += dakika;
				}
			}
			else
			{
				sonuç += "00";
			}

			sonuç += ":";

			if (saniye >= 0 && saniye < 60)
			{
				if (saniye < 10)
				{
					sonuç += "0" + saniye;
				}
				else
				{
					sonuç += saniye;
				}
			}
			else
			{
				sonuç += "00";
			}

			süre.Text = sonuç;
		}
		#endregion

		#region Olaylar
		private void simge_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			göster();
		}

		private void menü_göster_Click(object sender, EventArgs e)
		{
			göster();
		}

		private void menü_çıkış_Click(object sender, EventArgs e)
		{
			DialogResult sonuç = MessageBox.Show("Sayaç çalışıyor.\n\nÇıkmak istediğimizden emin misniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (sonuç == System.Windows.Forms.DialogResult.Yes)
			{
				simge.Dispose();
				Application.Exit();
			}
		}

		private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (durum != Durum.Beklemede)
			{
				if (WindowState == FormWindowState.Normal)
				{
					e.Cancel = true;
					gizle();
				}
				else if (WindowState == FormWindowState.Minimized)
				{
					e.Cancel = false;
				}
			}
			else
			{
				simge.Dispose();
			}
		}

		private void zamanlayıcı_Tick(object sender, EventArgs e)
		{
            label2.Visible = true;
            label1.Visible = true;
            label1.Text = ("Kalan Zaman : ")+ kalanZaman.ToString() +" Saniye";
			kalanZaman--;
			süreyiGöster(kalanZaman / 3600, (kalanZaman / 60) - ((kalanZaman / 3600) * 60), kalanZaman % 60);
			if (kalanZaman == 0)
			{
				if (durum == Durum.Ders)
				{
					zilÇal("Ders bitti! Ara zamanı.", 15);
                    label2.Visible = true;
                    label2.Text = "Zil Durumu : Tenefüs";
				}
				else if (durum == Durum.Ara)
				{
					zilÇal("Ara bitti! Ders zamanı.", 15);
                    label2.Visible = true;
                    label2.Text = "Zil Durumu : Ders";
				}
			}
		}

		private void başla_Click(object sender, EventArgs e)
		{
			başlat(false);
		}

		private void sıfırla_Click(object sender, EventArgs e)
		{
			herŞeyiSıfırla();
		}
		#endregion

		public AnaForm(bool gizliMi)
		{
			InitializeComponent();
			herŞeyiSıfırla();
			if (gizliMi)
			{
				başlat(true);
			}
		}

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void süre_Click(object sender, EventArgs e)
        {

        }

        private void kutu1_Enter(object sender, EventArgs e)
        {

        }

        private void yazı1_Click(object sender, EventArgs e)
        {

        }

        private void araSüresi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void yazı2_Click(object sender, EventArgs e)
        {

        }

        private void dersSüresi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bdbox.Width = 233;
            başla.Visible = true;
            saatler.Items.Add(dersSüresi.Text+ " Dakika");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zil = new System.Media.SoundPlayer(Kaynaklar.Zil);
            zil.Play();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            istiklal_marşı = new System.Media.SoundPlayer(Kaynaklar.Zil);
            istiklal_marşı.Play();
        }
    }
}