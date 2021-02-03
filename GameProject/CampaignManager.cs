using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Sales sales)
        {
            Console.WriteLine("Added");
        }



        public void Delete(Sales sales)
        {
            Console.WriteLine("Deleted");
        }

 
        public void Update(Sales sales)
        {
            Console.WriteLine("Updated");
        }


    }
}
