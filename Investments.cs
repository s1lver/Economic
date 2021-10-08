using System;
using TaleWorlds.CampaignSystem;

namespace Economic
{
    public static class Investments
    {
        public static void Calculate()
        {
            var heroGold = Hero.MainHero.Gold;
            Random random = new Random();
            int generateValue = random.Next(1, 200);
            Hero.MainHero.Gold = heroGold + generateValue;
            EconomicHelper.SendLogMessage("Investments generate income. Received: "+ generateValue + " Your account: " + heroGold.ToString());
        }
    }
}