using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Mehmet ";
            musteri1.Soyadi = "HÜR";
            musteri1.Maas = 2760;
            musteri1.Telefon = "0561 200 65 11";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Adnan ";
            musteri2.Soyadi = "ŞENSES";
            musteri2.Maas = 3500;
            musteri2.Telefon = "0521 320 50 99";

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Ceren ";
            musteri3.Soyadi = "YAĞMUR";
            musteri3.Maas = 5000;
            musteri3.Telefon= "0521 325 66 99";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri3);
            foreach (var musteri in musteriler)
            {
                musteriManager.Listele(musteri);
            }
            musteriManager.Sil(musteri2);
        }
    }
}
