using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi : " + musteri.Ad + " " + musteri.Soyad);
        }
        public void GetList()
        {
            Console.WriteLine("Müşteriler listelendi");
        }
        public void Update(Musteri musteri)
        {
            Console.WriteLine("Müşteri güncellendi : " + musteri.Ad + " " + musteri.Soyad);
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi : " + musteri.Ad + " " + musteri.Soyad);
        }
    }
}
