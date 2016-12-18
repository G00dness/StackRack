using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackRanking   
{
public enum Team
    {
        New_Jersey_Devils,
        New_York_Islanders,
        New_York_Rangers,
        Philadelphia_Flyers,
        Pittsburgh_Penguins,
        Boston_Bruins,
        Buffalo_Sabres,
        Montreal_Canadiens,
        Ottawa_Senators,
        Toronto_Maple_Leafs,
        Atlanta_Thrashers,
        Carolina_Hurricanes,
        Florida_Panthers,
        Tampa_Bay_Lightning,
        Washington_Capitals,
        Chicago_Blackhawks,
        Columbus_Blue_Jackets,
        Detroit_Red_Wings,
        Nashville_Predators,
        St_Louis_Blues,
        Calgary_Flames,
        Colorado_Avalanche,
        Edmonton_Oilers,
        Minnesota_Wild,
        Vancouver_Canucks,
        Anaheim_Ducks,
        Dallas_Stars,
        Los_Angeles_Kings,
        Phoenix_Coyotes,
        San_Jose_Sharks
    }
    public class PoolPlayerAccount
    {
        #region Properties
        public string PoolPlayerName { get; set; }
        public string EmailAddress { get; set; }
        public Team PredictedTeamOne { get; set; }
        public int PredictedRankOne { get; set; }
        public Team PredictedTeamTwo { get; set; }
        public int PredictedRankTwo { get; set; }
        public Team PredictedTeamThree { get; set; }
        public int PredictedRankThree { get; set; }

        #endregion
        ///No Methods for TeamAccount. Method must be done between Classes. Can that be done?

    }
}
