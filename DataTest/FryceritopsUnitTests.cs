using DinoDiner.Data.Enums;
using DinoDiner.Data.Sides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest
{
    /// <summary>
    /// Unit tests for fryceritops class
    /// </summary>
    public class FryceritopsUnitTests
    {
        /// <summary>
        /// Tests if class inherits from side
        /// </summary>
        [Fact]
        public void ShouldInheritFromSide()
        {
            Fryceritops fry = new();
            Assert.IsAssignableFrom<Side>(fry);
        }

        /// <summary>
        /// Tests if name is correct
        /// </summary>
        /// <param name="name">expected name</param>
        /// <param name="size">size of the side</param>
        [Theory]
        [InlineData("Small Fryceritops", ServingSize.Small)]
        [InlineData("Medium Fryceritops", ServingSize.Medium)]
        [InlineData("Large Fryceritops", ServingSize.Large)]
        public void NameShouldBeCorrect(string name, ServingSize size)
        {
            Fryceritops fry = new();
            fry.Size = size;
            Assert.Equal(name, fry.Name);
        }

        /// <summary>
        /// Tests if price is correct
        /// </summary>
        /// <param name="price">expected price</param>
        /// <param name="size">size of the side</param>
        [Theory]
        [InlineData(3.50, ServingSize.Small)]
        [InlineData(4.00, ServingSize.Medium)]
        [InlineData(5.00, ServingSize.Large)]
        public void PriceShouldBeCorrect(decimal price, ServingSize size)
        {
            Fryceritops fry = new();
            fry.Size = size;
            Assert.Equal(price, fry.Price);
        }

        /// <summary>
        /// Tests if Calories is correct
        /// </summary>
        /// <param name="calories">expected calories</param>
        /// <param name="size">size of the side</param>
        /// <param name="sauce">if fries have sauce or not</param>
        [Theory]
        [InlineData(365+80, ServingSize.Small, true)]
        [InlineData(365, ServingSize.Small, false)]
        [InlineData(465+80, ServingSize.Medium, true)]
        [InlineData(465, ServingSize.Medium, false)]
        [InlineData(510+80, ServingSize.Large, true)]
        [InlineData(510, ServingSize.Large, false)]
        public void CaloriesShouldBeCorrect(uint calories, ServingSize size, bool sauce)
        {
            Fryceritops fry = new();
            fry.Size = size;
            fry.Sauce = sauce;
            Assert.Equal(calories, fry.Calories);
        }

        /// <summary>
        /// Tests if you can set size of fries
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            Fryceritops fry = new();
            fry.Size = ServingSize.Medium;
            Assert.Equal(ServingSize.Medium, fry.Size);
            fry.Size = ServingSize.Large;
            Assert.Equal(ServingSize.Large, fry.Size);
            fry.Size = ServingSize.Small;
            Assert.Equal(ServingSize.Small, fry.Size);
        }

        /// <summary>
        /// Tests if salt starts as true
        /// </summary>
        [Fact]
        public void SaltShouldDefaultToTrue()
        {
            Fryceritops fry = new();
            Assert.True(fry.Salt);
        }

        /// <summary>
        /// Tests if you can set salt
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSalt()
        {
            Fryceritops fry = new();
            fry.Salt = false;
            Assert.False(fry.Salt);
            fry.Salt = true;
            Assert.True(fry.Salt);
        }

        /// <summary>
        /// Sauce should start as false
        /// </summary>
        [Fact]
        public void SauceShouldDefaultToFalse()
        {
            Fryceritops fry = new();
            Assert.False(fry.Sauce);
        }

        /// <summary>
        /// Tests if you can set salt
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSauce()
        {
            Fryceritops fry = new();
            fry.Sauce = true;
            Assert.True(fry.Sauce);
            fry.Sauce = false;
            Assert.False(fry.Sauce);

        }
    }
}
