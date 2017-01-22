using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackRanking   
{
public enum Teams
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
        #region Statics
        private static int ActualDevils = 1;
        private static int ActualIslanders = 2;
        private static int ActualRangers = 3;
        private static int ActualFlyers = 4;
        private static int ActualPenguins = 5;
        private static int ActualBruins = 6;
        private static int ActualSabres = 7;
        private static int ActualCanadiens = 8;
        private static int ActualSenators = 9;
        private static int ActualLeafs = 10;
        private static int ActualThrashers = 11;
        private static int ActualHurricanes = 12;
        private static int ActualPanthers = 13;
        private static int ActualLightning = 14;
        private static int ActualCapitals = 15;
        private static int ActualBlackhawks = 16;
        private static int ActualBJackets = 17;
        private static int ActualRWings = 18;
        private static int ActualPredators = 19;
        private static int ActualBlues = 20;
        private static int ActualFlames = 21;
        private static int ActualAvalanche = 22;
        private static int ActualOilers = 23;
        private static int ActualWild = 24;
        private static int ActualCanucks = 25;
        private static int ActualDucks = 26;
        private static int ActualStars = 27;
        private static int ActualKings = 28;
        private static int ActualCoyotes = 29;
        private static int ActualSharks = 30;
        #endregion

        #region Properties
        public string PoolPlayerName { get; set; }
        public string EmailAddress { get; set; }
        public int PredictedDevils { get; set; }
        public int DiffDevils { get; private set}
        public int PredictedIslanders { get; set; }
        public int PredictedRangers { get; set; }
        public int PredictedFlyers { get; set; }
        public int PredictedPenguins { get; set; }
        public int PredictedBruins { get; set; }
        public int PredictedSabres { get; set; }
        public int PredictedCanadiens { get; set; }
        public int PredictedSenators { get; set; }
        public int PredictedLeafs { get; set; }
        public int PredictedThrashers { get; set; }
        public int PredictedHurricanes { get; set; }
        public int PredictedPanthers { get; set; }
        public int PredictedLightning { get; set; }
        public int PredictedCapitals { get; set; }
        public int PredictedBlackhawks { get; set; }
        public int PredictedBJackets { get; set; }
        public int PredictedRWings { get; set; }
        public int PredictedPredators { get; set; }
        public int PredictedBlues { get; set; }
        public int PredictedFlames { get; set; }
        public int PredictedAvalanche { get; set; }
        public int PredictedOilers { get; set; }
        public int PredictedWild { get; set; }
        public int PredictedCanucks { get; set; }
        public int PredictedDucks { get; set; }
        public int PredictedStars { get; set; }
        public int PredictedKings { get; set; }
        public int PredictedCoyotes { get; set; }
        public int PredictedSharks { get; set; }
        public int ScoreDifferential { get; set; }

        #endregion

        #region Method
        public int DiffDevils(int amount)
        {
            if (PredictedDevils < ActualDevils)
            {
                DiffDevils = (PredictedDevils - ActualDevils);
            }
            return DiffDevils = (ActualDevils - PredictedDevils);
        }



        #endregion

    }
}
