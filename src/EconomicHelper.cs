using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace Economic
{
    public static class EconomicHelper
    {
        /**
         * Sending a message to the general log
         */
        public static void SendLogMessage(string message)
        {
            MBInformationManager.AddQuickInformation(new TextObject(message));
        }
    }
}
