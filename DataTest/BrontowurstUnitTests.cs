using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTest
{
    /// <summary>
    /// Unit tests for brontowurst menu item
    /// </summary>
    public class BrontowurstUnitTests
    {
        /// <summary>
        /// Brontowurst should inherit from entree
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            Brontowurst bw = new Brontowurst();
            Assert.IsAssignableFrom<Entree>(bw);
        }

        /// <summary>
        /// Name should be Brontowurst
        /// </summary>
        /// <param name="onions">if brontowurst has onions</param>
        /// <param name="peppers">if brontowurst has peppers</param>
        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void NameShouldBeCorrect(bool onions, bool peppers)
        {
            Brontowurst bw = new Brontowurst();
            bw.Onions = onions;
            bw.Peppers = peppers;
            Assert.Equal("Brontowurst", bw.Name);
        }

        /// <summary>
        /// Price should be 5.86
        /// </summary>
        /// <param name="onions">if brontowurst has onions</param>
        /// <param name="peppers">if brontowurst has peppers</param>
        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void PriceShouldBeCorrect(bool onions, bool peppers)
        {
            Brontowurst bw = new Brontowurst();
            bw.Onions = onions;
            bw.Peppers = peppers;
            Assert.Equal(5.86m, bw.Price);
        }

        /// <summary>
        /// Calories should be 512
        /// </summary>
        /// <param name="onions">if bw has onions</param>
        /// <param name="peppers">if bw has peppers</param>
        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void CaloriesShouldBeCorrect(bool onions, bool peppers)
        {
            Brontowurst bw = new Brontowurst();
            bw.Onions = onions;
            bw.Peppers = peppers;
            Assert.Equal(512u, bw.Calories);
        }

        /// <summary>
        /// Onions should default to true
        /// </summary>
        [Fact]
        public void OnionsShouldDefaultToTrue()
        {
            Brontowurst bw = new Brontowurst();
            Assert.True(bw.Onions);
        }

        /// <summary>
        /// Should be able to set onions
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            Brontowurst bw = new();
            bw.Onions = false;
            Assert.False(bw.Onions);
            bw.Onions = true;
            Assert.True(bw.Onions);
        }

        /// <summary>
        /// Peppers should default to true
        /// </summary>
        [Fact]
        public void PeppersShouldDefaultToTrue()
        {
            Brontowurst bw = new Brontowurst();
            Assert.True(bw.Peppers);
        }

        /// <summary>
        /// Should be abke to set peppers
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPeppers()
        {
            Brontowurst bw = new();
            bw.Peppers = false;
            Assert.False(bw.Peppers);
            bw.Peppers = true;
            Assert.True(bw.Peppers);
        }
    }
}
