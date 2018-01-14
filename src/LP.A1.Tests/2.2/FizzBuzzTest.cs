using System.Linq;
using LP.A1._2._2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LP.A1.Tests._2._2
{
    [TestClass]
    public class FizzBuzzTest
    {
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";
        private const string FizzBuzz = Fizz + Buzz;

        [TestMethod]
        public void Apply_Should_Return_100_Items_1_to_100()
        {
            //Arrange
            var sut = new FizzBuzz();

            //Act
            var results = sut.Apply(1, 100);

            //Assert
            Assert.AreEqual(100, results.Count());

        }

        [TestMethod]
        public void Apply_Should_Return_4_Items_6_to_25__Increment_5()
        {
            //Arrange
            var sut = new FizzBuzz();

            //Act
            var results = sut.Apply(6, 25, 5);

            //Assert
            Assert.AreEqual(4, results.Count());

        }

        [TestMethod]
        public void Apply_Should_Transform_3_To_Fizz()
        {
            //Arrange
            var sut = new FizzBuzz();

            //Act
            var result = sut.Apply(6);

            //Assert
            Assert.AreEqual(Fizz, result);

        }

        [TestMethod]
        public void Apply_Should_Transform_6_To_Fizz()
        {
            //Arrange
            var sut = new FizzBuzz();

            //Act
            var result = sut.Apply(6);

            //Assert
            Assert.AreEqual(Fizz, result);

        }

        [TestMethod]
        public void Apply_Should_Transform_5_To_Buzz()
        {
            //Arrange
            var sut = new FizzBuzz();

            //Act
            var result = sut.Apply(5);

            //Assert
            Assert.AreEqual(Buzz, result);

        }

        [TestMethod]
        public void Apply_Should_Transform_10_To_Buzz()
        {
            //Arrange
            var sut = new FizzBuzz();

            //Act
            var result = sut.Apply(10);

            //Assert
            Assert.AreEqual(Buzz, result);

        }

        [TestMethod]
        public void Apply_Should_Transform_15_To_FizzBuzz()
        {
            //Arrange
            var sut = new FizzBuzz();

            //Act
            var result = sut.Apply(15);

            //Assert
            Assert.AreEqual(FizzBuzz, result);

        }

        [TestMethod]
        public void Apply_Should_Transform_90_To_FizzBuzz()
        {
            //Arrange
            var sut = new FizzBuzz();

            //Act
            var result = sut.Apply(90);

            //Assert
            Assert.AreEqual(FizzBuzz, result);

        }

        [TestMethod]
        public void Apply_Should_Transform_0_To_FizzBuzz()
        {
            //Arrange
            var sut = new FizzBuzz();

            //Act
            var result = sut.Apply(0);

            //Assert
            Assert.AreEqual(FizzBuzz, result);

        }

        [TestMethod]
        public void Apply_Should_Not_Transform_1()
        {
            //Arrange
            var sut = new FizzBuzz();

            //Act
            var result = sut.Apply(1);

            //Assert
            Assert.AreEqual("1", result);

        }

        [TestMethod]
        public void Apply_Should_Not_Transform_17()
        {
            //Arrange
            var sut = new FizzBuzz();

            //Act
            var result = sut.Apply(17);

            //Assert
            Assert.AreEqual("17", result);

        }
    }
}
