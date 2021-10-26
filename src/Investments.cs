using System;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;

namespace Economic
{
    public static class Investments
    {
        public static void Run()
        {
            if (!Hero.MainHero.OwnedWorkshops.IsEmpty())
            {
                int calculate = Calculate();
                Hero.MainHero.Gold = Hero.MainHero.Gold + calculate;
                EconomicHelper.SendLogMessage("Investments generate income. Received: " + calculate);
            }
        }

        /**
         * Calculation of the resulting profit from investment in the workshop
         */
        private static int Calculate()
        {
            int workshopMultiplier = Hero.MainHero.OwnedWorkshops.Count;
            int multiplier = new Random().Next(1, 10);
            foreach (var workshop in Hero.MainHero.OwnedWorkshops)
            {
                if (workshop.IsRunning)
                {
                    int capital = workshop.Capital / 100 * 1;
                    workshopMultiplier += capital;
                }
            }

            return workshopMultiplier * multiplier;
        }
    }
}
