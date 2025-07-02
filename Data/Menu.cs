using DinoDiner.Data.Drinks;
using DinoDiner.Data.Entrees;
using DinoDiner.Data.Enums;
using DinoDiner.Data.Sides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data
{
    public static class Menu
    {
        private static List<ServingSize> _servingSizes = Enum.GetValues(typeof(ServingSize)).Cast<ServingSize>().ToList();

        private static List<SodaFlavor> _sodaFlavors = Enum.GetValues(typeof(SodaFlavor)).Cast<SodaFlavor>().ToList();

        private static List<WingSauce> _wingSauces = Enum.GetValues(typeof(WingSauce)).Cast<WingSauce>().ToList();

        private static List<MenuItem> _entrees = new List<MenuItem>();
        public static IEnumerable<MenuItem> Entrees => _entrees;

        private static List<MenuItem> _sides = new List<MenuItem>();
        public static IEnumerable<MenuItem> Sides => _sides;

        private static List<MenuItem> _drinks = new List<MenuItem>();
        public static IEnumerable<MenuItem> Drinks => _drinks;

        private static List<MenuItem> _fullMenu = new List<MenuItem>();
        public static IEnumerable<MenuItem> FullMenu => _fullMenu;

        static Menu()
        {
            //Entrees
            foreach (WingSauce ws in _wingSauces)
            {
                _entrees.Add(new PterodactylWings() { Sauce = ws });
            }
            _entrees.Add(new AllosaurusAll_AmericanBurger());
            _entrees.Add(new Brontowurst());
            _entrees.Add(new CarnotaurusCheeseburger());
            _entrees.Add(new DeinonychusDouble());
            _entrees.Add(new DinoNuggets());
            _entrees.Add(new PrehistoricPBJ());
            _entrees.Add(new TRexTriple());
            _entrees.Add(new VelociWraptor());

            //Sides
            foreach (ServingSize servingSize in _servingSizes)
            {
                _sides.Add(new Fryceritops() { Size = servingSize});
                _sides.Add(new MeteorMacAndCheese() { Size = servingSize });
                _sides.Add(new MezzorellaSticks() { Size = servingSize });
                _sides.Add(new Triceritots() { Size = servingSize });
            }

            //Drinks
            foreach(ServingSize ss in _servingSizes)
            {
                _drinks.Add(new CretaceousCoffee() { Size = ss });
                foreach(SodaFlavor sodaFlavor in _sodaFlavors)
                {
                    _drinks.Add(new Plilosoda() { Size= ss, Flavor = sodaFlavor });
                }
            }

            //full menu
            foreach (MenuItem item in Entrees)
            {
                _fullMenu.Add(item);
            }
            foreach (MenuItem item in Sides)
            {
                _fullMenu.Add(item);
            }
            foreach (MenuItem item in Drinks)
            {
                _fullMenu.Add(item);
            }
        }
    }
}
