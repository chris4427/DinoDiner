using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTest
{
    /// <summary>
    /// Unit tests for dino nuggets
    /// </summary>
    public class DinoNuggetsUnitTests
    {
        /// <summary>
        /// Should inherit from entree
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.IsAssignableFrom<Entree>(dn);
        }

        /// <summary>
        /// Name should be {Count} Dino Nuggets
        /// </summary>
        /// <param name="count">Number of dino nuggets</param>
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        public void NameShouldBeCorrect(uint count)
        {
            DinoNuggets dn = new();
            dn.Count = count;
            Assert.Equal($"{dn.Count} Dino Nuggets", dn.Name);
        }

        
        /// <summary>
        /// Price should be correct
        /// </summary>
        /// <param name="count"># of nuggets</param>
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        public void PriceShouldBeCorrect(uint count)
        {
            DinoNuggets dn = new();
            dn.Count = count;
            Assert.Equal(count * .25m, dn.Price);
        }

        /// <summary>
        /// Calories should be correct
        /// </summary>
        /// <param name="count"># of nuggets</param>
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        public void CaloriesShouldBeCorrect(uint count)
        {
            DinoNuggets dn = new();
            dn.Count = count;
            Assert.Equal(61 * count, dn.Calories);
        }

        /// <summary>
        /// Count should default to 6
        /// </summary>
        [Fact]
        public void CountShouldDefaultToSix()
        {
            DinoNuggets dn = new();
            Assert.Equal(6u, dn.Count);
        }

        /// <summary>
        /// Should be able to set count of dn
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCount()
        {
            DinoNuggets dn = new();
            dn.Count = 1;
            Assert.Equal(1u, dn.Count);
            dn.Count = 20;
            Assert.Equal(20u, dn.Count);
        }
    }
}
