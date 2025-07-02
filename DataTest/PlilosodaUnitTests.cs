using DinoDiner.Data.Drinks;
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
    /// Tests for plilosoda
    /// </summary>
    public class PlilosodaUnitTests
    {
        /// <summary>
        /// Tests if class inherits from drink
        /// </summary>
        [Fact]
        public void ShouldInheritFromDrink()
        {
            Plilosoda ps = new();
            Assert.IsAssignableFrom<Drink>(ps);
        }

        /// <summary>
        /// Tests if name of plilsoda is correct
        /// </summary>
        /// <param name="name">expected name</param>
        /// <param name="size">size of soda</param>
        /// <param name="flavor">type of soda</param>
        [Theory]
        [InlineData("Small Cola Plilosoda", ServingSize.Small, SodaFlavor.Cola )]
        [InlineData("Small Cherry Cola Plilosoda", ServingSize.Small, SodaFlavor.CherryCola)]
        [InlineData("Small Lemon-Lime Plilosoda", ServingSize.Small, SodaFlavor.LemonLime)]
        [InlineData("Small Dino Dew Plilosoda", ServingSize.Small, SodaFlavor.DinoDew)]
        [InlineData("Small Doctor Dino Plilosoda", ServingSize.Small, SodaFlavor.DoctorDino)]
        [InlineData("Medium Cola Plilosoda", ServingSize.Medium, SodaFlavor.Cola)]
        [InlineData("Medium Cherry Cola Plilosoda", ServingSize.Medium, SodaFlavor.CherryCola)]
        [InlineData("Medium Lemon-Lime Plilosoda", ServingSize.Medium, SodaFlavor.LemonLime)]
        [InlineData("Medium Dino Dew Plilosoda", ServingSize.Medium, SodaFlavor.DinoDew)]
        [InlineData("Medium Doctor Dino Plilosoda", ServingSize.Medium, SodaFlavor.DoctorDino)]
        [InlineData("Large Cola Plilosoda", ServingSize.Large, SodaFlavor.Cola)]
        [InlineData("Large Cherry Cola Plilosoda", ServingSize.Large, SodaFlavor.CherryCola)]
        [InlineData("Large Lemon-Lime Plilosoda", ServingSize.Large, SodaFlavor.LemonLime)]
        [InlineData("Large Dino Dew Plilosoda", ServingSize.Large, SodaFlavor.DinoDew)]
        [InlineData("Large Doctor Dino Plilosoda", ServingSize.Large, SodaFlavor.DoctorDino)]
        public void NameShouldBeCorrect(string name, ServingSize size, SodaFlavor flavor )
        {
            Plilosoda ps = new();
            ps.Flavor = flavor;
            ps.Size = size;
            Assert.Equal(name, ps.Name);
        }

        /// <summary>
        /// Tests if price is correct
        /// </summary>
        /// <param name="price">expected price</param>
        /// <param name="size">size of the side</param>
        [Theory]
        [InlineData(1.00, ServingSize.Small)]
        [InlineData(1.75, ServingSize.Medium)]
        [InlineData(2.50, ServingSize.Large)]
        public void PriceShouldBeCorrect(decimal price, ServingSize size)
        {
            Plilosoda ps = new();
            ps.Size = size;
            Assert.Equal(price, ps.Price);
        }

        /// <summary>
        /// Tests if calories is correct
        /// </summary>
        /// <param name="calories">expected calories</param>
        /// <param name="size">size of soda</param>
        /// <param name="flavor">flavor of soda</param>
        [Theory]
        [InlineData(180, ServingSize.Small, SodaFlavor.Cola)]
        [InlineData(100, ServingSize.Small, SodaFlavor.CherryCola)]
        [InlineData(41, ServingSize.Small, SodaFlavor.LemonLime)]
        [InlineData(141, ServingSize.Small, SodaFlavor.DinoDew)]
        [InlineData(120, ServingSize.Small, SodaFlavor.DoctorDino)]
        [InlineData(288, ServingSize.Medium, SodaFlavor.Cola)]
        [InlineData(160, ServingSize.Medium, SodaFlavor.CherryCola)]
        [InlineData(66, ServingSize.Medium, SodaFlavor.LemonLime)]
        [InlineData(256, ServingSize.Medium, SodaFlavor.DinoDew)]
        [InlineData(192, ServingSize.Medium, SodaFlavor.DoctorDino)]
        [InlineData(432, ServingSize.Large, SodaFlavor.Cola)]
        [InlineData(240, ServingSize.Large, SodaFlavor.CherryCola)]
        [InlineData(98, ServingSize.Large, SodaFlavor.LemonLime)]
        [InlineData(338, ServingSize.Large, SodaFlavor.DinoDew)]
        [InlineData(288, ServingSize.Large, SodaFlavor.DoctorDino)]
        public void CaloriesShouldBeCorrect(uint calories, ServingSize size, SodaFlavor flavor)
        {
            Plilosoda ps = new();
            ps.Size = size;
            ps.Flavor = flavor; 
            Assert.Equal(calories, ps.Calories);
        }

        /// <summary>
        /// Tests if you can set size
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            Plilosoda ps = new();
            ps.Size = ServingSize.Medium;
            Assert.Equal(ServingSize.Medium, ps.Size);
            ps.Size = ServingSize.Large;
            Assert.Equal(ServingSize.Large, ps.Size);
            ps.Size = ServingSize.Small;
            Assert.Equal(ServingSize.Small, ps.Size);
        }

        /// <summary>
        /// Tests if you can set flavor
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            Plilosoda ps = new();
            ps.Flavor = SodaFlavor.Cola;
            Assert.Equal(SodaFlavor.Cola, ps.Flavor);
            ps.Flavor = SodaFlavor.CherryCola;
            Assert.Equal(SodaFlavor.CherryCola, ps.Flavor);
            ps.Flavor = SodaFlavor.DinoDew;
            Assert.Equal(SodaFlavor.DinoDew, ps.Flavor);
            ps.Flavor = SodaFlavor.DoctorDino;
            Assert.Equal(SodaFlavor.DoctorDino, ps.Flavor);
            ps.Flavor = SodaFlavor.LemonLime;
            Assert.Equal(SodaFlavor.LemonLime, ps.Flavor);
        }
    }
}
