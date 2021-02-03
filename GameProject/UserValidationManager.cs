using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1999 && gamer.FirstName == "İLHAN" && gamer.LastName == "ÖDÜN" && gamer.IdentityNumber == 11234)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}
