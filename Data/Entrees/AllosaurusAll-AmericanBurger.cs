using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// Represents AllosaurusAll_AmericanBurger
    /// </summary>
    public class AllosaurusAll_AmericanBurger: Burger
    {
        public AllosaurusAll_AmericanBurger()
        {
            Ketchup = true;
            Mustard = true;
            Pickle = true;
            SpecialInstructions.Clear();
        }

        /// <summary>
        /// The name of the Entree
        /// </summary>
        public override string Name { get { return "Allosaurus All-American Burger"; } }

        /// <summary>
        /// Special Instrucitions for burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> si = new();
                if (!Ketchup) si.Add("No Ketchup");
                if (!Mustard) si.Add("No Mustard");
                if (!Pickle) si.Add("No Pickle");
                if (Mayo) si.Add("Add Mayo");
                if (BBQ) si.Add("Add BBQ Sauce");
                if (Onion) si.Add("Add Onion");
                if (Tomato) si.Add("Add Tomato");
                if (Lettuce) si.Add("Add Lettuce");
                if (AmericanCheese) si.Add("Add American Cheese");
                if (SwissCheese) si.Add("Add Swiss Cheese");
                if (Bacon) si.Add("Add Bacon");
                if (Mushrooms) si.Add("Add Mushrooms");
                if (Patties > 1) si.Add($"Add {Patties - 1} Pattie(s)");
                if (Patties == 0) si.Add("No Patties");
                return si;
            }
        }




        /// <summary>
        /// if burger has ketchup
        /// </summary>
        //public override bool Ketchup { get { return true; } }

        /// <summary>
        /// if burger has mustard
        /// </summary>
        //public override bool Mustard { get { return true; } }

        /// <summary>
        /// if burger has pickle
        /// </summary>
        //public override bool Pickle { get { return true; } }
    }
}
