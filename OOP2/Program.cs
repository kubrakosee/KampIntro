using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kübra Köse
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "160";
            musteri1.Adi = "Kübra";
            musteri1.Soyadi = "Köse";
            musteri1.TcNo = "111111111111";


            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54369";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";


            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID
            //peki biz müsteri1.SirketAdını nasıl ele almalıydık.
            //gercekmüsteri diye bir tane class oluştur.
            //sonra tuzelmusteri diye bir tane class oluştur.


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            
            
        }
    }
}
