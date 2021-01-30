using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // İLHAN ÖDÜN
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.MusteriNo = "1233";
            customer1.Adi = "İlhan";
            customer1.Soyadi = "Ödün";
            customer1.TcNo = "1234567890";

            // Kodlama.io
            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.MusteriNo = "54321";
            customer2.SirketAdi = "Kodlama.io";
            customer2.VergiNo = "1234567890";





            // Gerçek Müşteri - Tüzel Müşteri
            //SOLID



            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }


    }
}
