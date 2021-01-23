using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("elma");
            
            

            //List<string> liste = new List<string>();
            //liste.Add("armut");
            //Console.WriteLine(liste.Count);

        }
    }
}
