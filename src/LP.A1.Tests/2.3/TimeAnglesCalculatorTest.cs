using System;
using LP.A1._2._3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LP.A1.Tests._2._3
{
    [TestClass]
    public class TimeAnglesCalculatorTest
    {
        [TestMethod]
        public void Calculate_Should_Return_0deg_For_0()
        {
            //Arrange
            var hour = 0;
            var minute = 0;
            var sut = new TimeAnglesCalculator();

            //Act
            var angle = sut.Calculate(hour, minute);

            //Assert
            Assert.AreEqual(0m, angle);

        }

        [TestMethod]
        public void Calculate_Should_Return_90deg_For_3()
        {
            //Arrange
            var hour = 3;
            var minute = 0;
            var sut = new TimeAnglesCalculator();

            //Act
            var angle = sut.Calculate(hour, minute);

            //Assert
            Assert.AreEqual(90m, angle);

        }

        [TestMethod]
        public void Calculate_Should_Return_75deg_For_3_30()
        {
            //Arrange
            var hour = 3;
            var minute = 30;
            var sut = new TimeAnglesCalculator();

            //Act
            var angle = sut.Calculate(hour, minute);

            //Assert
            Assert.AreEqual(75m, angle);

        }

        [TestMethod]
        public void Calculate_Should_Return_120deg_For_4()
        {
            //Arrange
            var hour = 4;
            var minute = 0;
            var sut = new TimeAnglesCalculator();

            //Act
            var angle = sut.Calculate(hour, minute);

            //Assert
            Assert.AreEqual(120m, angle);

        }

        [TestMethod]
        public void Calculate_Should_Return_172_5deg_For_9_15()
        {
            //Arrange
            var hour = 9;
            var minute = 15;
            var sut = new TimeAnglesCalculator();

            //Act
            var angle = sut.Calculate(hour, minute);

            //Assert
            Assert.AreEqual(172.5m, angle);

        }

        [TestMethod]
        public void Calculate_Should_Return_0deg_For_12AM_DateTime()
        {
            //Arrange
            var dt = new DateTime(2000, 1, 1, 0, 0, 0);
            var sut = new TimeAnglesCalculator();

            //Act
            var angle = sut.Calculate(dt);

            //Assert
            Assert.AreEqual(0m, angle);

        }

        [TestMethod]
        public void Calculate_Should_Return_0deg_For_12PM_DateTime()
        {
            //Arrange
            var dt = new DateTime(2000, 1, 1, 12, 0, 0);
            var sut = new TimeAnglesCalculator();

            //Act
            var angle = sut.Calculate(dt);

            //Assert
            Assert.AreEqual(0m, angle);
        }

        [TestMethod]
        public void Calculate_Should_Return_180deg_For_6AM_DateTime()
        {
            //Arrange
            var dt = new DateTime(2000, 1, 1, 6, 0, 0);
            var sut = new TimeAnglesCalculator();

            //Act
            var angle = sut.Calculate(dt);

            //Assert
            Assert.AreEqual(180m, angle);

        }

        [TestMethod]
        public void Calculate_Should_Return_180deg_For_6PM_DateTime()
        {
            //Arrange
            var dt = new DateTime(2000, 1, 1, 18, 0, 0);
            var sut = new TimeAnglesCalculator();

            //Act
            var angle = sut.Calculate(dt);

            //Assert
            Assert.AreEqual(180m, angle);
        }

    }
}
