using System;


namespace RightTriangleFunctionsTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RightTriangleFunctionsTest
    {
        [TestMethod]
        public void Should_return_2_04_When_cathet1_1_2_and_cathet2_3_4_and_hypotenuse_5_6()
        {
            //Arrange
            double cathet1 = 1.2;
            double cathet2 = 3.4;
            double hypotenuse = 5.6;
            double expectedResult = 2.04;

            //Act
            var result = RigthtTriangleFunctions.GetRigthTriangleArea(cathet1, cathet2, hypotenuse);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Should_throw_When_length_less_than_0()
        {
            //Arrange
            double cathet1 = -1.2;
            double cathet2 = 3.4;
            double hypotenuse = 5.6;

            //Act
            var result = RigthtTriangleFunctions.GetRigthTriangleArea(cathet1, cathet2, hypotenuse);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Should_throw_When_length_too_large()
        {
            //Arrange
            double cathet1 = double.MaxValue; 
            double cathet2 = double.MaxValue;
            double hypotenuse = double.MaxValue;

            //Act
            var result = RigthtTriangleFunctions.GetRigthTriangleArea(cathet1, cathet2, hypotenuse);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Should_throw_When_length_too_small()
        {
            //Arrange
            double cathet1 = double.MinValue;
            double cathet2 = double.MinValue;
            double hypotenuse = double.MinValue;

            //Act
            var result = RigthtTriangleFunctions.GetRigthTriangleArea(cathet1, cathet2, hypotenuse);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Should_throw_When_length_is_NaN()
        {
            //Arrange
            double cathet1 = double.NaN;
            double cathet2 = 3;
            double hypotenuse = 5;

            //Act
            var result = RigthtTriangleFunctions.GetRigthTriangleArea(cathet1, cathet2, hypotenuse);

        }

        [TestMethod] 
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Should_throw_When_length_is_Infinity()
        {
            //Arrange
            double cathet1 = 3;
            double cathet2 = double.PositiveInfinity;
            double hypotenuse = 5;

            //Act
            var result = RigthtTriangleFunctions.GetRigthTriangleArea(cathet1, cathet2, hypotenuse);

        }
    }
}
