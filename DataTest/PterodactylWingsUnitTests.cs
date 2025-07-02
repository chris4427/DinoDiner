using DinoDiner.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTest
{
    /// <summary>
    /// Unit tests for pterodactylwings class
    /// </summary>
    public class PterodactylWingsUnitTests
    {
        /// <summary>
        /// Should inherit from entree
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            PterodactylWings pw = new();
            Assert.IsAssignableFrom<Entree>(pw);
        }

        /// <summary>
        /// Name should be {Sauce} Pterodactyl Wings
        /// </summary>
        /// <param name="ws">type of sauce on wings</param>
        /// <param name="en">expected name</param>
        [Theory]
        [InlineData(WingSauce.Buffalo, "Buffalo Pterodactyl Wings")]
        [InlineData(WingSauce.Teriyaki, "Teriyaki Pterodactyl Wings")]
        [InlineData(WingSauce.HoneyGlaze, "Honey Glaze Pterodactyl Wings")]
        public void NameShouldBeCorrect(WingSauce ws, string en)
        {
            PterodactylWings pw = new();
            pw.Sauce = ws;
            Assert.Equal(en, pw.Name);
        }

        /// <summary>
        /// Price should be 8.95
        /// </summary>
        /// <param name="ws">type of sauce on wing</param>
        [Theory]
        [InlineData(WingSauce.Buffalo)]
        [InlineData(WingSauce.Teriyaki)]
        [InlineData(WingSauce.HoneyGlaze)]
        public void PriceShouldBeCorrect(WingSauce ws)
        {
            PterodactylWings pw = new();
            pw.Sauce = ws;
            Assert.Equal(8.95m, pw.Price);
        }

        /// <summary>
        /// Calories should be correct
        /// </summary>
        [Fact]
        public void CaloriesShouldBeCorrect()
        {
            PterodactylWings pw = new();
            Assert.Equal(360u, pw.Calories);
            pw.Sauce = WingSauce.Teriyaki;
            Assert.Equal(342u, pw.Calories);
            pw.Sauce = WingSauce.HoneyGlaze;
            Assert.Equal(359u, pw.Calories);
        }

        /// <summary>
        /// Sauce should be buffalo when intialized
        /// </summary>
        [Fact]
        public void SauceShouldDefaultToBuffalo()
        {
            PterodactylWings pw = new();
            Assert.Equal(WingSauce.Buffalo, pw.Sauce);
        }

        /// <summary>
        /// should be able to set sauce property
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSauce()
        {
            PterodactylWings pw = new();
            pw.Sauce = WingSauce.Teriyaki;
            Assert.Equal(WingSauce.Teriyaki, pw.Sauce);
            pw.Sauce = WingSauce.HoneyGlaze;
            Assert.Equal(WingSauce.HoneyGlaze, pw.Sauce);
            pw.Sauce = WingSauce.Buffalo;
            Assert.Equal(WingSauce.Buffalo, pw.Sauce);
        }

    }
}
