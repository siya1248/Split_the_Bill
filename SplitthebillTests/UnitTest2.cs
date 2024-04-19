using System.Collections.Generic;
using SplittheBillLibrary;
using Xunit;

namespace SplittheBillTests;

    [TestClass]
    public class UnitTest2
    {
        [Fact]
        public void CalculateTip_Regular()
        {
            // Arrange
            var mealCosts = new Dictionary<string, decimal>
            {
                { "P1", 50 },
                { "P2", 30 },
                { "P3", 20 }
            };
            float tipPercent = 15;
            var expectedTip = new Dictionary<string, decimal>
            {
                { "P1", 7.50m },
                { "P2", 4.50m },
                { "P3", 3.00m }
            };
            var tipCalculator = new CalculateWeight();

            // Act
            var actualTip = tipCalculator.CalculateAverage(mealCosts, tipPercent);

            // Assert
            Xunit.Assert.Equal(expectedTip, actualTip);
        }

        [Fact]
        public void ZeroMealcost_ZeoTipPercent()
        {
            // Arrange
            var mealCosts = new Dictionary<string, decimal>
            {
                { "P1", 0 },
                { "P2", 0 },
                { "P3", 0 }
            };
            float tipPercent = 20;
            var expectedTip = new Dictionary<string, decimal>
            {
                { "P1", 0 },
                { "P2", 0 },
                { "P3", 0 }
            };
            var tipCalculator = new CalculateWeight();

            // Act
            var actualTip = tipCalculator.CalculateAverage(mealCosts, tipPercent);

            // Assert
            Xunit.Assert.Equal(expectedTip, actualTip);
        }

        [Fact]
        public void CalculateTip_ZeroTipPercent()
        {
            // Arrange
            var mealCosts = new Dictionary<string, decimal>
            {
                { "P1", 50 },
                { "P2", 30 },
                { "P3", 20 }
            };
            float tipPercent = 0;
            var expectedTip = new Dictionary<string, decimal>
            {
                { "P1", 0 },
                { "P2", 0 },
                { "P3", 0 }
            };
            var tipCalculator = new CalculateWeight();

            // Act
            var actualTip = tipCalculator.CalculateAverage(mealCosts, tipPercent);

            // Assert
            Xunit.Assert.Equal(expectedTip, actualTip);
        }
    
    [Fact]
        public void CalculateTipPerPerson_ReturnsCorrectTipAmount()
        {
            // Arrange
            decimal price = 100;
            int numberOfPatrons = 5;
            float tipPercentage = 15;
            decimal expectedTipPerPerson = 3;
            var tipCalculator = new CalculateWeight();

            // Act
            decimal actualTipPerPerson = tipCalculator.CalculateTipPerPerson(price, numberOfPatrons, tipPercentage);

            // Assert
            Xunit.Assert.Equal(expectedTipPerPerson, actualTipPerPerson);
        }

        [Fact]
        public void CalculateTipPerPerson_ZeroNumberOfPatrons()
        {
            // Arrange
            decimal price = 100;
            int numberOfPatrons = 0;
            float tipPercentage = 15;
            var tipCalculator = new CalculateWeight();

            // Act and Assert
            Xunit.Assert.Throws<ArgumentException>(() => tipCalculator.CalculateTipPerPerson(price, numberOfPatrons, tipPercentage));
        }

        [Fact]
        public void CalculateTipPerPerson_NegativeTipPercentage()
        {
            // Arrange
            decimal price = 100;
            int numberOfPatrons = 5;
            float tipPercentage = -10;
            var tipCalculator = new CalculateWeight();

            // Act and Assert
            Xunit.Assert.Throws<ArgumentException>(() => tipCalculator.CalculateTipPerPerson(price, numberOfPatrons, tipPercentage));
        }
    }

