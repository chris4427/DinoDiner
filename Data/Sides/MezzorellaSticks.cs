using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Enums;

namespace DinoDiner.Data.Sides
{
    /// <summary>
    /// Represents mezzorella sticks side item
    /// </summary>
    public class MezzorellaSticks : Side
    {
        /// <summary>
        /// Name of item
        /// </summary>
        public override string Name { get { return $"{Size} Mezzorella Sticks"; } }

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
                    return 530;
                }
                else if (Size == ServingSize.Medium)
                {
                    return 620;
                }
                else
                {
                    return 730;
                }
            }
        }

        public override List<string> SpecialInstructions { get; }
    }
}
