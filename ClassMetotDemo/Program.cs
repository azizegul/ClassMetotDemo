using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.TC = 22222222222;
            musteri1.Ad = "Azize";
            musteri1.Soyadı = "Aydoğdu";

            Musteri musteri2 = new Musteri();
            musteri2.TC = 22222222222;
            musteri2.Ad = "Ece";
            musteri2.Soyadı = "Aydoğdu";

            Musteri musteri3 = new Musteri();
            musteri3.TC = 22222222222;
            musteri3.Ad = "Edanur";
            musteri3.Soyadı = "Aydoğdu";

            Musteri musteri4 = new Musteri();
            musteri4.TC = 22222222222;
            musteri4.Ad = "Yağmur";
            musteri4.Soyadı = "Aydoğdu";

            Musteri musteri5 = new Musteri();
            musteri5.TC = 22222222222;
            musteri5.Ad = "Adil";
            musteri5.Soyadı = "Aydoğdu";

            Musteri musteri6 = new Musteri();
            musteri6.TC = 22222222222;
            musteri6.Ad = "Nuran";
            musteri6.Soyadı = "Aydoğdu";


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2,musteri3,musteri4,musteri5,musteri6 };


            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("------------");
                Console.WriteLine(musteri.TC);
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyadı);
            
            }

            Console.WriteLine("Müşteri listesi sonu");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
            musteriManager.Ekle(musteri5);
            musteriManager.Ekle(musteri6);

            Console.WriteLine("------------------------------");

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);
            musteriManager.Sil(musteri4);
            musteriManager.Sil(musteri5);
            musteriManager.Sil(musteri6);


        }
    }
}
