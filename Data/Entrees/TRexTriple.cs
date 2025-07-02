using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// Represents TRexTriple Burger
    /// </summary>
    public class TRexTriple : Burger
    {

        public TRexTriple()
        {
            Patties = 3;
            Ketchup = true;
            Pickle = true;
            Mayo = true;
            Onion = true;
            Lettuce = true;
            Tomato = true;
            SpecialInstructions.Clear();
        }

        /// <summary>
        /// The name of the Entree
        /// </summary>
        public override string Name { get { return "T-Rex Triple"; } }

        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> si = new();
                if (!Ketchup) si.Add("No Ketchup");
                if (Mustard) si.Add("Add Mustard");
                if (!Pickle) si.Add("No Pickle");
                if (!Mayo) si.Add("No Mayo");
                if (BBQ) si.Add("Add BBQ Sauce");
                if (!Onion) si.Add("No Onion");
                if (!Tomato) si.Add("No Tomato");
                if (!Lettuce) si.Add("No Lettuce");
                if (AmericanCheese) si.Add("Add American Cheese");
                if (SwissCheese) si.Add("Add Swiss Cheese");
                if (Bacon) si.Add("Add Bacon");
                if (Mushrooms) si.Add("Add Mushrooms");
                if (Patties > 3) si.Add($"Add {Patties - 3} Pattie(s)");
                if(Patties < 3 && Patties > 0) si.Add($"Remove {3 - Patties} Pattie(s)");
                if (Patties == 0) si.Add("No Patties");
                return si;
            }
        }

        /// <summary>
        /// Amount of patties
        /// </summary>
        //public override uint Patties { get { return 3; } }

        /// <summary>
        /// If burger has ketchup
        /// </summary>
        //public override bool Ketchup { get { return true; } }

        /// <summary>
        /// If burger has mayo
        /// </summary>
        //public override bool Mayo { get { return true; } }

        /// <summary>
        /// If burger has pickles
        /// </summary>
        //public override bool Pickle { get { return true; } }

        /// <summary>
        /// If burger has onions
        /// </summary>
        //public override bool Onion { get { return true; } }

        /// <summary>
        /// If burger has lettuce
        /// </summary>
        //public override bool Lettuce { get { return true; } }

        /// <summary>
        /// If burger has tomato
        /// </summary>
        //public override bool Tomato { get { return true; } }
    }
}
