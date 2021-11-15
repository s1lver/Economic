using TaleWorlds.Core;

namespace Economic
{
    public static class EconomicHelper
    {
        /**
         * Sending a message to the general log
         */
        public static void SendLogMessage(string message)
        {
            InformationManager.DisplayMessage(new InformationMessage(message));
        }
    }
}
