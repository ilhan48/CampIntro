using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = "Apple";
            double price = 15;
            string explanation = "Apple of Amasya";

            string[] fruits = new string[] { };



            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Explanation = "Apple of Amasya";

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Price = 80;                   
            product2.Explanation = "Watermelon of Diyarbakir";

            Product[] products = new Product[] { product1, product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("--------------------------");
            }

            Console.WriteLine("----------- METODLAR ---------");
            // instance - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut", "asdada", 11, 12);
            sepetManager.Ekle2("Ayva", "asdaasddda", 111, 121);
            sepetManager.Ekle2("Nar", "asdadsada", 112, 122);
















        }

    }
}




// Do not repeat yourself - DRY - Clean Code -Best Practice