using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrisinSözdeTersiniBulma
{
    class Metotlar : Form1
    {
        public static int Toplamsayisi = 0;
        public static int CarpmaSayisi = 0;
        public static Form1 MainForm { get; private set; } = null;

        public Metotlar(Form1 mainForm)
        {
            MainForm = mainForm;
        }

        public double[,] transpozAl(double[,] matris)
        {
            //matris.GetLength(0) -> satir sayisini, matris.GetLength(1) -> sutun sayisini verir.
            //matrisin boyutu axb ise transpozesinin bxa olur. 
            double[,] matrisT = new double[matris.GetLength(1), matris.GetLength(0)];

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    matrisT[j, i] = matris[i, j];
                }
            }
            return matrisT;
        }

        public double[,] matrisCarp(double[,] matris, double[,] transpozMatris)
        {
            //Çarpma İşlemini Yapıyoruz.
            double[,] sonucMatrisi = new double[transpozMatris.GetLength(0), transpozMatris.GetLength(0)];

            for (int i = 0; i < transpozMatris.GetLength(0); i++)
            {
                for (int k = 0; k < transpozMatris.GetLength(0); k++)
                {
                    for (int j = 0; j < transpozMatris.GetLength(1); j++)
                    {
                        sonucMatrisi[i, k] += transpozMatris[i, j] * matris[j, k];
                    }
                }
            }
            return sonucMatrisi;
        }

        public double[,] BirimMatris(int boyut)
        {
            //Birim matris oluştururken sadece boyut değeri olarak satir veya sutundan birini almam yeterli olacak
            //zaten birim matrisin satir ve sutun degeri eşit olur. 
            double[,] birimMatris = new double[boyut, boyut];

            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    if (i == j)
                        birimMatris[i, j] = 1;
                    else
                        birimMatris[i, j] = 0;
                }
            }
            return birimMatris;
        }

        public async Task<double[,]> tersBulma(double[,] Matris, double[,] birimMatris)
        {
            int bolmeadet = 0, carpimadet = 0, cikarmadet = 0;
            double sayi, sayi1;
            for (int i = 0; i < Matris.GetLength(0); i++)
            {
                sayi = Matris[i, i];
                for (int j = 0; j < Matris.GetLength(1); j++)
                {
                    Matris[i, j] = (Matris[i, j]) / sayi;
                    birimMatris[i, j] = (birimMatris[i, j]) / sayi;
                    bolmeadet = bolmeadet + 1;
                    await tersMatrisYazdir(birimMatris);

                }
                for (int k = 0; k < Matris.GetLength(0); k++)
                {
                    if (k != i)
                    {
                        sayi1 = Matris[k, i];
                        for (int t = 0; t < Matris.GetLength(1); t++)
                        {
                            Matris[k, t] = Matris[k, t] - ((Matris[i, t]) * sayi1);
                            birimMatris[k, t] = birimMatris[k, t] - ((birimMatris[i, t]) * sayi1);
                            carpimadet = carpimadet + 1;
                            cikarmadet = cikarmadet + 1;
                            await tersMatrisYazdir(birimMatris);
                        }
                    }
                }
            }
            islemadetsayisi(cikarmadet, bolmeadet, carpimadet);
            return birimMatris;
        }

        public void islemadetsayisi(int cikarma, int bölme, int carpma)
        {
            Toplamsayisi = cikarma;
            CarpmaSayisi = bölme + carpma;
        }

        public async Task tersMatrisYazdir(double[,] matris)
        {
            var random=new Random();
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    var btn = MainForm.Controls.Find("btnResult" + i + j, true).FirstOrDefault();
                    Button button;
                    if (btn != null)
                    {
                        button = (Button)btn;
                    }
                    else
                    {
                        button = new Button
                        {
                            Height = 50,
                            Width = 50,
                            Name = "btnResult" + i + j
                        };
                        button.Location = new System.Drawing.Point(520 + j * button.Height + 5, 100 + i * button.Width + 5);
                    }

                    button.BackColor = Color.FromArgb(random.Next(0,255), random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                    button.Text = matris[i, j].ToString("0.###");
                    //buton.Click += new System.EventHandler(this.boyutButtonClick);
                    MainForm.Controls.Add(button);
                    MainForm.Refresh();
                    await Task.Delay(350);
                    MainForm.Refresh();
                }
            }
        }
    }
}
