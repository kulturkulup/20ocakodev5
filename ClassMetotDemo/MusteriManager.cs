using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.AdSoyad + " -- "+"İsimli müşteri başarıyla eklenmiştir.");
        }

        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                var sonuc = "Ad Soyad : " + musteri.AdSoyad + " " + "\nYaş : " + musteri.Yas + " " + "\nE-Posta : " + musteri.EPosta + " " + "\nTelefon No : " + musteri.TelNo + " " + "\nŞehir : " + musteri.Sehir;
                Console.WriteLine(sonuc);
                Console.WriteLine("-----------------");
            }
        }

        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " Numaralı müşteriyi başarıyla sildiniz.");
        }
    }
}
