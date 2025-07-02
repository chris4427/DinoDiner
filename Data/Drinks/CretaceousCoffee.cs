using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Enums;

namespace DinoDiner.Data.Drinks
{
    /// <summary>
    /// Represents cretaceous coffee drink item
    /// </summary>
    public class CretaceousCoffee: Drink
    {
        /// <summary>
        /// The name of the Entree
        /// </summary>
        public override string Name { get { return $"{Size} Cretaceous Coffee"; } }

        /// <summary>
        /// Price of the entree
        /// </summary>
        public override decimal Price
        {
            get
            {
                if (Size == ServingSize.Small) return .75m;
                else if (Size == ServingSize.Medium) return 1.25m;
                else return 2.00m;
            }
        }

        /// <summary>
        /// Calories in entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Cream) return 64;
                else return 0;
            }
        }

        /// <summary>
        /// Backing field for Cream
        /// </summary>
        private bool _cream = false;
        /// <summary>
        /// if coffee has cream
        /// </summary>
        public bool Cream 
        {
            get => _cream;

            set
            {
                _cream = value;
                OnPropertyChanged(nameof(this.Calories));
                OnPropertyChanged(nameof(this.SpecialInstructions));
            }
        }

        public override List<string> SpecialInstructions
        {

            get
            {
                List<string> si = new();
                if (Cream) si.Add("Add Cream");
                return si;
            }
        }
    }
}
