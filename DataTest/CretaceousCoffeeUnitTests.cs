using DinoDiner.Data.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTest
{
    /// <summary>
    /// Tests for cretaceous coffee
    /// </summary>
    public class CretaceousCoffeeUnitTests
    {
        /// <summary>
        /// Tests if class inherits from drink
        /// </summary>
        [Fact]
        public void ShouldInheritFromDrink()
        {
            CretaceousCoffee cc = new();
            Assert.IsAssignableFrom<Drink>(cc);
        }

        /// <summary>
        /// Tests if name is correct
        /// </summary>
        [Fact]
        public void NameShouldBeCorrect()
        {
            CretaceousCoffee cc = new();
            cc.Size = ServingSize.Small;
            Assert.Equal("Small Cretaceous Coffee", cc.Name);
            cc.Size = ServingSize.Medium;
            Assert.Equal("Medium Cretaceous Coffee", cc.Name);
            cc.Size = ServingSize.Large;
            Assert.Equal("Large Cretaceous Coffee", cc.Name);
        }

        /// <summary>
        /// Tests if price is correct
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            CretaceousCoffee cc = new();
            cc.Size = ServingSize.Small;
            Assert.Equal(.75m, cc.Price);
            cc.Size = ServingSize.Medium;
            Assert.Equal(1.25m, cc.Price);
            cc.Size = ServingSize.Large;
            Assert.Equal(2.00m, cc.Price);
        }

        /// <summary>
        /// Tests if calories is correct
        /// </summary>
        [Fact]
        public void CaloriesShouldBeCorrect()
        {
            CretaceousCoffee cc = new();
            cc.Cream = true;
            Assert.Equal(64u, cc.Calories);
            cc.Cream = false;
            Assert.Equal(0u, cc.Calories);
        }

        /// <summary>
        /// Tests if size can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CretaceousCoffee cc = new();
            cc.Size = ServingSize.Small;
            Assert.Equal(ServingSize.Small, cc.Size);
            cc.Size = ServingSize.Medium;
            Assert.Equal(ServingSize.Medium, cc.Size);
            cc.Size = ServingSize.Large;
            Assert.Equal(ServingSize.Large, cc.Size);
        }

        /// <summary>
        /// Tests if you can set cream
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCream()
        {
            CretaceousCoffee cc = new();
            cc.Cream = true;
            Assert.True(cc.Cream);
            cc.Cream = false;
            Assert.False(cc.Cream);
        }

        /// <summary>
        /// Cream should start as false
        /// </summary>
        [Fact]
        public void CreamShouldDefaultToFalse()
        {
            CretaceousCoffee cc = new();
            Assert.False(cc.Cream);
        }
    }
}
