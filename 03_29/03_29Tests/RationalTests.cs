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
    public class RationalTests
    {
        [TestMethod()]
        public void RationalTestSignNegativPozitiv()
        {
            // arrange
            Rational r = new Rational(-1, 2);

            // act 
            Sign actual = r.Semn;
            Sign expected = Sign.Negativ;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void RationalTestSignPozitivNegativ()
        {
            // arrange
            Rational r = new Rational(1, -2);

            // act 
            Sign actual = r.Semn;
            Sign expected = Sign.Negativ;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void RationalTestSignNegativNegativ()
        {
            // arrange
            Rational r = new Rational(-1, -2);

            // act 
            Sign actual = r.Semn;
            Sign expected = Sign.Pozitiv;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void RationalTestSignPozitivPozitiv()
        {
            // arrange
            Rational r = new Rational(1, 2);

            // act 
            Sign actual = r.Semn;
            Sign expected = Sign.Pozitiv;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            // arrange 
            Rational r1 = new Rational(2, 4);
            Rational r2 = new Rational(-1, 2);
            Rational r3 = new Rational(1, -2);
            Rational r4 = new Rational(-1, -2);
            // act
            string actual1 = r1.ToString();
            string actual2 = r2.ToString();
            string actual3 = r3.ToString();
            string actual4 = r4.ToString();

            string expected1 = "<1 / 2>";
            string expected2 = "<- 1 / 2>";
            string expected3 = "<- 1 / 2>";
            string expected4 = "<1 / 2>";

            // assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected4, actual4);
        }
    }
}