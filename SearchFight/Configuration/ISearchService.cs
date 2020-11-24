using SearchFight.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchFight.Configuration
{
    interface ISearchService
    {
        SearchService[] GetAvailableServices();

        string GetTotalWinner(SearchService[] services);
    }
}
