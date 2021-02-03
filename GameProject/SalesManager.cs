using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SalesManager : ICampaignService

    {
        ICampaignService _campaignService;


        public SalesManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

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
