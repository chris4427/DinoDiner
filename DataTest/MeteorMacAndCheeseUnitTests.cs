using DinoDiner.Data.Enums;
using DinoDiner.Data.Sides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTest
{
    /// <summary>
    /// Tests for metoer mac and cheese
    /// </summary>
    public class MeteorMacAndCheeseUnitTests
    {
        /// <summary>
        /// Tests if class inherits from side
        /// </summary>
        [Fact]
        public void ShouldInheritFromSide()
        {
            MeteorMacAndCheese mmc = new();
            Assert.IsAssignableFrom<Side>(mmc);
        }

        /// <summary>
        /// Tests if name is correct
        /// </summary>
        /// <param name="name">expected name</param>
        /// <param name="size">size of the side</param>
        [Theory]
        [InlineData("Small Meteor Mac & Cheese", ServingSize.Small)]
        [InlineData("Medium Meteor Mac & Cheese", ServingSize.Medium)]
        [InlineData("Large Meteor Mac & Cheese", ServingSize.Large)]
        public void NameShouldBeCorrect(string name, ServingSize size)
        {
            MeteorMacAndCheese mmc = new();
            mmc.Size = size;
            Assert.Equal(name, mmc.Name);
        }

        /// <summary>
        /// Tests if price is correct
        /// </summary>
        /// <param name="price">expected price</param>
        /// <param name="size">size of the side</param>
        [Theory]
        [InlineData(3.50, ServingSize.Small)]
        [InlineData(4.00, ServingSize.Medium)]
        [InlineData(5.25, ServingSize.Large)]
        public void PriceShouldBeCorrect(decimal price, ServingSize size)
        {
            MeteorMacAndCheese mmc = new();
            mmc.Size = size;
            Assert.Equal(price, mmc.Price);
        }

        /// <summary>
        /// Tests if Calories is correct
        /// </summary>
        /// <param name="calories">expected calories</param>
        /// <param name="size">size of the side</param>
        /// <param name="sauce">if fries have sauce or not</param>
        [Theory]
        [InlineData(425, ServingSize.Small)]
        [InlineData(510, ServingSize.Medium)]
        [InlineData(700, ServingSize.Large)]
        public void CaloriesShouldBeCorrect(uint calories, ServingSize size)
        {
            MeteorMacAndCheese mmc = new();
            mmc.Size = size;
            Assert.Equal(calories, mmc.Calories);
        }

        /// <summary>
        /// Test if you can set size of mac & cheese
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MeteorMacAndCheese mmc = new();
            mmc.Size = ServingSize.Medium;
            Assert.Equal(ServingSize.Medium, mmc.Size);
            mmc.Size = ServingSize.Large;
            Assert.Equal(ServingSize.Large, mmc.Size);
            mmc.Size = ServingSize.Small;
            Assert.Equal(ServingSize.Small, mmc.Size);
        }
    }
}
