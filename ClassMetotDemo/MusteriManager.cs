using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müsteri eklendi :"+musteri.Name+" "+musteri.Surname);
        }
       public void Update(Musteri musteri)
        {
            Console.WriteLine("Müsteri güncellendi :" + musteri.Name + " " + musteri.Surname);
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müsteri silindi :" + musteri.Name + " " + musteri.Surname);
        }
        public void List(Musteri musteri)
        {
            Console.WriteLine("Müsteri listelendi :" + musteri.Name + " " + musteri.Surname);
        }
    }
}
