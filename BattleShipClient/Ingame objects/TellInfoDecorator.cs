﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipClient.Ingame_objects
{
    public abstract class TellInfoDecorator : ITellOnfo
    {
        protected ITellOnfo _iTellInfo;
        protected Player player;
        public TellInfoDecorator(ITellOnfo iTellInfo, Player play)
        {
            this._iTellInfo = iTellInfo;
            this.player = play;
        }

        public TellInfoDecorator()
        {

        }

        public override string TellInfo()
        {
            if (_iTellInfo != null)
            {
                return _iTellInfo.TellInfo();             
            }
            return "";
        }
    }
}
