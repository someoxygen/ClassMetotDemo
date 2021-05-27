using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Musteri> musteriList = new List<Musteri>()
            {
                new Musteri{Id=1,Ad="Mustafa",Soyad="Yucel",Yas=26},
                new Musteri{Id=2,Ad="Sudenur",Soyad="Yucel",Yas=16}
            };



            MusteriManager musteriManager = new MusteriManager();
            musteriManager.GetAll(musteriList);
            musteriManager.AddMusteri(musteriList, new Musteri { Id = 3, Ad = "Simge", Soyad = "Yucel", Yas = 22 });
            Console.WriteLine("--------------------");
            musteriManager.GetAll(musteriList);
            musteriManager.DeleteMusteri(musteriList, new Musteri { Id = 3, Ad = "Simge", Soyad = "Yucel", Yas = 22 });
            Console.WriteLine("--------------------");
            musteriManager.GetAll(musteriList);
        }
    }
}
