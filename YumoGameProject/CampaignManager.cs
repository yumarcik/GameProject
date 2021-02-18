using System;
using System.Collections.Generic;
using System.Text;

namespace YumoGameProject
{
    public class CampaignManager
    {
        public void AddCampaign(Campaign campaign, Game game)
        {
            game.currentCampaigns.Add(campaign);
            Console.WriteLine(campaign.DiscountPercent + "% " + campaign.CampaignName + " on " + game.GameName);
        }

        public void DeleteCampaign(Campaign campaign, Game game)
        {
            game.currentCampaigns.Remove(campaign);
            Console.WriteLine("The " + campaign.DiscountPercent + "% " + campaign.CampaignName + " on " + 
                game.GameName + " ended.");
        }

        public void UpdateCampaign(Campaign campaign, Game game)
        {

        }
    }
}
