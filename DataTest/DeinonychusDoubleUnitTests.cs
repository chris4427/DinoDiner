using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTest
{
    /// <summary>
    /// Tests for deinychus double item
    /// </summary>
    public class DeinonychusDoubleUnitTests
    {
        /// <summary>
        /// Tests if it enherits from entree
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            DeinonychusDouble dd = new();
            Assert.IsAssignableFrom<Entree>(dd);
        }

        /// <summary>
        /// Tests if name is correct
        /// </summary>
        [Fact]
        public void NameShouldBeCorrect()
        {
            DeinonychusDouble dd = new();
            Assert.Equal("Deinonychus Double", dd.Name);
        }

        /// <summary>
        /// Tests if price is correct
        /// </summary>
        /// <param name="price">expected price</param>
        /// <param name="patties"># of patties</param>
        /// <param name="ketchup">if burger has ketchup</param>
        /// <param name="mustard">if burger has mustard</param>
        /// <param name="pickle">if burger has pickles</param>
        /// <param name="mayo">if burger has mayo</param>
        /// <param name="bbq">if burger has bbq sauce</param>
        /// <param name="onion">if burger has onion</param>
        /// <param name="tomato">if burger has tomato</param>
        /// <param name="lettuce">if burger has lettuce</param>
        /// <param name="ac">if burger has american cheese</param>
        /// <param name="sc">if burger has swiss cheese</param>
        /// <param name="bacon">if burger has bacon</param>
        /// <param name="mushrooms">if burger has mushrooms</param>
        [Theory]
        [InlineData(1502.35, 1000, true, true, false, false, false, true, true, false, true, false, true, true)]
        [InlineData(7.4, 4, true, false, false, true, true, false, false, false, false, false, true, true)]
        [InlineData(17, 10, false, true, true, false, false, true, true, true, true, true, false, false)]
        [InlineData(9.85, 5, false, true, true, true, false, true, true, true, false, true, false, true)]
        [InlineData(3.05, 1, false, false, true, false, false, true, true, true, true, false, false, false)]
        [InlineData(15.40, 8, true, true, true, true, true, true, true, true, true, true, true, true)]
        [InlineData(7.50, 5, false, false, false, false, false, false, false, false, false, false, false, false)]
        [InlineData(1.20, 0, false, false, true, false, true, true, false, false, false, false, true, false)]
        public void PriceShouldBeCorrect(decimal price, uint patties, bool ketchup, bool mustard, bool pickle, bool mayo, bool bbq, bool onion, bool tomato, bool lettuce, bool ac, bool sc, bool bacon, bool mushrooms)
        {
            DeinonychusDouble dd = new();
            dd.Patties = patties;
            dd.Ketchup = ketchup;
            dd.Mustard = mustard;
            dd.Pickle = pickle;
            dd.Mayo = mayo;
            dd.BBQ = bbq;
            dd.Onion = onion;
            dd.Tomato = tomato;
            dd.Lettuce = lettuce;
            dd.AmericanCheese = ac;
            dd.SwissCheese = sc;
            dd.Bacon = bacon;
            dd.Mushrooms = mushrooms;
            Assert.Equal(price, dd.Price);
        }

        /// <summary>
        /// Tests if price is correct
        /// </summary>
        /// <param name="calories">expected calories</param>
        /// <param name="patties"># of patties</param>
        /// <param name="ketchup">if burger has ketchup</param>
        /// <param name="mustard">if burger has mustard</param>
        /// <param name="pickle">if burger has pickles</param>
        /// <param name="mayo">if burger has mayo</param>
        /// <param name="bbq">if burger has bbq sauce</param>
        /// <param name="onion">if burger has onion</param>
        /// <param name="tomato">if burger has tomato</param>
        /// <param name="lettuce">if burger has lettuce</param>
        /// <param name="ac">if burger has american cheese</param>
        /// <param name="sc">if burger has swiss cheese</param>
        /// <param name="bacon">if burger has bacon</param>
        /// <param name="mushrooms">if burger has mushrooms</param>
        [Theory]
        [InlineData(204239, 1000, true, true, false, false, false, true, true, false, true, false, true, true)]
        [InlineData(1005, 4, true, false, false, true, true, false, false, false, false, false, true, true)]
        [InlineData(2331, 10, false, true, true, false, false, true, true, true, true, true, false, false)]
        [InlineData(1305, 5, false, true, true, true, false, true, true, true, false, true, false, true)]
        [InlineData(386, 1, false, false, true, false, false, true, true, true, true, false, false, false)]
        [InlineData(2112, 8, true, true, true, true, true, true, true, true, true, true, true, true)]
        [InlineData(1020, 5, false, false, false, false, false, false, false, false, false, false, false, false)]
        [InlineData(123, 0, false, false, true, false, true, true, false, false, false, false, true, false)]
        public void CaloriesShouldBeCorrect(uint calories, uint patties, bool ketchup, bool mustard, bool pickle, bool mayo, bool bbq, bool onion, bool tomato, bool lettuce, bool ac, bool sc, bool bacon, bool mushrooms)
        {
            DeinonychusDouble dd = new();
            dd.Patties = patties;
            dd.Ketchup = ketchup;
            dd.Mustard = mustard;
            dd.Pickle = pickle;
            dd.Mayo = mayo;
            dd.BBQ = bbq;
            dd.Onion = onion;
            dd.Tomato = tomato;
            dd.Lettuce = lettuce;
            dd.AmericanCheese = ac;
            dd.SwissCheese = sc;
            dd.Bacon = bacon;
            dd.Mushrooms = mushrooms;
            Assert.Equal(calories, dd.Calories);
        }

        /// <summary>
        /// Tests if # of patties starts at 1
        /// </summary>
        [Fact]
        public void PattiesShouldDefaultToTwo()
        {
            DeinonychusDouble dd = new();
            Assert.Equal(2u, dd.Patties);
        }

        /// <summary>
        /// Tests if you can set patties
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPatties()
        {
            DeinonychusDouble dd = new();
            dd.Patties = 3;
            Assert.Equal(3u, dd.Patties);
            dd.Patties = 4;
            Assert.Equal(4u, dd.Patties);
        }

        /// <summary>
        /// Tests if ketchup starts as false
        /// </summary>
        [Fact]
        public void KetchupShouldDefaultToFalse()
        {
            DeinonychusDouble dd = new();
            Assert.False(dd.Ketchup);
        }

        /// <summary>
        /// Tests if you can set ketchup
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DeinonychusDouble dd = new();
            dd.Ketchup = false;
            Assert.False(dd.Ketchup);
            dd.Ketchup = true;
            Assert.True(dd.Ketchup);
        }

        /// <summary>
        /// tests if mustard starts as false
        /// </summary>
        [Fact]
        public void MustardShouldDefaultToFalse()
        {
            DeinonychusDouble dd = new();
            Assert.False(dd.Mustard);
        }

        /// <summary>
        /// Tests if you can set mustard
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DeinonychusDouble dd = new();
            dd.Mustard = false;
            Assert.False(dd.Mustard);
            dd.Mustard = true;
            Assert.True(dd.Mustard);
        }

        /// <summary>
        /// Tests if pickle starts as true
        /// </summary>
        [Fact]
        public void PickleShouldDefaultToTrue()
        {
            DeinonychusDouble dd = new();
            Assert.True(dd.Pickle);
        }

        /// <summary>
        /// Tests if you can set pickles
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DeinonychusDouble dd = new();
            dd.Pickle = false;
            Assert.False(dd.Pickle);
            dd.Pickle = true;
            Assert.True(dd.Pickle);
        }

        /// <summary>
        /// Tests if mayo starts as false
        /// </summary>
        [Fact]
        public void MayoShouldDefaultToFalse()
        {
            DeinonychusDouble dd = new();
            Assert.False(dd.Mayo);
        }

        /// <summary>
        /// Tests if you can set mayo
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DeinonychusDouble dd = new();
            dd.Mayo = true;
            Assert.True(dd.Mayo);
            dd.Mayo = false;
            Assert.False(dd.Mayo);
        }

        /// <summary>
        /// Tests if bbq starts as true
        /// </summary>
        [Fact]
        public void BBQShouldDefaultToTrue()
        {
            DeinonychusDouble dd = new();
            Assert.True(dd.BBQ);
        }

        /// <summary>
        /// Tests if you can set BBQ
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBBQ()
        {
            DeinonychusDouble dd = new();
            dd.BBQ = true;
            Assert.True(dd.BBQ);
            dd.BBQ = false;
            Assert.False(dd.BBQ);
        }

        /// <summary>
        /// Tests if onion starts as true
        /// </summary>
        [Fact]
        public void OnionShouldDefaultToTrue()
        {
            DeinonychusDouble dd = new();
            Assert.True(dd.Onion);
        }

        /// <summary>
        /// Tests if you can set onion
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetOnion()
        {
            DeinonychusDouble dd = new();
            dd.Onion = true;
            Assert.True(dd.Onion);
            dd.Onion = false;
            Assert.False(dd.Onion);
        }

        /// <summary>
        /// Tests if tomato starts as false
        /// </summary>
        [Fact]
        public void TomatoShouldDefaultToFalse()
        {
            DeinonychusDouble dd = new();
            Assert.False(dd.Tomato);
        }

        /// <summary>
        /// Tests if you can set tomato
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DeinonychusDouble dd = new();
            dd.Tomato = true;
            Assert.True(dd.Tomato);
            dd.Tomato = false;
            Assert.False(dd.Tomato);
        }

        /// <summary>
        /// Tests if lettuce starts as false
        /// </summary>
        [Fact]
        public void LettuceShouldDefaultToFalse()
        {
            DeinonychusDouble dd = new();
            Assert.False(dd.Lettuce);
        }

        /// <summary>
        /// Tests if you can set lettuce
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DeinonychusDouble dd = new();
            dd.Lettuce = true;
            Assert.True(dd.Lettuce);
            dd.Lettuce = false;
            Assert.False(dd.Lettuce);
        }

        /// <summary>
        /// Tests if american cheese starts as false
        /// </summary>
        [Fact]
        public void AmericanCheeseShouldDefaultToFalse()
        {
            DeinonychusDouble dd = new();
            Assert.False(dd.AmericanCheese);
        }

        /// <summary>
        /// Tests if you can set american cheese
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetAmericanCheese()
        {
            DeinonychusDouble dd = new();
            dd.AmericanCheese = true;
            Assert.True(dd.AmericanCheese);
            dd.AmericanCheese = false;
            Assert.False(dd.AmericanCheese);
        }

        /// <summary>
        /// Tests if swiss cheese starts as true
        /// </summary>
        [Fact]
        public void SwissCheeseShouldDefaultToTrue()
        {
            DeinonychusDouble dd = new();
            Assert.True(dd.SwissCheese);
        }

        /// <summary>
        /// Tests if you can set swiss cheese
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSwissCheese()
        {
            DeinonychusDouble dd = new();
            dd.SwissCheese = true;
            Assert.True(dd.SwissCheese);
            dd.SwissCheese = false;
            Assert.False(dd.SwissCheese);
        }

        /// <summary>
        /// Tests if bacon starts as false
        /// </summary>
        [Fact]
        public void BaconShouldDefaultToFalse()
        {
            DeinonychusDouble dd = new();
            Assert.False(dd.Bacon);
        }

        /// <summary>
        /// Tests if you can set bacon
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            DeinonychusDouble dd = new();
            dd.Bacon = true;
            Assert.True(dd.Bacon);
            dd.Bacon = false;
            Assert.False(dd.Bacon);
        }

        /// <summary>
        /// Tests if mushroom starts at true
        /// </summary>
        [Fact]
        public void MushroomsShouldDefaultToTrue()
        {
            DeinonychusDouble dd = new();
            Assert.True(dd.Mushrooms);
        }

        /// <summary>
        /// Tests if you can set mushrooms
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            DeinonychusDouble dd = new();
            dd.Mushrooms = true;
            Assert.True(dd.Mushrooms);
            dd.Mushrooms = false;
            Assert.False(dd.Mushrooms);
        }
    }
}
