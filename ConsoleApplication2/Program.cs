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
            Console.WriteLine("To begin, let's start by creating your Player Account");
            Console.WriteLine("What do you want to name your Pool Player Name?");
            var poolPlayerName = Console.ReadLine();
            Console.WriteLine("What's your email address?");
            var emailAddress = Console.ReadLine();
            var PoolPlayer = new PoolPlayerAccount();
            PoolPlayer.PoolPlayerName = poolPlayerName;
            PoolPlayer.EmailAddress = emailAddress;
            Console.WriteLine($"Welcome, {PoolPlayer.PoolPlayerName}");
            Console.WriteLine("Let's start building your rank predictions");
            Console.WriteLine("Select which team you want to rank one:");
            var predictedTeamOne = Console.ReadLine();
            PoolPlayer.PredictedTeamOne = Team.Anaheim_Ducks;
            Console.WriteLine("Select next team you want to rank two:");
            var predictedTeamTwo = Console.ReadLine();
            PoolPlayer.PredictedTeamTwo = Team.Atlanta_Thrashers;
            Console.WriteLine("Select next team you want to rank three:");
            var predictedTeamThree = Console.ReadLine();
            PoolPlayer.PredictedTeamThree = Team.Boston_Bruins;
            Console.WriteLine($"Just to recap. You've ranked 1: {PoolPlayer.PredictedTeamOne} 2: {PoolPlayer.PredictedTeamTwo} 3: {PoolPlayer.PredictedTeamThree} ");

        }
    }
}
