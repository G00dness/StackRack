using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackRanking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("Welcome to the Stack Rank Tool");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Create a new pool player");
            Console.WriteLine("2. Check pool scores");
            var select = Console.ReadLine();
            switch (select)
            {
                case "1":
                    Console.WriteLine("To begin, let's start by creating your Player Account");
                    Console.WriteLine("What do you want to name your Pool Player Name?");
                    var poolPlayerName = Console.ReadLine();
                    Console.WriteLine("What's your email address?");
                    var emailAddress = Console.ReadLine();
                    Console.WriteLine("Let's start building your rank predictions");
                    Console.WriteLine("What's your predicted rank of the New Jersey Devils?");
                    var PredictedDevilsStr = Console.ReadLine();
                    var PredictedDevils = Convert.ToInt32(PredictedDevilsStr);
                    Console.WriteLine("What's your predicted rank of the New York Islanders?");
                    var PredictedIslandersStr = Console.ReadLine();
                    var PredictedIslanders = Convert.ToInt32(PredictedIslandersStr);
                    Console.WriteLine("What's your predicted rank of the New York Rangers?");
                    var PredictedRangersStr = Console.ReadLine();
                    var PredictedRangers = Convert.ToInt32(PredictedRangersStr);
                    Console.WriteLine("What's your predicted rank of the Pittsburgh Flyers?");
                    var PredictedFlyersStr = Console.ReadLine();
                    var PredictedFlyers = Convert.ToInt32(PredictedFlyersStr);
                    Console.WriteLine("What's your predicted rank of the Pittsburgh Penguins?");
                    var PredictedPenguinsStr = Console.ReadLine();
                    var PredictedPenguins = Convert.ToInt32(PredictedPenguinsStr);
                    Console.WriteLine("What's your predicted rank of the Boston Bruins?");
                    var PredictedBruinsStr = Console.ReadLine();
                    var PredictedBruins = Convert.ToInt32(PredictedBruinsStr);
                    Console.WriteLine("What's your predicted rank of the Buffalo Sabres?");
                    var PredictedSabresStr = Console.ReadLine();
                    var PredictedSabres = Convert.ToInt32(PredictedSabresStr);
                    Console.WriteLine("What's your predicted rank of the Montreal Canadiens?");
                    var PredictedCanadiensStr = Console.ReadLine();
                    var PredictedCanadiens = Convert.ToInt32(PredictedCanadiensStr);
                    Console.WriteLine("What's your predicted rank of the Ottawa Senators?");
                    var PredictedSenatorsStr = Console.ReadLine();
                    var PredictedSenators = Convert.ToInt32(PredictedSenatorsStr);
                    Console.WriteLine("What's your predicted rank of the Toronto Leafs?");
                    var PredictedLeafsStr = Console.ReadLine();
                    var PredictedLeafs = Convert.ToInt32(PredictedLeafsStr);
                    Console.WriteLine("What's your predicted rank of the Atlanta Thrashers?");
                    var PredictedThrashersStr = Console.ReadLine();
                    var PredictedThrashers = Convert.ToInt32(PredictedThrashersStr);
                    Console.WriteLine("What's your predicted rank of the Carolina Hurricanes?");
                    var PredictedHurricanesStr = Console.ReadLine();
                    var PredictedHurricanes = Convert.ToInt32(PredictedHurricanesStr);
                    Console.WriteLine("What's your predicted rank of the Florida Panthers?");
                    var PredictedPanthersStr = Console.ReadLine();
                    var PredictedPanthers = Convert.ToInt32(PredictedPanthersStr);
                    Console.WriteLine("What's your predicted rank of the Tampa Bay Lightning?");
                    var PredictedLightningStr = Console.ReadLine();
                    var PredictedLightning = Convert.ToInt32(PredictedLightningStr);
                    Console.WriteLine("What's your predicted rank of the Washington Capitals?");
                    var PredictedCapitalsStr = Console.ReadLine();
                    var PredictedCapitals = Convert.ToInt32(PredictedCapitalsStr);
                    Console.WriteLine("What's your predicted rank of the Chicago Blackhawks?");
                    var PredictedBlackhawksStr = Console.ReadLine();
                    var PredictedBlackhawks = Convert.ToInt32(PredictedBlackhawksStr);
                    Console.WriteLine("What's your predicted rank of the Columbus Blue Jackets?");
                    var PredictedBJacketsStr = Console.ReadLine();
                    var PredictedBJackets = Convert.ToInt32(PredictedBJacketsStr);
                    Console.WriteLine("What's your predicted rank of the Detroit Red Wings?");
                    var PredictedRWingsStr = Console.ReadLine();
                    var PredictedRWings = Convert.ToInt32(PredictedRWingsStr);
                    Console.WriteLine("What's your predicted rank of the Nashville Predators?");
                    var PredictedPredatorsStr = Console.ReadLine();
                    var PredictedPredators = Convert.ToInt32(PredictedPredatorsStr);
                    Console.WriteLine("What's your predicted rank of the St. Louis Blues?");
                    var PredictedBluesStr = Console.ReadLine();
                    var PredictedBlues = Convert.ToInt32(PredictedBluesStr);
                    Console.WriteLine("What's your predicted rank of the Calgary Flames?");
                    var PredictedFlamesStr = Console.ReadLine();
                    var PredictedFlames = Convert.ToInt32(PredictedFlamesStr);
                    Console.WriteLine("What's your predicted rank of the Colorado Avalanche?");
                    var PredictedAvalancheStr = Console.ReadLine();
                    var PredictedAvalanche = Convert.ToInt32(PredictedAvalancheStr);
                    Console.WriteLine("What's your predicted rank of the Edmonton Oilers?");
                    var PredictedOilersStr = Console.ReadLine();
                    var PredictedOilers = Convert.ToInt32(PredictedOilersStr);
                    Console.WriteLine("What's your predicted rank of the Minnesota Wild?");
                    var PredictedWildStr = Console.ReadLine();
                    var PredictedWild = Convert.ToInt32(PredictedWildStr);
                    Console.WriteLine("What's your predicted rank of the Vancouver Canucks?");
                    var PredictedCanucksStr = Console.ReadLine();
                    var PredictedCanucks = Convert.ToInt32(PredictedCanucksStr);
                    Console.WriteLine("What's your predicted rank of the Anaheim Ducks?");
                    var PredictedDucksStr = Console.ReadLine();
                    var PredictedDucks = Convert.ToInt32(PredictedDucksStr);
                    Console.WriteLine("What's your predicted rank of the Dallas Stars?");
                    var PredictedStarsStr = Console.ReadLine();
                    var PredictedStars = Convert.ToInt32(PredictedStarsStr);
                    Console.WriteLine("What's your predicted rank of the Los Angeles Kings?");
                    var PredictedKingsStr = Console.ReadLine();
                    var PredictedKings = Convert.ToInt32(PredictedKingsStr);
                    Console.WriteLine("What's your predicted rank of the Phoenix Coyotes?");
                    var PredictedCoyotesStr = Console.ReadLine();
                    var PredictedCoyotes = Convert.ToInt32(PredictedCoyotesStr);
                    Console.WriteLine("What's your predicted rank of the San Jose Sharks?");
                    var PredictedSharksStr = Console.ReadLine();
                    var PredictedSharks = Convert.ToInt32(PredictedSharksStr);
                    var myPoolAccount = PoolManager.CreateAccount(poolPlayerName, emailAddress, PredictedDevils, PredictedIslanders, PredictedRangers, PredictedFlyers, PredictedPenguins, PredictedBruins, PredictedSabres, PredictedCanadiens, PredictedSenators, PredictedLeafs, PredictedThrashers, PredictedHurricanes, PredictedPanthers, PredictedLightning, PredictedCapitals, PredictedBlackhawks, PredictedBJackets, PredictedRWings, PredictedPredators, PredictedBlues, PredictedFlames, PredictedAvalanche, PredictedOilers, PredictedWild, PredictedCanucks, PredictedDucks, PredictedStars, PredictedKings, PredictedCoyotes, PredictedSharks);
                    Console.WriteLine($"Thank you for your rankings, {myPoolAccount.PoolPlayerName}");
                    break;
                default:
                    break;
            }
        }
    }
}
