using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] meyveler = new string[] { };

            //Bir class tanımlamak için burda aağıdaki gibi yapmamız gerekiyor.
            //yani classs'ın örneği deniliyor sen class dan 
            //değişken vericeğin zaman new lemen gerekiyor

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya";

            Product urun2 = new Product();
            urun2.Adi = "Armut";
            urun2.Fiyati = 13;
            urun2.Aciklama = "Deveci Armutu";

            Product urun3 = new Product();
            urun3.Adi = "Karpuz";
            urun3.Fiyati = 80;
            urun3.Aciklama = "Diyarbakır";
            //Arrayde oluşturabilirsin array bir veri tipinde istediğin kadar datayı tutan
            //yapıdır.
            Product[] urunler = new Product[] {urun1,urun2,urun3 };
            //type-safe-tip güvenli
            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine("---------------------");
                //Console.WriteLine("Ürün Adı : " +urun.Adi + "Ürün Fiyatı :"+urun.Fiyati);
            }
            Console.WriteLine("---------Metotlar------------");
            //Şuan aşağı yaptığımız instance yani class örneği oluşturmak
            SepetManager sepet = new SepetManager();
            //sepet.Ekle();
            sepet.Ekle(urun1);
            sepet.Ekle(urun2);
            sepet.Ekle(urun3);
            //BÖYLE TEK TEK TANIMLAYINCA BİR DEĞİŞLİK YAPILINCA BÜTÜN SAYFAN PATLIYOR GİBİ 
            // DÜŞÜN DİĞER TÜRLÜ CLASS PARAMETRESİNİ TANMLADIĞIN ZAMAN CLASS A GİDİP
            //STOK ADEDİ EKLERSİN
            sepet.Ekle2("Armut", "test", 56,10);

        }
    }
}
//Dont repeat yourself>Kendini Tekrar Etme-Clean Code,Best Practice
