using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri() { Id = 100, AdSoyad = "Fikriye Nur Harmandar", Yas = 23, EPosta = "fikriyenur@hotmail.com", TelNo = "01234567899", Sehir = "İstanbul" };

            Musteri musteri2 = new Musteri() { Id = 102, AdSoyad = "Anıl Aksoy", Yas = 29, EPosta = "anıl@hotmail.com", TelNo = "01239658745", Sehir = "Ankara" };

            Musteri musteri3 = new Musteri() { Id = 103, AdSoyad = "Ayşe Kaya", Yas = 43, EPosta = "ayse@hotmail.com", TelNo = "01478523654", Sehir = "Antalya" };

            Musteri musteri4 = new Musteri() { Id = 104, AdSoyad = "Arzu Songül", Yas = 32, EPosta = "arzu@hotmail.com", TelNo = "01234567899", Sehir = "Trabzon" };

            Musteri musteri5 = new Musteri() { Id = 105, AdSoyad = "Samet Güler", Yas = 55, EPosta = "samet@hotmail.com", TelNo = "01476984598", Sehir = "Denizli" };

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5 };

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("---------- Yeni Müşteri Ekleme ----------");
            foreach (Musteri kisi in musteriler)
            {
                musteriManager.MusteriEkle(kisi);
            }
            Console.WriteLine(" ");

            Console.WriteLine("---------- Müşteri Listesi ----------");
            musteriManager.MusteriListele(musteriler);
            Console.WriteLine(" ");

            Console.WriteLine("---------- Müşteri Silme ----------");
            musteriManager.MusteriSilme(musteri5);
            musteriManager.MusteriSilme(musteri2);

            Console.ReadKey();
        }
    }
}
