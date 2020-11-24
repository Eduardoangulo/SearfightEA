using Searchfight.Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchFight.Browser
{
    class GoogleBrowser : BaseBrowser, ISearchBrowser
    {
        public long Search(string word)
        {
            string key = GetSecretKey("googlekey");
            var url = "https://www.googleapis.com/customsearch/v1?key=" + key + "&q=" + word;
            var result = GetResponse(url);
            return Convert.ToInt64(result["queries"]["request"][0]["totalResults"]);
        }
    }
}
