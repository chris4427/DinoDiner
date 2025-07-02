using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// Represetns dino nuggets item
    /// </summary>
    public class DinoNuggets : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Name and count of dino nuggets
        /// </summary>
        public override string Name { get { return $"{Count} Dino Nuggets"; } }

        /// <summary>
        /// Backing field for Count
        /// </summary>
        private uint _count = 6;
        /// <summary>
        /// How many dino nuggets there are
        /// </summary>
        public uint Count 
        {
            get => _count;

            set
            {
                _count = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            } 
        }

        /// <summary>
        /// Price of the dino nuggets
        /// </summary>
        public override decimal Price { get { return .25m * Count; } }

        /// <summary>
        /// Calories of the whole dino nugget item
        /// </summary>
        public override uint Calories { get { return 61 * Count; } }

        public override List<string> SpecialInstructions 
        {
            get
            {
                List<string> si = new();
                if (Count > 6) si.Add($"Add {Count - 1} Nugget(s)");
                if(Count < 6 && Count > 0) si.Add($"Remove {6 - Count} Nugget(s)");
                if (Count == 0) si.Add("No Nuggets");
                return si;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
