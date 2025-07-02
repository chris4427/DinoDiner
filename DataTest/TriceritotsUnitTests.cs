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
    /// Tets for triceritots
    /// </summary>
    public class TriceritotsUnitTests
    {
        /// <summary>
        /// Tests if class inherits from side
        /// </summary>
        [Fact]
        public void ShouldInheritFrottide()
        {
            Triceritots tt = new();
            Assert.IsAssignableFrom<Side>(tt);
        }

        /// <summary>
        /// Tests if name is correct
        /// </summary>
        /// <param name="name">expected name</param>
        /// <param name="size">size of the side</param>
        [Theory]
        [InlineData("Small Triceritots", ServingSize.Small)]
        [InlineData("Medium Triceritots", ServingSize.Medium)]
        [InlineData("Large Triceritots", ServingSize.Large)]
        public void NameShouldBeCorrect(string name, ServingSize size)
        {
            Triceritots tt = new();
            tt.Size = size;
            Assert.Equal(name, tt.Name);
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
            Triceritots tt = new();
            tt.Size = size;
            Assert.Equal(price, tt.Price);
        }

        /// <summary>
        /// Tests if Calories is correct
        /// </summary>
        /// <param name="calories">expected calories</param>
        /// <param name="size">size of the side</param>
        [Theory]
        [InlineData(351, ServingSize.Small)]
        [InlineData(409, ServingSize.Medium)]
        [InlineData(583, ServingSize.Large)]
        public void CaloriesShouldBeCorrect(uint calories, ServingSize size)
        {
            Triceritots tt = new();
            tt.Size = size;
            Assert.Equal(calories, tt.Calories);
        }

        /// <summary>
        /// Tests if you can set size
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            Triceritots tt = new();
            tt.Size = ServingSize.Medium;
            Assert.Equal(ServingSize.Medium, tt.Size);
            tt.Size = ServingSize.Large;
            Assert.Equal(ServingSize.Large, tt.Size);
            tt.Size = ServingSize.Small;
            Assert.Equal(ServingSize.Small, tt.Size);
        }
    }
}
