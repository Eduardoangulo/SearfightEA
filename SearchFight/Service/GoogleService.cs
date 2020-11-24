using SearchFight.Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchFight.Service
{
    class GoogleService : SearchService
    {
        public override string Name => "Google";

        public override ISearchBrowser CreateBrowser()
        {
            return new GoogleBrowser();
        }
    }
}
