using Searchfight.Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchFight.Browser
{
    class MsnBrowser : BaseBrowser, ISearchBrowser
    {
        public long Search(string word)
        {
            string key = GetSecretKey("bingkey");
            var url = "https://api.cognitive.microsoft.com/bingcustomsearch/v7.0/search" + "?q=" + word + "&customconfig=0";
            AddHeader("Ocp-Apim-Subscription-Key", key);
            var result = GetResponse(url);
            return Convert.ToInt64(result["webPages"]["totalEstimatedMatches"]);
        }
    }
}
