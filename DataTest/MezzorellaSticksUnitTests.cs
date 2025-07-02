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
    /// Tests for mezzorella sticks
    /// </summary>
    public class MezzorellaSticksUnitTests
    {
        /// <summary>
        /// Tests if class inherits from side
        /// </summary>
        [Fact]
        public void ShouldInheritFromSide()
        {
            MezzorellaSticks ms = new();
            Assert.IsAssignableFrom<Side>(ms);
        }

        /// <summary>
        /// Tests if name is correct
        /// </summary>
        /// <param name="name">expected name</param>
        /// <param name="size">size of the side</param>
        [Theory]
        [InlineData("Small Mezzorella Sticks", ServingSize.Small)]
        [InlineData("Medium Mezzorella Sticks", ServingSize.Medium)]
        [InlineData("Large Mezzorella Sticks", ServingSize.Large)]
        public void NameShouldBeCorrect(string name, ServingSize size)
        {
            MezzorellaSticks ms = new();
            ms.Size = size;
            Assert.Equal(name, ms.Name);
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
            MezzorellaSticks ms = new();
            ms.Size = size;
            Assert.Equal(price, ms.Price);
        }

        /// <summary>
        /// Tests if Calories is correct
        /// </summary>
        /// <param name="calories">expected calories</param>
        /// <param name="size">size of the side</param>
        [Theory]
        [InlineData(530, ServingSize.Small)]
        [InlineData(620, ServingSize.Medium)]
        [InlineData(730, ServingSize.Large)]
        public void CaloriesShouldBeCorrect(uint calories, ServingSize size)
        {
            MezzorellaSticks ms = new();
            ms.Size = size;
            Assert.Equal(calories, ms.Calories);
        }

        /// <summary>
        /// Tests if you can set size
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MezzorellaSticks ms = new();
            ms.Size = ServingSize.Medium;
            Assert.Equal(ServingSize.Medium, ms.Size);
            ms.Size = ServingSize.Large;
            Assert.Equal(ServingSize.Large, ms.Size);
            ms.Size = ServingSize.Small;
            Assert.Equal(ServingSize.Small, ms.Size);
        }
    }
}
