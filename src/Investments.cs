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
                int workshopMultiplier = Hero.MainHero.OwnedWorkshops.Count;
                foreach (var workshop in Hero.MainHero.OwnedWorkshops)
                {
                    if (workshop.IsRunning)
                    {
                        int capital = workshop.Capital / 100 * 1;
                        workshopMultiplier += capital;
                    }
                }
                int multiplier = new Random().Next(1, 10);
                resultReward = workshopMultiplier * multiplier;
            }

            return resultReward;
        }
    }
}
