﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackRanking
{
    public static class PoolManager
    {
        #region enum
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
        #endregion
        public static PoolPlayerAccount CreateAccount(string poolPlayerName, string emailAddress, int predictedDevils, int predictedIslanders, int predictedRangers, int predictedFlyers, int predictedPenguins, int predictedBruins, int predictedSabres, int predictedCanadiens, int predictedSenators, int predictedLeafs, int predictedThrashers, int predictedHurricanes, int predictedPanthers, int predictedLightning, int predictedCapitals, int predictedBlackhawks, int predictedBJackets, int predictedRWings, int predictedPredators, int predictedBlues, int predictedFlames, int predictedAvalanche, int predictedOilers, int predictedWild, int predictedCanucks, int predictedDucks, int predictedStars, int predictedKings, int predictedCoyotes, int predictedSharks)
        {
            var poolplayerAccount = new PoolPlayerAccount();
            poolplayerAccount.PoolPlayerName = poolPlayerName;
            poolplayerAccount.EmailAddress = emailAddress;
            poolplayerAccount.PredictedDevils = predictedDevils;
            poolplayerAccount.PredictedIslanders = predictedIslanders;
            poolplayerAccount.PredictedRangers = predictedRangers;
            poolplayerAccount.PredictedFlyers = predictedFlyers;
            poolplayerAccount.PredictedPenguins = predictedPenguins;
            poolplayerAccount.PredictedBruins = predictedBruins;
            poolplayerAccount.PredictedSabres = predictedSabres;
            poolplayerAccount.PredictedCanadiens = predictedCanadiens;
            poolplayerAccount.PredictedSenators = predictedSenators;
            poolplayerAccount.PredictedLeafs = predictedLeafs;
            poolplayerAccount.PredictedThrashers = predictedThrashers;
            poolplayerAccount.PredictedHurricanes = predictedHurricanes;
            poolplayerAccount.PredictedPanthers = predictedPanthers;
            poolplayerAccount.PredictedLightning = predictedLightning;
            poolplayerAccount.PredictedCapitals = predictedCapitals;
            poolplayerAccount.PredictedBlackhawks = predictedBlackhawks;
            poolplayerAccount.PredictedBJackets = predictedBJackets;
            poolplayerAccount.PredictedRWings = predictedRWings;
            poolplayerAccount.PredictedPredators = predictedPredators;
            poolplayerAccount.PredictedBlues = predictedBlues;
            poolplayerAccount.PredictedFlames = predictedFlames;
            poolplayerAccount.PredictedAvalanche = predictedAvalanche;
            poolplayerAccount.PredictedOilers = predictedOilers;
            poolplayerAccount.PredictedWild = predictedWild;
            poolplayerAccount.PredictedCanucks = predictedCanucks;
            poolplayerAccount.PredictedDucks = predictedDucks;
            poolplayerAccount.PredictedStars = predictedStars;
            poolplayerAccount.PredictedKings = predictedKings;
            poolplayerAccount.PredictedCoyotes = predictedCoyotes;
            poolplayerAccount.PredictedSharks = predictedSharks;
            return poolplayerAccount;
        }
    }
}
