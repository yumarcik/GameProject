using System;

namespace YumoGameProject
{
    class Program
    {
        static void Main(string[] args)
        {            
            UserManager user = new UserManager();
            user.Register(new User {BirthDate = new DateTime(1996,11,18), FirstName = "yağmur", 
                LastName = "polat", UserName = "yumarcik", NationalityId = "39325943402" });

            GameManager game = new GameManager();
            game.Buy(new Game { GameName = "Counter Strike"}, new User
            {
                BirthDate = new DateTime(1996, 11, 18),
                FirstName = "yağmur",
                LastName = "polat",
                UserName = "yumarcik",
                NationalityId = "39325943402"
            });
            
        }
    }
}
