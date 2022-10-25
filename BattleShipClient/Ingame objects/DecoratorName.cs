using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipClient.Ingame_objects
{
    public class DecoratorName : TellInfoDecorator
    {
        public DecoratorName(ITellOnfo iTellInfo) : base(iTellInfo)
        {
        }

        public override string TellInfo()
        {
            if (player != null)
            {
                return base.player.Name;
            }
            else
            {
                return "";
            }
        }
    }

}
