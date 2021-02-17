using System;
using System.Collections.Generic;
using System.Text;

namespace YumoGameProject
{
    public class UserManager
    {
        List<User> users = new List<User>();
        
        public void Register(User user)
        {
            UserCheckManager _userCheckManager = new UserCheckManager();
            if (_userCheckManager.CheckIfRealPerson(user))
            {
                users.Add(user);
                Console.WriteLine(user.UserName + " registered !");
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }

        public void Update(User user)
        {

        }

        public void Delete(User user)
        {
            users.Remove(user);
        }

        
    }
}
