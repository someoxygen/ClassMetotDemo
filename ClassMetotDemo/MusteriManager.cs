using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager:IMusteriManager
    {
        public void AddMusteri(List<Musteri> musteriList, Musteri musteri)
        {
            musteriList.Add(musteri);
        }

        public void DeleteMusteri(List<Musteri> musteriList, Musteri musteri)
        {

            Musteri musteriToDelete;
            musteriToDelete = musteriList.SingleOrDefault(c => c.Id == musteri.Id);
            musteriList.Remove(musteriToDelete);
        }

        public void GetAll(List<Musteri> musteriList)
        {
            foreach (var item in musteriList)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Ad);
                Console.WriteLine(item.Soyad);
                Console.WriteLine(item.Yas);
            }
        }
    }
}
