using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Added in sepet : " + product.Name);


        }
        public void Ekle2(string productName, string Explanation, int price, int stockNum)
        {
            Console.WriteLine("added in sepet : " + productName);
        }
    }
}
