using System;

namespace YumoGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager user = new UserManager();
            user.Register(new User { BirthDate = new DateTime(1996, 11, 18), FirstName = "Yağmur",
                LastName = "Polat", UserName = "yumarcik", NationalityId = "10101010101" });

            GameManager game = new GameManager();
            game.Buy(new Game { GameName = "Counter Strike" }, new User
            {
                BirthDate = new DateTime(1996, 11, 18),
                FirstName = "yağmur",
                LastName = "polat",
                UserName = "yumarcik",
                NationalityId = "39325943402"
            });

            CampaignManager campaign = new CampaignManager();
            campaign.AddCampaign(new Campaign { CampaignName = "Halloween Discount", DiscountPercent = 20 }, 
                new Game { GameName = "Overcooked2" }) ;
            campaign.DeleteCampaign(new Campaign { CampaignName = "Halloween Discount", DiscountPercent = 20 },
                new Game { GameName = "Overcooked2" });
        }
    }
}
