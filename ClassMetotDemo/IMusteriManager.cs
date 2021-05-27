using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    interface IMusteriManager
    {
        void AddMusteri(List<Musteri> musteriList, Musteri musteri);
        void GetAll(List<Musteri> musteriList);
        void DeleteMusteri(List<Musteri> musteriList, Musteri musteri);
    }
}
