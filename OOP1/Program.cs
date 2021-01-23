using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product Oluşturmak İçin ne yapıyorduk
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //2.yol
            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                UnitsInStock = 5,
                ProductName = "Kalem",
                UnitPrice = 35
            };

            //elinizdeki ürünü eklemek için simüle etmek istiyorsunuz.
            //Referansı nasıl oluşturduruyorduk.Sizin Heapde oluşabilmesi
            //için onu new lemeniz gerekiyordu.
            /**tam olarak diyorsun ki ProductManager türündeki productManager
             * yeni bir referans numarası almış ProductManager demektir **/

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product1);

        }
    }
}
