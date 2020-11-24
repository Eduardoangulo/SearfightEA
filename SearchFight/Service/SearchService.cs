using SearchFight.Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchFight.Service
{
    abstract class SearchService
    {
        public abstract ISearchBrowser CreateBrowser();
        public abstract string Name { get; }

        private string Winner = "Without results";

        private long WinnerResults = 0;

        public string GetWinner()
        {
            return Winner;
        }

        public string WinnerToString()
        {
            return $"{Name} winner : {Winner}";
        }

        public string GetResults(string word)
        {
            var engine = CreateBrowser();

            var results = engine.Search(word);

            SetWinner(word, results);

            return $"{Name} : {results}";
        }

        private void SetWinner(string word, long results)
        {
            if (results > WinnerResults)
            {
                Winner = word;
                WinnerResults = results;
            }
        }
    }
}
