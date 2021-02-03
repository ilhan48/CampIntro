using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1999, FirstName = "İLHAN", LastName = "ÖDÜN", IdentityNumber = 11234 });

            SalesManager salesManager = new SalesManager(new NEWProduct());
            salesManager.Add(new Sales { ProductId = 1, ProductName = "ENGIN DEMIROG's MANHOOD" });
            

        }
    }
}
