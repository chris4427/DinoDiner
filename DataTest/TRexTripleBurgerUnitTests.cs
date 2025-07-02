using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTest
{
    /// <summary>
    /// Tests for trex triple burger
    /// </summary>
    public class TRexTripleBurgerUnitTests
    {
        /// <summary>
        /// Tests if it enherits from entree
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            TRexTriple trt = new();
            Assert.IsAssignableFrom<Entree>(trt);
        }

        /// <summary>
        /// Tests if name is correct
        /// </summary>
        [Fact]
        public void NameShouldBeCorrect()
        {
            TRexTriple trt = new();
            Assert.Equal("T-Rex Triple", trt.Name);
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
            TRexTriple trt = new();
            trt.Patties = patties;
            trt.Ketchup = ketchup;
            trt.Mustard = mustard;
            trt.Pickle = pickle;
            trt.Mayo = mayo;
            trt.BBQ = bbq;
            trt.Onion = onion;
            trt.Tomato = tomato;
            trt.Lettuce = lettuce;
            trt.AmericanCheese = ac;
            trt.SwissCheese = sc;
            trt.Bacon = bacon;
            trt.Mushrooms = mushrooms;
            Assert.Equal(price, trt.Price);
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
            TRexTriple trt = new();
            trt.Patties = patties;
            trt.Ketchup = ketchup;
            trt.Mustard = mustard;
            trt.Pickle = pickle;
            trt.Mayo = mayo;
            trt.BBQ = bbq;
            trt.Onion = onion;
            trt.Tomato = tomato;
            trt.Lettuce = lettuce;
            trt.AmericanCheese = ac;
            trt.SwissCheese = sc;
            trt.Bacon = bacon;
            trt.Mushrooms = mushrooms;
            Assert.Equal(calories, trt.Calories);
        }

        /// <summary>
        /// Tests if # of patties starts at 1
        /// </summary>
        [Fact]
        public void PattiesShouldDefaultToThree()
        {
            TRexTriple trt = new();
            Assert.Equal(3u, trt.Patties);
        }

        /// <summary>
        /// Tests if you can set patties
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPatties()
        {
            TRexTriple trt = new();
            trt.Patties = 4;
            Assert.Equal(4u, trt.Patties);
            trt.Patties = 5;
            Assert.Equal(5u, trt.Patties);
        }

        /// <summary>
        /// Tests if ketchup starts as true
        /// </summary>
        [Fact]
        public void KetchupShouldDefaultToTrue()
        {
            TRexTriple trt = new();
            Assert.True(trt.Ketchup);
        }

        /// <summary>
        /// Tests if you can set ketchup
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            TRexTriple trt = new();
            trt.Ketchup = false;
            Assert.False(trt.Ketchup);
            trt.Ketchup = true;
            Assert.True(trt.Ketchup);
        }

        /// <summary>
        /// tests if mustard starts as false
        /// </summary>
        [Fact]
        public void MustardShouldDefaultToFalse()
        {
            TRexTriple trt = new();
            Assert.False(trt.Mustard);
        }

        /// <summary>
        /// Tests if you can set mustard
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            TRexTriple trt = new();
            trt.Mustard = false;
            Assert.False(trt.Mustard);
            trt.Mustard = true;
            Assert.True(trt.Mustard);
        }

        /// <summary>
        /// Tests if pickle starts as true
        /// </summary>
        [Fact]
        public void PickleShouldDefaultToTrue()
        {
            TRexTriple trt = new();
            Assert.True(trt.Pickle);
        }

        /// <summary>
        /// Tests if you can set pickles
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            TRexTriple trt = new();
            trt.Pickle = false;
            Assert.False(trt.Pickle);
            trt.Pickle = true;
            Assert.True(trt.Pickle);
        }

        /// <summary>
        /// Tests if mayo starts as true
        /// </summary>
        [Fact]
        public void MayoShouldDefaultToTrue()
        {
            TRexTriple trt = new();
            Assert.True(trt.Mayo);
        }

        /// <summary>
        /// Tests if you can set mayo
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            TRexTriple trt = new();
            trt.Mayo = true;
            Assert.True(trt.Mayo);
            trt.Mayo = false;
            Assert.False(trt.Mayo);
        }

        /// <summary>
        /// Tests if bbq starts as false
        /// </summary>
        [Fact]
        public void BBQShouldDefaultToFalse()
        {
            TRexTriple trt = new();
            Assert.False(trt.BBQ);
        }

        /// <summary>
        /// Tests if you can set BBQ
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBBQ()
        {
            TRexTriple trt = new();
            trt.BBQ = true;
            Assert.True(trt.BBQ);
            trt.BBQ = false;
            Assert.False(trt.BBQ);
        }

        /// <summary>
        /// Tests if onion starts as true
        /// </summary>
        [Fact]
        public void OnionShouldDefaultToTrue()
        {
            TRexTriple trt = new();
            Assert.True(trt.Onion);
        }

        /// <summary>
        /// Tests if you can set onion
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetOnion()
        {
            TRexTriple trt = new();
            trt.Onion = true;
            Assert.True(trt.Onion);
            trt.Onion = false;
            Assert.False(trt.Onion);
        }

        /// <summary>
        /// Tests if tomato starts as true
        /// </summary>
        [Fact]
        public void TomatoShouldDefaultToTrue()
        {
            TRexTriple trt = new();
            Assert.True(trt.Tomato);
        }

        /// <summary>
        /// Tests if you can set tomato
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            TRexTriple trt = new();
            trt.Tomato = true;
            Assert.True(trt.Tomato);
            trt.Tomato = false;
            Assert.False(trt.Tomato);
        }

        /// <summary>
        /// Tests if lettuce starts as true
        /// </summary>
        [Fact]
        public void LettuceShouldDefaultToTrue()
        {
            TRexTriple trt = new();
            Assert.True(trt.Lettuce);
        }

        /// <summary>
        /// Tests if you can set lettuce
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            TRexTriple trt = new();
            trt.Lettuce = true;
            Assert.True(trt.Lettuce);
            trt.Lettuce = false;
            Assert.False(trt.Lettuce);
        }

        /// <summary>
        /// Tests if american cheese starts as false
        /// </summary>
        [Fact]
        public void AmericanCheeseShouldDefaultToFalse()
        {
            TRexTriple trt = new();
            Assert.False(trt.AmericanCheese);
        }

        /// <summary>
        /// Tests if you can set american cheese
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetAmericanCheese()
        {
            TRexTriple trt = new();
            trt.AmericanCheese = true;
            Assert.True(trt.AmericanCheese);
            trt.AmericanCheese = false;
            Assert.False(trt.AmericanCheese);
        }

        /// <summary>
        /// Tests if swiss cheese starts as false
        /// </summary>
        [Fact]
        public void SwissCheeseShouldDefaultToFalse()
        {
            TRexTriple trt = new();
            Assert.False(trt.SwissCheese);
        }

        /// <summary>
        /// Tests if you can set swiss cheese
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSwissCheese()
        {
            TRexTriple trt = new();
            trt.SwissCheese = true;
            Assert.True(trt.SwissCheese);
            trt.SwissCheese = false;
            Assert.False(trt.SwissCheese);
        }

        /// <summary>
        /// Tests if bacon starts as false
        /// </summary>
        [Fact]
        public void BaconShouldDefaultToFalse()
        {
            TRexTriple trt = new();
            Assert.False(trt.Bacon);
        }

        /// <summary>
        /// Tests if you can set bacon
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            TRexTriple trt = new();
            trt.Bacon = true;
            Assert.True(trt.Bacon);
            trt.Bacon = false;
            Assert.False(trt.Bacon);
        }

        /// <summary>
        /// Tests if mushroom starts at false
        /// </summary>
        [Fact]
        public void MushroomsShouldDefaultToFalse()
        {
            TRexTriple trt = new();
            Assert.False(trt.Mushrooms);
        }

        /// <summary>
        /// Tests if you can set mushrooms
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            TRexTriple trt = new();
            trt.Mushrooms = true;
            Assert.True(trt.Mushrooms);
            trt.Mushrooms = false;
            Assert.False(trt.Mushrooms);
        }
    }
}
