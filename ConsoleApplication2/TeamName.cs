using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackRanking   
{

    public class PoolPlayerAccount
    {
        #region Statics
        private static int ActualDevils = 1;
        private static int ActualIslanders = 2;
        private static int ActualRangers = 3;
        private static int ActualFlyers = 4;
        ///private static int ActualPenguins = 5;
        ///private static int ActualBruins = 6;
        ///private static int ActualSabres = 7;
        ///private static int ActualCanadiens = 8;
        ///private static int ActualSenators = 9;
        ///private static int ActualLeafs = 10;
        ///private static int ActualThrashers = 11;
        ///private static int ActualHurricanes = 12;
        ///private static int ActualPanthers = 13;
        ///private static int ActualLightning = 14;
        ///private static int ActualCapitals = 15;
        ///private static int ActualBlackhawks = 16;
        ///private static int ActualBJackets = 17;
        ///private static int ActualRWings = 18;
        ///private static int ActualPredators = 19;
        ///private static int ActualBlues = 20;
        ///private static int ActualFlames = 21;
        ///private static int ActualAvalanche = 22;
        ///private static int ActualOilers = 23;
        ///private static int ActualWild = 24;
        ///private static int ActualCanucks = 25;
        ///private static int ActualDucks = 26;
        ///private static int ActualStars = 27;
        ///private static int ActualKings = 28;
        ///private static int ActualCoyotes = 29;
        ///private static int ActualSharks = 30;
        #endregion

        #region Properties
        public string PoolPlayerName { get; set; }
        public string EmailAddress { get; set; }
        public int PredictedDevils { get; set; }
        public int PredictedIslanders { get; set; }
        public int PredictedRangers { get; set; }
        public int PredictedFlyers { get; set; }
        ///public int PredictedPenguins { get; set; }
        ///public int PredictedBruins { get; set; }
        ///public int PredictedSabres { get; set; }
        ///public int PredictedCanadiens { get; set; }
        ///public int PredictedSenators { get; set; }
        ///public int PredictedLeafs { get; set; }
        /// public int PredictedThrashers { get; set; }
        ///public int PredictedHurricanes { get; set; }
        ///public int PredictedPanthers { get; set; }
        ///public int PredictedLightning { get; set; }
        ///public int PredictedCapitals { get; set; }
        ///public int PredictedBlackhawks { get; set; }
        ///public int PredictedBJackets { get; set; }
        ///public int PredictedRWings { get; set; }
        ///public int PredictedPredators { get; set; }
        ///public int PredictedBlues { get; set; }
        ///public int PredictedFlames { get; set; }
        ///public int PredictedAvalanche { get; set; }
        ///public int PredictedOilers { get; set; }
        ///public int PredictedWild { get; set; }
        ///public int PredictedCanucks { get; set; }
        ///public int PredictedDucks { get; set; }
        ///public int PredictedStars { get; set; }
        ///public int PredictedKings { get; set; }
        ///public int PredictedCoyotes { get; set; }
        ///public int PredictedSharks { get; set; }
        private int calcDevils;
        public int CalcDevils {
            get
            {
                if (PredictedDevils < ActualDevils)
                {calcDevils = ActualDevils - PredictedDevils;}
                else{calcDevils = PredictedDevils - ActualDevils;}
                return calcDevils;
            }
        }
        private int calcIslanders;
        public int CalcIslanders
        {
            get
            {
                if (PredictedIslanders < ActualIslanders)
                { calcIslanders = ActualIslanders - PredictedIslanders; }
                else { calcIslanders = PredictedIslanders - ActualIslanders; }
                return calcIslanders;
            }
        }
        private int calcRangers;
        public int CalcRangers
        {
            get
            {
                if (PredictedRangers < ActualRangers)
                { calcRangers = ActualRangers - PredictedRangers; }
                else { calcRangers = PredictedRangers - ActualRangers; }
                return calcRangers;
            }
        }
        private int calcFlyers;
        public int CalcFlyers
        {
            get
            {
                if (PredictedFlyers < ActualFlyers)
                { calcFlyers = ActualFlyers - PredictedFlyers; }
                else { calcFlyers = PredictedFlyers - ActualFlyers; }
                return calcFlyers;
            }
        }
        private int score;
        public int ScoreDifferential
        {
            get
            {
                score = CalcDevils + CalcIslanders + CalcRangers + CalcFlyers;
                return score;
            }
        }
        
        #endregion

       

    }
    #region Methods
    
    #endregion
}
