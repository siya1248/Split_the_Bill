namespace SplitthebillTests;
using SplitthebillLibrary;
using System;
using Xunit;
[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void RegularScenario()
    {
            decimal Amount = 500;
            int numberOfPeople = 5;
            decimal expectedAmount = 100; 

            SplittheBill s = new SplittheBill();

            // Act
            decimal actualAmount = s.SplitBill(Amount, numberOfPeople);

            // Assert
            Assert.Equal(expectedAmount, actualAmount);
    }

    [TestMethod]
    public void ZeroTotalAmount()
        {
            // Arrange
            decimal Amount = 0;
            int numberOfPeople = 4;
            decimal expectedAmount = 0;

            SplittheBill s = new SplittheBill();

            // Act
            decimal actualAmount = s.SplitBill(Amount, numberOfPeople);

            // Assert
            Assert.Equal(expectedAmount, actualAmount);
        }

        [TestMethod]
        public void NegativeNumberOfPeople()
        {
            // Arrange
            decimal Amount = 100;
            int numberOfPeople = -4;

            SplittheBill s = new SplittheBill();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => s.SplitBill(Amount, numberOfPeople));
        }
}