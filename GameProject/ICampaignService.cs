using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignService
    {
        void Add(Sales sales);
        void Update(Sales sales);
        void Delete(Sales sales);
    }
}
