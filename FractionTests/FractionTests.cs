using ClassLibraryFraction;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FractionTests
{
    [TestClass]
    public class FractionTests
    {

        [TestMethod]
        public void FixWornResult_Numb1Is5Numb2Is7_ReturnsSuccsesResult()
        {
            //arrange
            string text = "5/7";

            string expected = "5/7";

            //act
            string result = new Class1().FixWornResult(text);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FixWornResult_Numb1Is251Numb2Is100_ReturnsSuccsesResult()
        {
            //arrange
            string text = "251/100";

            string expected = "100/100";

            //act
            string result = new Class1().FixWornResult(text);

            //assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void FixWornResult_Numb1IsMinus10Numb2IsPlus10_ReturnsSuccsesResult()
        {
            //arrange
            string text = "-10/10";

            string expected = "-10/10";

            //act
            string result = new Class1().FixWornResult(text);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FixWornResult_EmptyString_ReturnsNegativeResult()
        {
            //arrange
            string text = "";

            //act
            Action result = () => new Class1().FixWornResult(text);

            //assert
            Assert.ThrowsException<ArgumentException>(result);
        }
        [TestMethod]
        public void FixWornResult_UnCorrectString1_ReturnsNegativeResult()
        {
            //arrange
            string text = "/";

            //act
            Action result = () => new Class1().FixWornResult(text);

            //assert
            Assert.ThrowsException<ArgumentException>(result, "числитель не явлется числом");
        }
        [TestMethod]
        public void FixWornResult_UnCorrectString2_ReturnsNegativeResult()
        {
            //arrange
            string text = "10/35/12/27";

            //act
            Action result = () => new Class1().FixWornResult(text);

            //assert
            Assert.ThrowsException<ArgumentException>(result);
        }
        [TestMethod]
        public void FixWornResult_UnCorrectString3_ReturnsNegativeResult()
        {
            //arrange
            string text = "10/1a";

            //act
            Action result = () => new Class1().FixWornResult(text);

            //assert
            Assert.ThrowsException<ArgumentException>(result);
        }
        [TestMethod]
        public void FixWornResult_UnCorrectString4_ReturnsNegativeResult()
        {
            //arrange
            string text = "1055";

            //act
            Action result = () => new Class1().FixWornResult(text);

            //assert
            Assert.ThrowsException<ArgumentException>(result);
        }

    }
}
