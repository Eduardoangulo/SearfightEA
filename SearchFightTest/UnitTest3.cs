using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SearchFightTest
{
    /// <summary>
    /// Descripción resumida de UnitTest3
    /// </summary>
    [TestClass]
    public class UnitTest3
    {
        public UnitTest3()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        [TestMethod]
        public void TestProgramSearchWithNoLanguages()
        {
            string[] args = { "spiderman", "coffee", };
            SearchFight.Program.Main(args);
        }
    }
}
