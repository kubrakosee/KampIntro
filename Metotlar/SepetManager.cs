using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //Metot Yazma
        //naming convention
        //public void Ekle()
        //{
        //    Console.WriteLine("Sepete Eklendi.");
        //}

        //Bana ne ekleyeceğimi söyle demen gerekiyor
        //Ne ekleyeceğimi metoda vermem gerekiyor.Buna parametre deniliyor
        public void Ekle(Product urun)
        {
            Console.WriteLine("Sepete Eklendi : " + urun.Adi);
        }

        //ben burda 3 tane parametre ekliyorum
        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokAdedi)
        {
            Console.WriteLine("Sepete Eklendi : " + urunAdi);
        }
    }
}
