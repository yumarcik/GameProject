using System;
using System.Collections.Generic;
using System.Text;

namespace YumoGameProject
{
    public class Game
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public decimal GamePrice { get; set; }

        public List<Campaign> currentCampaigns = new List<Campaign>();
    }
}
