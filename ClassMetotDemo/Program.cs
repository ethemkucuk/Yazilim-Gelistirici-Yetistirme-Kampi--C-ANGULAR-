using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Name = "Ethem";
            musteri1.SurName = "Küçük";
            musteri1.Id = 12345;
            musteri1.AccountNumber = 10;

            Musteri musteri2 = new Musteri();
            musteri2.Name = "Tuğba";
            musteri2.SurName = "Aktaş";
            musteri2.Id = 23456;
            musteri2.AccountNumber = 11;

            Musteri musteri3 = new Musteri();
            musteri3.Name = "Kenan";
            musteri3.SurName = "Aktaş";
            musteri3.Id = 34567;
            musteri3.AccountNumber = 12;

            Musteri[] musteriler = new Musteri[]
            {
                musteri1, musteri2, musteri3
            };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Name + " " + musteri.SurName+" " + musteri.Id + " " + musteri.AccountNumber);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Delete(musteri2);
            musteriManager.List(musteri3);
        }
    }
}
