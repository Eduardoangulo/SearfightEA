using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SearchFightTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestProgramSearch()
        {
            string[] args = { "java", ".net", };
            SearchFight.Program.Main(args);
        }
    }
}
