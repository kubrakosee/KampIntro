using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {
            //"Kübra","Ebru","Arda"
            //};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);

            //isimler = new string[5];
            //isimler[4] = "Döndü";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);
            /*
             şimdi yukarda yaptığımızı koleksiyonlar da yapalım
             */
            List<string> isimler2 = new List<string>{
            "Kübra","Ebru","Arda"
            };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Döndü");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);
            /*Kolekisyonlarda sonradan eklenince değer kaybetmemizi
             * sağlamaz.
            */
        }
    }
}
