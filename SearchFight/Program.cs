using SearchFight.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchFight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length >= 2)
            {
                ISearchService factory = new ServiceConfiguration();
                var services = factory.GetAvailableServices();

                foreach (var arg in args)
                {
                    Console.Write($"{arg}: ");

                    foreach (var service in services)
                        Console.Write($"{service.GetResults(arg)} ");

                    Console.Write("\n");
                }

                foreach (var service in services)
                    Console.WriteLine(service.WinnerToString());

                Console.WriteLine($"Total winner: {factory.GetTotalWinner(services)}");

                //Console.ReadKey();
            }
            else
            {
                Console.WriteLine("There isn't enough words to compare");
            }
        }
    }
}
