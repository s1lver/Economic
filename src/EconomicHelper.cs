using TaleWorlds.Core;

namespace Economic
{
    public static class EconomicHelper
    {
        public static void SendLogMessage(string message)
        {
            InformationManager.DisplayMessage(new InformationMessage(message));
        }
    }
}