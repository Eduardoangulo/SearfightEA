using SearchFight.Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchFight.Service
{
    class MsnService : SearchService
    {
        public override string Name => "Msn Search";
        public override ISearchBrowser CreateBrowser()
        {
            return new MsnBrowser();
        }
    }
}
