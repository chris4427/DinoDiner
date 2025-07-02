using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Enums;

namespace DinoDiner.Data.Sides
{
    /// <summary>
    /// represents mac and cheese menu item
    /// </summary>
    public class MeteorMacAndCheese : Side
    {
        /// <summary>
        /// Name of item
        /// </summary>
        public override string Name { get { return $"{Size} Meteor Mac & Cheese"; } }


        /// <summary>
        /// Price of item
        /// </summary>
        public override decimal Price
        {
            get
            {
                if (Size == ServingSize.Small)
                {
                    return 3.50m;
                }
                else if (Size == ServingSize.Medium)
                {
                    return 4.00m;
                }
                else
                {
                    return 5.25m;
                }
            }
        }

        /// <summary>
        /// Calories of particular size of item
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == ServingSize.Small)
                {
                    return 425;
                }
                else if (Size == ServingSize.Medium)
                {
                    return 510;
                }
                else
                {
                    return 700;
                }
            }
        }

        public override List<string> SpecialInstructions { get; }
    }
}
