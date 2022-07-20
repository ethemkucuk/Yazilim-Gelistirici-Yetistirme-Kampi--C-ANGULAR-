using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.SurName + " : " + musteri.AccountNumber + " Eklendi.");
        }
        public void List(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.SurName + " : " + musteri.AccountNumber + " Listelendi.");
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.SurName + " : " + musteri.AccountNumber + " Silindi.");
        }
    }
}
