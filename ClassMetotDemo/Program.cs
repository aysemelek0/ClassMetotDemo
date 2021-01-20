using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ad = "Ayşe Melek";
            musteri1.soyad = "Doğan";
            musteri1.Id = 75287894;
            musteri1.yas = 35;


            Musteri musteri2 = new Musteri();
            musteri2.ad = "Hamza";
            musteri2.soyad = "Bayram";
            musteri2.Id = 25789832;
            musteri2.yas = 62;


            Musteri musteri3 = new Musteri();
            musteri3.ad = "Nesrin";
            musteri3.soyad = "Kaya";
            musteri3.Id = 87592145;
            musteri3.yas = 29;

            Console.WriteLine("Müşteri adı: " + musteri1.ad);
            Console.WriteLine("Müşteri soyad: " + musteri1.soyad);
            Console.WriteLine("Müşteri ID: " + musteri1.Id);
            Console.WriteLine("Müşteri yaş: " + musteri1.yas);

            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Müşteri adı: " + musteri2.ad);
            Console.WriteLine("Müşteri soyad: " + musteri2.soyad);
            Console.WriteLine("Müşteri ID: " + musteri2.Id);
            Console.WriteLine("Müşteri yaş: " + musteri2.yas);


            Console.WriteLine("-------------------------------------------");


            Console.WriteLine("Müşteri adı: " + musteri3.ad);
            Console.WriteLine("Müşteri soyad: " + musteri3.soyad);
            Console.WriteLine("Müşteri ID: " + musteri3.Id);
            Console.WriteLine("Müşteri yaş: " + musteri3.yas);

            Console.WriteLine("-------------------------------------------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);
            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Silme(musteri3);
        }
    }
        }
            