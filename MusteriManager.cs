using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " sisteme eklenmiştir! ");
           
        }
        public void Listele(Musteri musteri)
        {
           
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " : " + musteri.Telefon);
                        
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " sistemden silinmiştir! ");
        }
    }
}
