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
                    var PoolPlayer = new PoolPlayerAccount();
                    PoolPlayer.PoolPlayerName = poolPlayerName;
                    PoolPlayer.EmailAddress = emailAddress;
                    Console.WriteLine("Let's start building your rank predictions");
                    Console.WriteLine("What's your predicted rank of the New Jersey Devils");
                    var PredictedDevils = Console.ReadLine();
                    Console.WriteLine($"Your Devil Differential {PoolPlayer.DiffDevils}");
                    break;

                default:
                    break;
            }
        }
    }
}
