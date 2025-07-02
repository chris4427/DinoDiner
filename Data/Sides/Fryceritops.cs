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
    /// represetns fry menu item
    /// </summary>
    public class Fryceritops : Side, INotifyPropertyChanged
    {
        /// <summary>
        /// Name of item
        /// </summary>
        public override string Name { get { return $"{Size} Fryceritops"; } }

        private bool _salt = true;
        /// <summary>
        /// Indicates if item is salted
        /// </summary>
        public bool Salt
        {
            get => _salt;
            set
            {
                _salt = value;
                OnPropertyChanged(nameof(this.SpecialInstructions));
            }
        }

        /// <summary>
        /// Backing field for Sauce
        /// </summary>
        private bool _sauce = false;
        /// <summary>
        /// Indicates if item is served with fry sauce
        /// </summary>
        public bool Sauce 
        {
            get => _sauce;

            set
            {
                _sauce = value;
                OnPropertyChanged(nameof(this.Calories));
                OnPropertyChanged(nameof(this.SpecialInstructions));
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
                    if(Sauce) return 365 + 80;
                    return 365;
                }
                else if (Size == ServingSize.Medium)
                {
                    if(Sauce)return 465 + 80;
                    return 465;
                }
                else
                {
                    if(Sauce) return 510 + 80;
                    return 510;
                }
            }
        }

        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> si = new();
                if (!Salt) si.Add("No Salt");
                if (Sauce) si.Add("Add Sauce");
                return si;
            }
        }
    }
}
