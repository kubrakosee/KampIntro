using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        ////method injection yapıyoruz
        //public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        //{
        //    //Basvuru bilgilerini değerlendirme
        //    //KonutKrediManager konutKrediManager = new KonutKrediManager();
        //    //konutKrediManager.Hesapla();
        //    krediManager.Hesapla();
        //    loggerService.Log();

        //}

        //çoklu loggerla çalışıyorum
        //method injection yapıyoruz
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            //Basvuru bilgilerini değerlendirme
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }


    }
}
