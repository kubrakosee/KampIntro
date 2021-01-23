using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
   public class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] geciciDizi = items;
            //eleman sayısı
            items = new T[items.Length+1];

            for (int i = 0; i < geciciDizi.Length; i++)
            {
                items[i] = geciciDizi[i];
            }
            items[items.Length - 1]=item;
        }
    }
}
