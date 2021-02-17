using System;
using System.Collections.Generic;
using System.Text;

namespace YumoGameProject
{
    interface IUserCheckService
    {
        bool CheckIfRealPerson(User user);
    }
}
