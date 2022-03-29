using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03_29;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_29.Tests
{
    [TestClass()]
    public class UtilTests
    {
        [TestMethod()]
        public void GcdTest()
        {
            // arrange
            uint a = 15;
            uint b = 20;
            // act 
            uint actual = Util.Gcd(a, b);
            uint expected = 5;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}