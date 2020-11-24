using SearchFight.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchFight.Configuration
{
    class ServiceConfiguration : ISearchService
    {
        public SearchService[] GetAvailableServices()
        {
            return new SearchService[] {
                new GoogleService(),
                new MsnService()
            };
        }

        public string GetTotalWinner(SearchService[] services)
        {
            var winners = new List<string>();

            foreach (var service in services)
                winners.Add(service.GetWinner());

            return winners.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
        }
    }
}
