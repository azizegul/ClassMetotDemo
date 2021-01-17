using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Yeni Müşteri Eklendi. : " + musteri.TC + "" + musteri.Ad + "" + musteri.Soyadı);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi! : " + musteri.TC + "" + musteri.Ad + "" + musteri.Soyadı);
        }
    }
}
