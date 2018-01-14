using LP.A1._2._1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LP.A1.Tests._2._1
{
    [TestClass]
    public class BalancedBracketsTest
    {
        private const string Example_1_Balanced = "()[]{}(([])){[()][]}";
        private const string Example_2_Unbalanced = "())[]{}";
        private const string Example_3_Unbalanced = "[(])";
        private const string Example_4_Balanced = "()[{{}}]([{}]{})";

        [TestMethod]
        public void Balanced_Should_Return_True_For_Empty_String()
        {
            //Arrange
            var sut = new BalancedBrackets();

            //Act
            var result = sut.Balanced(string.Empty);

            //Assert
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void Balanced_Should_Return_True_For_Example_1()
        {
            //Arrange
            var sut = new BalancedBrackets();

            //Act
            var result = sut.Balanced(Example_1_Balanced);

            //Assert
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void Balanced_Should_Return_False_For_Example_2()
        {
            //Arrange
            var sut = new BalancedBrackets();

            //Act
            var result = sut.Balanced(Example_2_Unbalanced);

            //Assert
            Assert.IsFalse(result);

        }

        [TestMethod]
        public void Balanced_Should_Return_False_For_Example_3()
        {
            //Arrange
            var sut = new BalancedBrackets();

            //Act
            var result = sut.Balanced(Example_3_Unbalanced);

            //Assert
            Assert.IsFalse(result);

        }

        [TestMethod]
        public void Balanced_Should_Return_False_For_Example_4()
        {
            //Arrange
            var sut = new BalancedBrackets();

            //Act
            var result = sut.Balanced(Example_4_Balanced);

            //Assert
            Assert.IsTrue(result);

        }

    }
}
