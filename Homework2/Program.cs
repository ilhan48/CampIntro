using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Product product1 = new Product(); // Created a object
        product1.ProductName = "Samsung Galaxy Tab S6 LİTE";
        product1.ProductSerialNo = "12345";
        product1.ProductPrice = 2200;

        Product product2 = new Product(); // Created a object
        product2.ProductName = "Huawei Mate 20 LİTE";
        product2.ProductSerialNo = "67789";
        product2.ProductPrice = 3500;

        Product product3 = new Product(); // Created a object
        product3.ProductName = "ASUS ROG STRİX";
        product3.ProductSerialNo = "1234510101";
        product3.ProductPrice = 17000;


        Product[] products = new Product[] // Created a list
        {
      product1, product2, product3
        };
        for (int i = 0; i < products.Length; i++) // write product Name with the for loop
        {
            Console.WriteLine(products[i].ProductName);
        }
        Console.WriteLine("For loop is over...");
        foreach (var i in products)       // write product Name and product price with the foreach loop
        {
            Console.WriteLine(i.ProductName + " : " + i.ProductPrice + "TL");
        }
        Console.WriteLine("Foreach loop is over...");
        int a = 0;
        while (a < products.Length)       // write product serial no with while loop
        {
            Console.WriteLine(products[a].ProductSerialNo);
            a++;
        }
        Console.WriteLine("While loop is over...");
    }
}



class Product //class definition
{
    public string ProductName { get; set; }

    public string ProductSerialNo { get; set; }

    public int ProductPrice { get; set; }
}