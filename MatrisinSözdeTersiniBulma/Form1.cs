using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace MatrisinSözdeTersiniBulma
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
            label3.Visible = false;
            txtSatir.Visible = false;
            txtSütun.Visible = false;
            btnDegerGiris.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (checkRastgele.Checked == true)
            {
                RastgeleMatrisOlustur();
            }
            else if (checkManuel.Checked == true)
            {
                label2.Visible = true;
                label3.Visible = true;
                txtSatir.Visible = true;
                txtSütun.Visible = true;
                btnDegerGiris.Visible = true;
            }
        }

        private int boyutKontrol()
        {
            if((Convert.ToInt32(txtSatir.Text.ToString()) > 5) )
            {
                errorProvider1.SetError(txtSatir, "1-5 arasinda değer girmek zorundasiniz");
                return 1;
            }
            else if ((Convert.ToInt32(txtSütun.Text.ToString()) > 5))
            {
                errorProvider1.SetError(txtSütun, "1-5 arasinda değer girmek zorundasiniz");
                return 1;
            }
            return 0;
        }

        private void btnDegerGiris_Click(object sender, EventArgs e)
        {
            int satir = 0;
            int sutun = 0;

            satir = Convert.ToInt32(txtSatir.Text.ToString());
            sutun = Convert.ToInt32(txtSütun.Text.ToString());

            int kontrol = boyutKontrol();

            if(kontrol == 0)
            {
                double[,] deger = new double[satir, sutun];

                for (int i = 0; i < satir; i++)
                {
                    for (int j = 0; j < sutun; j++)
                    {
                        deger[i, j] = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox(i + "," + j + ".eleman", "Matris Değer Girişi", "Buraya yazınız...", 300, 300));
                    }
                }
                ManuelMatrisOlustur(deger, satir, sutun);
            }
        }

        public async void RastgeleMatrisOlustur()
        {
            label4.Visible = true;
            label5.Visible = true;
            Random rastgele = new Random();
            int satir = rastgele.Next(1, 5);
            int sutun = rastgele.Next(1, 5);
            double[,] rastgeleMatris = new double[satir, sutun];

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    int sayi = rastgele.Next(1, 9);
                    Button buton = new Button();
                    buton.Height = 50;
                    buton.Width = 50;
                    buton.Location = new System.Drawing.Point(100 + j * buton.Height + 5, 100 + i * buton.Width + 5);
                    buton.Name = "btn-" + i + "-" + j.ToString();
                    buton.Text = sayi.ToString();
                   // buton.Click += new System.EventHandler(this.boyutButtonClick);
                    this.Controls.Add(buton);
                    rastgeleMatris[i, j] = Convert.ToDouble(buton.Text.ToString());
                }
            }

            if (satir == sutun)
            {
                Metotlar metot = new Metotlar(this);
                double[,] birimmatris = metot.BirimMatris(rastgeleMatris.GetLength(0));
                double[,] tersmatriskare = await metot.tersBulma(rastgeleMatris, birimmatris);
                lblToplamSayisi.Text = Metotlar.Toplamsayisi.ToString();
                lblCarpimSayisi.Text = Metotlar.CarpmaSayisi.ToString();
                //tersMatrisYazdir(tersmatriskare);
            }
            else
            {
                Metotlar metot = new Metotlar(this);
                double[,] transpoz = metot.transpozAl(rastgeleMatris);
                double[,] carpimMatrisi = metot.matrisCarp(rastgeleMatris, transpoz);
                double[,] birimmatris = metot.BirimMatris(carpimMatrisi.GetLength(0));
                double[,] tersmatris = await metot.tersBulma(carpimMatrisi, birimmatris);
                lblToplamSayisi.Text = Metotlar.Toplamsayisi.ToString();
                lblCarpimSayisi.Text = Metotlar.CarpmaSayisi.ToString();
                //tersMatrisYazdir(tersmatris);
            }
        }

        public async void ManuelMatrisOlustur(double[,] sayi, int satir, int sutun)
        {
            label4.Visible = true;
            label5.Visible = true;
            double[,] manuelMatris = new double[satir, sutun];
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Button buton = new Button();
                    buton.Height = 50;
                    buton.Width = 50;
                    buton.Location = new System.Drawing.Point(100 + j * buton.Height + 5, 100 + i * buton.Width + 5);
                    buton.Text = sayi[i, j].ToString();
                    this.Controls.Add(buton);
                    manuelMatris[i, j] = Convert.ToDouble(buton.Text.ToString());
                }
            }
            if (satir == sutun)
            {
                Metotlar metot = new Metotlar(this);
                double[,] birimmatris = metot.BirimMatris(manuelMatris.GetLength(0));
                double[,] tersmatriskare = await metot.tersBulma(manuelMatris, birimmatris);
                lblToplamSayisi.Text = Metotlar.Toplamsayisi.ToString();
                lblCarpimSayisi.Text = Metotlar.CarpmaSayisi.ToString();
                //tersMatrisYazdir(tersmatriskare);
            }
            else
            {
                Metotlar metot = new Metotlar(this);
                double[,] transpoz = metot.transpozAl(manuelMatris);
                double[,] carpimMatrisi = metot.matrisCarp(manuelMatris, transpoz);
                double[,] birimmatris = metot.BirimMatris(carpimMatrisi.GetLength(0));
                double[,] tersmatris = await metot.tersBulma(carpimMatrisi, birimmatris);
                lblToplamSayisi.Text = Metotlar.Toplamsayisi.ToString();
                lblCarpimSayisi.Text = Metotlar.CarpmaSayisi.ToString();
                //tersMatrisYazdir(tersmatris);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
