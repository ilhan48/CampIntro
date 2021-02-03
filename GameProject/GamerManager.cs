using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
    //MicroService
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {

            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Added");
            }
            else
            {
                Console.WriteLine("NOT ADDED");
            }
            
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Updated");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Deleted");
        }
    }
}
