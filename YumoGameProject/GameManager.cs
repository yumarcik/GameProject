using System;
using System.Collections.Generic;
using System.Text;

namespace YumoGameProject
{
    public class GameManager
    {
        public void Buy(Game game, User user)
        {
            user.ownedGames.Add(game);
            Console.WriteLine(user.UserName + " bought " + game.GameName);
        }
    }
}
