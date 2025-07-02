using DinoDiner.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTest
{
    public class VelociWraptorUnitTests
    {
        /// <summary>
        /// Should inherit from entree
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            VelociWraptor vw = new();
            Assert.IsAssignableFrom<Entree>(vw);
        }

        /// <summary>
        /// Name should be Veloci-Wraptor
        /// </summary>
        [Fact]
        public void NameShouldBeCorrect()
        {
            VelociWraptor vw = new();
            Assert.Equal("Veloci-Wraptor", vw.Name);
        }

        /// <summary>
        /// Price should be 6.25
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            VelociWraptor vw = new();
            Assert.Equal(6.25m, vw.Price);
        }

        /// <summary>
        /// calories should be correct
        /// </summary>
        /// <param name="calories">expected calories</param>
        /// <param name="dressing">if wrap has drassing on it</param>
        /// <param name="cheese">if wrap has cheese on it</param>
        [Theory]
        [InlineData(732, true, true)]
        [InlineData(710, true, false)]
        [InlineData(638, false, true)]
        [InlineData(616, false, false)]
        public void CaloriesShouldBeCorrect(uint calories,bool dressing, bool cheese)
        {
            VelociWraptor vw = new();
            vw.Cheese = cheese;
            vw.Dressing = dressing;
            Assert.Equal(calories, vw.Calories);
        }

        /// <summary>
        /// dressing should intialize to true
        /// </summary>
        [Fact]
        public void DressingShouldDefaultToTrue()
        {
            VelociWraptor vw = new();
            Assert.True(vw.Dressing);
        }

        /// <summary>
        /// Tests if dressing prop can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetDressing()
        {
            VelociWraptor vw = new();
            vw.Dressing = false;
            Assert.False(vw.Dressing);
            vw.Dressing = true;
            Assert.True(vw.Dressing);
        }

        /// <summary>
        /// dressing should intialize to true
        /// </summary>
        [Fact]
        public void CheeseShouldDefaultToTrue()
        {
            VelociWraptor vw = new();
            Assert.True(vw.Cheese);
        }

        /// <summary>
        /// Tests if dressing prop can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            VelociWraptor vw = new();
            vw.Cheese = false;
            Assert.False(vw.Cheese);
            vw.Cheese = true;
            Assert.True(vw.Cheese);
        }
    }
}
