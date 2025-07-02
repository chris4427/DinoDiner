using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTest
{
    /// <summary>
    /// Unit tests for carnotaurus cheeseburger class
    /// </summary>
    public class CarnotaurusCheeseburgerUnitTests
    {
        /// <summary>
        /// Tests if it enherits from entree
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            CarnotaurusCheeseburger cc = new();
            Assert.IsAssignableFrom<Entree>(cc);
        }

        /// <summary>
        /// Tests if name is correct
        /// </summary>
        [Fact]
        public void NameShouldBeCorrect()
        {
            CarnotaurusCheeseburger cc = new();
            Assert.Equal("Carnotaurus Cheeseburger", cc.Name);
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
            CarnotaurusCheeseburger cc = new();
            cc.Patties = patties;
            cc.Ketchup = ketchup;
            cc.Mustard = mustard;
            cc.Pickle = pickle;
            cc.Mayo = mayo;
            cc.BBQ = bbq;
            cc.Onion = onion;
            cc.Tomato = tomato;
            cc.Lettuce = lettuce;
            cc.AmericanCheese = ac;
            cc.SwissCheese = sc;
            cc.Bacon = bacon;
            cc.Mushrooms = mushrooms;
            Assert.Equal(price, cc.Price);
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
            CarnotaurusCheeseburger cc = new();
            cc.Patties = patties;
            cc.Ketchup = ketchup;
            cc.Mustard = mustard;
            cc.Pickle = pickle;
            cc.Mayo = mayo;
            cc.BBQ = bbq;
            cc.Onion = onion;
            cc.Tomato = tomato;
            cc.Lettuce = lettuce;
            cc.AmericanCheese = ac;
            cc.SwissCheese = sc;
            cc.Bacon = bacon;
            cc.Mushrooms = mushrooms;
            Assert.Equal(calories, cc.Calories);
        }

        /// <summary>
        /// Tests if # of patties starts at 1
        /// </summary>
        [Fact]
        public void PattiesShouldDefaultToOne()
        {
            CarnotaurusCheeseburger cc = new();
            Assert.Equal(1u, cc.Patties);
        }

        /// <summary>
        /// Tests if you can set patties
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPatties()
        {
            CarnotaurusCheeseburger cc = new();
            cc.Patties = 2;
            Assert.Equal(2u, cc.Patties);
            cc.Patties = 3;
            Assert.Equal(3u, cc.Patties);
        }

        /// <summary>
        /// Tests if ketchup starts as true
        /// </summary>
        [Fact]
        public void KetchupShouldDefaultToTrue()
        {
            CarnotaurusCheeseburger cc = new();
            Assert.True(cc.Ketchup);
        }

        /// <summary>
        /// Tests if you can set ketchup
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            CarnotaurusCheeseburger cc = new();
            cc.Ketchup = false;
            Assert.False(cc.Ketchup);
            cc.Ketchup = true;
            Assert.True(cc.Ketchup);
        }

        /// <summary>
        /// tests if mustard starts as true
        /// </summary>
        [Fact]
        public void MustardShouldDefaultToFalse()
        {
            CarnotaurusCheeseburger cc = new();
            Assert.False(cc.Mustard);
        }

        /// <summary>
        /// Tests if you can set mustard
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            CarnotaurusCheeseburger cc = new();
            cc.Mustard = false;
            Assert.False(cc.Mustard);
            cc.Mustard = true;
            Assert.True(cc.Mustard);
        }

        /// <summary>
        /// Tests if pickle starts as true
        /// </summary>
        [Fact]
        public void PickleShouldDefaultToTrue()
        {
            CarnotaurusCheeseburger cc = new();
            Assert.True(cc.Pickle);
        }

        /// <summary>
        /// Tests if you can set pickles
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            CarnotaurusCheeseburger cc = new();
            cc.Pickle = false;
            Assert.False(cc.Pickle);
            cc.Pickle = true;
            Assert.True(cc.Pickle);
        }

        /// <summary>
        /// Tests if mayo starts as false
        /// </summary>
        [Fact]
        public void MayoShouldDefaultToFalse()
        {
            CarnotaurusCheeseburger cc = new();
            Assert.False(cc.Mayo);
        }

        /// <summary>
        /// Tests if you can set mayo
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            CarnotaurusCheeseburger cc = new();
            cc.Mayo = true;
            Assert.True(cc.Mayo);
            cc.Mayo = false;
            Assert.False(cc.Mayo);
        }

        /// <summary>
        /// Tests if bbq starts as false
        /// </summary>
        [Fact]
        public void BBQShouldDefaultToFalse()
        {
            CarnotaurusCheeseburger cc = new();
            Assert.False(cc.BBQ);
        }

        /// <summary>
        /// Tests if you can set BBQ
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBBQ()
        {
            CarnotaurusCheeseburger cc = new();
            cc.BBQ = true;
            Assert.True(cc.BBQ);
            cc.BBQ = false;
            Assert.False(cc.BBQ);
        }

        /// <summary>
        /// Tests if onion starts as false
        /// </summary>
        [Fact]
        public void OnionShouldDefaultToFalse()
        {
            CarnotaurusCheeseburger cc = new();
            Assert.False(cc.Onion);
        }

        /// <summary>
        /// Tests if you can set onion
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetOnion()
        {
            CarnotaurusCheeseburger cc = new();
            cc.Onion = true;
            Assert.True(cc.Onion);
            cc.Onion = false;
            Assert.False(cc.Onion);
        }

        /// <summary>
        /// Tests if tomato starts as false
        /// </summary>
        [Fact]
        public void TomatoShouldDefaultToTrue()
        {
            CarnotaurusCheeseburger cc = new();
            Assert.True(cc.Tomato);
        }

        /// <summary>
        /// Tests if you can set tomato
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            CarnotaurusCheeseburger cc = new();
            cc.Tomato = true;
            Assert.True(cc.Tomato);
            cc.Tomato = false;
            Assert.False(cc.Tomato);
        }

        /// <summary>
        /// Tests if lettuce starts as false
        /// </summary>
        [Fact]
        public void LettuceShouldDefaultToFalse()
        {
            CarnotaurusCheeseburger cc = new();
            Assert.False(cc.Lettuce);
        }

        /// <summary>
        /// Tests if you can set lettuce
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            CarnotaurusCheeseburger cc = new();
            cc.Lettuce = true;
            Assert.True(cc.Lettuce);
            cc.Lettuce = false;
            Assert.False(cc.Lettuce);
        }

        /// <summary>
        /// Tests if american cheese starts as false
        /// </summary>
        [Fact]
        public void AmericanCheeseShouldDefaultToTrue()
        {
            CarnotaurusCheeseburger cc = new();
            Assert.True(cc.AmericanCheese);
        }

        /// <summary>
        /// Tests if you can set american cheese
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetAmericanCheese()
        {
            CarnotaurusCheeseburger cc = new();
            cc.AmericanCheese = true;
            Assert.True(cc.AmericanCheese);
            cc.AmericanCheese = false;
            Assert.False(cc.AmericanCheese);
        }

        /// <summary>
        /// Tests if swiss cheese starts as false
        /// </summary>
        [Fact]
        public void SwissCheeseShouldDefaultToFalse()
        {
            CarnotaurusCheeseburger cc = new();
            Assert.False(cc.SwissCheese);
        }

        /// <summary>
        /// Tests if you can set swiss cheese
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSwissCheese()
        {
            CarnotaurusCheeseburger cc = new();
            cc.SwissCheese = true;
            Assert.True(cc.SwissCheese);
            cc.SwissCheese = false;
            Assert.False(cc.SwissCheese);
        }

        /// <summary>
        /// Tests if bacon starts as false
        /// </summary>
        [Fact]
        public void BaconShouldDefaultToFalse()
        {
            CarnotaurusCheeseburger cc = new();
            Assert.False(cc.Bacon);
        }

        /// <summary>
        /// Tests if you can set bacon
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            CarnotaurusCheeseburger cc = new();
            cc.Bacon = true;
            Assert.True(cc.Bacon);
            cc.Bacon = false;
            Assert.False(cc.Bacon);
        }

        /// <summary>
        /// Tests if mushroom starts at false
        /// </summary>
        [Fact]
        public void MushroomsShouldDefaultToFalse()
        {
            CarnotaurusCheeseburger cc = new();
            Assert.False(cc.Mushrooms);
        }

        /// <summary>
        /// Tests if you can set mushrooms
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            CarnotaurusCheeseburger cc = new();
            cc.Mushrooms = true;
            Assert.True(cc.Mushrooms);
            cc.Mushrooms = false;
            Assert.False(cc.Mushrooms);
        }
    }
}
