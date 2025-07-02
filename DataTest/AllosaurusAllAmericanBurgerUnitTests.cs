using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTest
{
    /// <summary>
    /// Tests for allosaurus all american burger
    /// </summary>
    public class AllosaurusAllAmericanBurgerUnitTests
    {
        /// <summary>
        /// Tests if it enherits from entree
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            AllosaurusAll_AmericanBurger aab = new();
            Assert.IsAssignableFrom<Entree>(aab);
        }

        /// <summary>
        /// Tests if name is correct
        /// </summary>
        [Fact]
        public void NameShouldBeCorrect()
        {
            AllosaurusAll_AmericanBurger aab = new();
            Assert.Equal("Allosaurus All-American Burger", aab.Name);
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
        [InlineData(1502.35,1000,true, true, false, false, false, true, true, false, true, false, true, true)]
        [InlineData(7.4,4, true, false, false, true, true, false, false, false, false, false, true, true)]
        [InlineData(17,10, false, true, true, false, false, true, true, true, true, true, false, false )]
        [InlineData(9.85,5, false, true, true, true, false, true, true, true, false, true, false, true)]
        [InlineData(3.05,1, false, false, true, false, false, true, true, true, true, false, false, false)]
        [InlineData(15.40,8, true, true, true, true, true, true, true, true, true, true, true, true)]
        [InlineData(7.50,5, false, false, false, false, false, false, false, false, false, false, false, false)]
        [InlineData(1.20,0, false, false,true, false, true, true, false, false, false, false, true, false)]
        public void PriceShouldBeCorrect(decimal price, uint patties, bool ketchup, bool mustard, bool pickle, bool mayo, bool bbq, bool onion, bool tomato, bool lettuce, bool ac, bool sc,bool bacon, bool mushrooms)
        {
            AllosaurusAll_AmericanBurger aab = new();
            aab.Patties = patties;
            aab.Ketchup = ketchup;
            aab.Mustard = mustard;
            aab.Pickle = pickle;
            aab.Mayo = mayo;
            aab.BBQ = bbq;
            aab.Onion = onion;
            aab.Tomato = tomato;
            aab.Lettuce = lettuce;
            aab.AmericanCheese = ac;
            aab.SwissCheese = sc;
            aab.Bacon = bacon;
            aab.Mushrooms = mushrooms;
            Assert.Equal(price, aab.Price);
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
            AllosaurusAll_AmericanBurger aab = new();
            aab.Patties = patties;
            aab.Ketchup = ketchup;
            aab.Mustard = mustard;
            aab.Pickle = pickle;
            aab.Mayo = mayo;
            aab.BBQ = bbq;
            aab.Onion = onion;
            aab.Tomato = tomato;
            aab.Lettuce = lettuce;
            aab.AmericanCheese = ac;
            aab.SwissCheese = sc;
            aab.Bacon = bacon;
            aab.Mushrooms = mushrooms;
            Assert.Equal(calories, aab.Calories);
        }

        /// <summary>
        /// Tests if # of patties starts at 1
        /// </summary>
        [Fact]
        public void PattiesShouldDefaultToOne()
        {
            AllosaurusAll_AmericanBurger aab = new();
            Assert.Equal(1u, aab.Patties);
        }

        /// <summary>
        /// Tests if you can set patties
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPatties()
        {
            AllosaurusAll_AmericanBurger aab = new();
            aab.Patties = 2;
            Assert.Equal(2u, aab.Patties);
            aab.Patties = 3;
            Assert.Equal(3u, aab.Patties);
        }

        /// <summary>
        /// Tests if ketchup starts as true
        /// </summary>
        [Fact]
        public void KetchupShouldDefaultToTrue()
        {
            AllosaurusAll_AmericanBurger aab = new();
            Assert.True(aab.Ketchup);
        }

        /// <summary>
        /// Tests if you can set ketchup
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            AllosaurusAll_AmericanBurger aab = new();
            aab.Ketchup = false;
            Assert.False(aab.Ketchup);
            aab.Ketchup = true;
            Assert.True(aab.Ketchup);
        }

        /// <summary>
        /// tests if mustard starts as true
        /// </summary>
        [Fact]
        public void MustardShouldDefaultToTrue()
        {
            AllosaurusAll_AmericanBurger aab = new();
            Assert.True(aab.Mustard);
        }

        /// <summary>
        /// Tests if you can set mustard
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            AllosaurusAll_AmericanBurger aab = new();
            aab.Mustard = false;
            Assert.False(aab.Mustard);
            aab.Mustard = true;
            Assert.True(aab.Mustard);
        }

        /// <summary>
        /// Tests if pickle starts as true
        /// </summary>
        [Fact]
        public void PickleShouldDefaultToTrue()
        {
            AllosaurusAll_AmericanBurger aab = new();
            Assert.True(aab.Pickle);
        }

        /// <summary>
        /// Tests if you can set pickles
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            AllosaurusAll_AmericanBurger aab = new();
            aab.Pickle = false;
            Assert.False(aab.Pickle);
            aab.Pickle = true;
            Assert.True(aab.Pickle);
        }

        /// <summary>
        /// Tests if mayo starts as false
        /// </summary>
        [Fact]
        public void MayoShouldDefaultToFalse()
        {
            AllosaurusAll_AmericanBurger aab = new();
            Assert.False(aab.Mayo);
        }

        /// <summary>
        /// Tests if you can set mayo
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            AllosaurusAll_AmericanBurger aab = new();
            aab.Mayo = true;
            Assert.True(aab.Mayo);
            aab.Mayo = false;
            Assert.False(aab.Mayo);
        }

        /// <summary>
        /// Tests if bbq starts as false
        /// </summary>
        [Fact]
        public void BBQShouldDefaultToFalse()
        {
            AllosaurusAll_AmericanBurger aab = new();
            Assert.False(aab.BBQ);
        }

        /// <summary>
        /// Tests if you can set BBQ
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBBQ()
        {
            AllosaurusAll_AmericanBurger aab = new();
            aab.BBQ = true;
            Assert.True(aab.BBQ);
            aab.BBQ = false;
            Assert.False(aab.BBQ);
        }

        /// <summary>
        /// Tests if onion starts as false
        /// </summary>
        [Fact]
        public void OnionShouldDefaultToFalse()
        {
            AllosaurusAll_AmericanBurger aab = new();
            Assert.False(aab.Onion);
        }

        /// <summary>
        /// Tests if you can set onion
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetOnion()
        {
            AllosaurusAll_AmericanBurger aab = new();
            aab.Onion = true;
            Assert.True(aab.Onion);
            aab.Onion = false;
            Assert.False(aab.Onion);
        }

        /// <summary>
        /// Tests if tomato starts as false
        /// </summary>
        [Fact]
        public void TomatoShouldDefaultToFalse()
        {
            AllosaurusAll_AmericanBurger aab = new();
            Assert.False(aab.Tomato);
        }

        /// <summary>
        /// Tests if you can set tomato
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            AllosaurusAll_AmericanBurger aab = new();
            aab.Tomato = true;
            Assert.True(aab.Tomato);
            aab.Tomato = false;
            Assert.False(aab.Tomato);
        }

        /// <summary>
        /// Tests if lettuce starts as false
        /// </summary>
        [Fact]
        public void LettuceShouldDefaultToFalse()
        {
            AllosaurusAll_AmericanBurger aab = new();
            Assert.False(aab.Lettuce);
        }

        /// <summary>
        /// Tests if you can set lettuce
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            AllosaurusAll_AmericanBurger aab = new();
            aab.Lettuce = true;
            Assert.True(aab.Lettuce);
            aab.Lettuce = false;
            Assert.False(aab.Lettuce);
        }

        /// <summary>
        /// Tests if american cheese starts as false
        /// </summary>
        [Fact]
        public void AmericanCheeseShouldDefaultToFalse()
        {
            AllosaurusAll_AmericanBurger aab = new();
            Assert.False(aab.AmericanCheese);
        }

        /// <summary>
        /// Tests if you can set american cheese
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetAmericanCheese()
        {
            AllosaurusAll_AmericanBurger aab = new();
            aab.AmericanCheese = true;
            Assert.True(aab.AmericanCheese);
            aab.AmericanCheese = false;
            Assert.False(aab.AmericanCheese);
        }

        /// <summary>
        /// Tests if swiss cheese starts as false
        /// </summary>
        [Fact]
        public void SwissCheeseShouldDefaultToFalse()
        {
            AllosaurusAll_AmericanBurger aab = new();
            Assert.False(aab.SwissCheese);
        }

        /// <summary>
        /// Tests if you can set swiss cheese
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSwissCheese()
        {
            AllosaurusAll_AmericanBurger aab = new();
            aab.SwissCheese = true;
            Assert.True(aab.SwissCheese);
            aab.SwissCheese = false;
            Assert.False(aab.SwissCheese);
        }

        /// <summary>
        /// Tests if bacon starts as false
        /// </summary>
        [Fact]
        public void BaconShouldDefaultToFalse()
        {
            AllosaurusAll_AmericanBurger aab = new();
            Assert.False(aab.Bacon);
        }

        /// <summary>
        /// Tests if you can set bacon
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            AllosaurusAll_AmericanBurger aab = new();
            aab.Bacon = true;
            Assert.True(aab.Bacon);
            aab.Bacon = false;
            Assert.False(aab.Bacon);
        }

        /// <summary>
        /// Tests if mushroom starts at false
        /// </summary>
        [Fact]
        public void MushroomsShouldDefaultToFalse()
        {
            AllosaurusAll_AmericanBurger aab = new();
            Assert.False(aab.Mushrooms);
        }

        /// <summary>
        /// Tests if you can set mushrooms
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            AllosaurusAll_AmericanBurger aab = new();
            aab.Mushrooms = true;
            Assert.True(aab.Mushrooms);
            aab.Mushrooms = false;
            Assert.False(aab.Mushrooms);
        }
    }
}
