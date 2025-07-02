using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// represents CarnotaurusCheeseburger
    /// </summary>
    public class CarnotaurusCheeseburger : Burger
    {

        public CarnotaurusCheeseburger()
        {
            Tomato = true;
            Ketchup = true;
            Pickle = true;
            AmericanCheese = true;
            SpecialInstructions.Clear();
        }

        /// <summary>
        /// The name of the Entree
        /// </summary>
        public override string Name { get { return "Carnotaurus Cheeseburger"; } }

        /// <summary>
        /// Special Instrucitions for burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> si = new();
                if (!Ketchup) si.Add("No Ketchup");
                if (Mustard) si.Add("Add Mustard");
                if (!Pickle) si.Add("No Pickle");
                if (Mayo) si.Add("Add Mayo");
                if (BBQ) si.Add("Add BBQ Sauce");
                if (Onion) si.Add("Add Onion");
                if (!Tomato) si.Add("No Tomato");
                if (Lettuce) si.Add("Add Lettuce");
                if (!AmericanCheese) si.Add("No American Cheese");
                if (SwissCheese) si.Add("Add Swiss Cheese");
                if (Bacon) si.Add("Add Bacon");
                if (Mushrooms) si.Add("Add Mushrooms");
                if (Patties > 1) si.Add($"Add {Patties - 1} Pattie(s)");
                if (Patties == 0) si.Add("No Patties");
                return si;
            }
        }

        /// <summary>
        /// if burger has tomato
        /// </summary>
        //public override bool Tomato { get { return true; } }

        /// <summary>
        /// if burger has ketchup
        /// </summary>
        //public override bool Ketchup { get { return true; } }

        /// <summary>
        /// if burger has pickle
        /// </summary>
        //public override bool Pickle { get { return true; } }

        /// <summary>
        /// if burger has american cheese
        /// </summary>
        //public override bool AmericanCheese { get { return true; } }
    }
}
