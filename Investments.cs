using System;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;

namespace Economic
{
    public static class Investments
    {
        public static void Run()
        {
            int calculate = Calculate();
            Hero.MainHero.Gold = Hero.MainHero.Gold + calculate;
            EconomicHelper.SendLogMessage("Investments generate income. Received: " + calculate);
        }

        private static int Calculate()
        {
            int resultReward = 0;
            if (!Hero.MainHero.OwnedWorkshops.IsEmpty())
            {
                int multiplier = Hero.MainHero.OwnedWorkshops.Count;
                int generateValue = new Random().Next(1, 200);
                resultReward = generateValue * multiplier;
            }

            return resultReward;
        }
    }
}