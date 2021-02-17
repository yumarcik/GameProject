using System;
using System.Collections.Generic;
using System.Text;

namespace YumoGameProject
{
    public class UserCheckManager : IUserCheckService
    {
        public bool CheckIfRealPerson(User user)
        {
            return true;
        }

    }
}
