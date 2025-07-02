using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// Represents deinonychus double burger
    /// </summary>
    public class DeinonychusDouble: Burger
    {
        public DeinonychusDouble()
        {
            BBQ = true;
            Pickle = true;
            Onion = true;
            Mushrooms = true;
            SwissCheese = true;
            Patties = 2;
            SpecialInstructions.Clear();
        }

        /// <summary>
        /// The name of the Entree
        /// </summary>
        public override string Name { get { return "Deinonychus Double"; } }

        /// <summary>
        /// Special Instrucitions for burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> si = new();
                if (Ketchup) si.Add("Add Ketchup");
                if (Mustard) si.Add("Add Mustard");
                if (!Pickle) si.Add("No Pickle");
                if (Mayo) si.Add("Add Mayo");
                if (!BBQ) si.Add("No BBQ Sauce");
                if (!Onion) si.Add("No Onion");
                if (Tomato) si.Add("Add Tomato");
                if (Lettuce) si.Add("Add Lettuce");
                if (AmericanCheese) si.Add("Add American Cheese");
                if (!SwissCheese) si.Add("No Swiss Cheese");
                if (Bacon) si.Add("Add Bacon");
                if (!Mushrooms) si.Add("No Mushrooms");
                if (Patties > 2) si.Add($"Add {Patties - 2} Pattie(s)");
                if (Patties == 0) si.Add("No Patties");
                return si;
            }
        }

        /// <summary>
        /// if burger has bbq sauce
        /// </summary>
        //public override bool BBQ { get { return true; } }

        /// <summary>
        /// if burger has pickle
        /// </summary>
        //public override bool Pickle { get { return true; } }

        /// <summary>
        /// if burger has onion
        /// </summary>
        //public override bool Onion { get { return true; } }

        /// <summary>
        /// if burger has mushrooms
        /// </summary>
        //public override bool Mushrooms { get { return true; } }

        /// <summary>
        /// if burger has swiss cheese
        /// </summary>
        //public override bool SwissCheese { get { return true; } }

        /// <summary>
        /// how many patties the burger has
        /// </summary>
        //public override uint Patties { get { return 2; } }
    }
}
