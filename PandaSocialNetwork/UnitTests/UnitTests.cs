using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    using PandaSocialNetworkLibrary;
    [TestClass]
    public class UnitTests
    {
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EmailWithoutAtSign()
        {
            Panda panda = new Panda("panda", "pandaabv.bg", GenderType.Male);
            bool validEmail = true;

            if ()
            {
                
            }
        }
    }
}
