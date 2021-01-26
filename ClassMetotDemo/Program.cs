using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 1;
            musteri1.Name = "Betül";
            musteri1.Surname = "Uyar";
            musteri1.City = "Kocaeli";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.List(musteri1);
            musteriManager.Add(musteri1);
            musteriManager.Update(musteri1);
            musteriManager.Delete(musteri1);

        }
    }
}
