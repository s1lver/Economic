using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.Runtime;
using Helpers;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace Economic
{
    public class SubModule : MBSubModuleBase
    {
        public override void OnGameLoaded(Game game, object initializerObject)
        {
            base.OnGameLoaded(game, initializerObject);
            Investments.Run();
        }
    }
}