using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionLib;

namespace FractionTesting1
{
    [TestClass]
    public class FractionTest
    {
        int expectedTop = 5, expectedBottom = 9;
        [TestMethod]
        public void TestFraction()
        {
            //arrange
            //act
            Fraction fraction = new Fraction(expectedTop, expectedBottom);
            Fraction fraction1 = new Fraction(5, 9);
            Fraction fraction2 = new Fraction(5);
            Fraction fraction3 = new Fraction();
            //assert
            //compare the expectedTop with Top
            Assert.AreEqual(expectedTop, fraction1.Top, "Fraction Top expected to be {0} but was found to be {1}");
            Assert.AreEqual(expectedTop, fraction2.Top, "Fraction Top expected to be {0} but was found to be {1}");
            Assert.AreEqual(0, fraction3.Top, "Fraction Top expected to be {0} but was found to be {1}");
            //compare the expectedBottom with Bottom
            Assert.AreEqual(expectedBottom, fraction1.Bottom, "Fraction Bottom expected to be {0} but was found to be {1}");
            Assert.AreEqual(1, fraction2.Bottom, "Fraction Bottom expected to be {0} but was found to be {1}");
            Assert.AreEqual(1, fraction3.Bottom, "Fraction Bottom expected to be {0} but was found to be {1}");
        }
        
        [TestMethod]
        public void Test_ToString()
        {
            //arrange
            int top1 = 2, bottom2 = 3;
            string expectedString = string.Format("{0}/{1}", top1, bottom2);
            //act
            Fraction fraction2 = new Fraction(top1, bottom2);
            string actualValue = fraction2.ToString();
            //assert
            Assert.AreEqual(expectedString, actualValue, "ToString method failed");
        }
        [TestMethod]
        public void Test_Add()
        {
            //arrange
            Fraction fraction1 = new Fraction(3, 5);
            Fraction fraction2 = new Fraction(1, 2);
            Fraction fractionActual = fraction1 + fraction2;
            Fraction fractionExpect = new Fraction(11, 10);
            Assert.AreEqual(fractionExpect.Top, fractionActual.Top, "FAILED");
            Assert.AreEqual(fractionExpect.Bottom, fractionActual.Bottom, "FAILED");

        }
        [TestMethod]
        public void Test_Subtraction_WithoutException()
        {
            //arrange
            Fraction fraction1 = new Fraction(3, 5);
            Fraction fraction2 = new Fraction(1, 2);
            Fraction fraction3 = fraction1 - fraction2;
            Fraction fractionExpect = new Fraction(1, 10);
            Assert.AreEqual(fractionExpect.Top, fraction3.Top,"FAILED");
            Assert.AreEqual(fractionExpect.Bottom, fraction3.Bottom, "FAILED");
        }

        [TestMethod]
        public void Test_Subtraction_WithException()
        {
            //arrange
            Fraction fraction1 = new Fraction(3, 5);
            Fraction fraction2 = new Fraction(1, 2);
            Fraction fraction3 = new Fraction();
            Fraction fractionActual = new Fraction(-1,10);
            string actualValue = "";
            //act
            try
            {
                fraction3 = fraction2 - fraction1;
            }
            catch (Exception e)
            {
                actualValue = e.Message;
            }
            //assert
            Assert.AreEqual(fractionActual.Top, fraction3.Top, actualValue);
            Assert.AreEqual(fractionActual.Bottom, fraction3.Bottom, actualValue);

        }

    }
}

