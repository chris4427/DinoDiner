using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Enums;

namespace DinoDiner.Data.Sides
{
    /// <summary>
    /// represetns triceritots menu item
    /// </summary>
    public class Triceritots : Side
    {
        /// <summary>
        /// Name of item
        /// </summary>
        public override string Name { get { return $"{Size} Triceritots"; } }


        /// <summary>
        /// Calories of particular size of item
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == ServingSize.Small)
                {
                    return 351;
                }
                else if (Size == ServingSize.Medium)
                {
                    return 409;
                }
                else
                {
                    return 583;
                }
            }
        }

        public override List<string> SpecialInstructions { get; }
    }
}
