using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// Rrpresents Veloci-Wraptor item
    /// </summary>
    public class VelociWraptor : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Name of item
        /// </summary>
        public override string Name { get { return "Veloci-Wraptor"; } }

        /// <summary>
        /// Price of item
        /// </summary>
        public override decimal Price { get { return 6.25m; } }

        /// <summary>
        /// Calories of item
        /// </summary>
        public override uint Calories
        {
            get
            {
                if(Dressing && Cheese)
                {
                    return 732;
                }
                else if(Cheese && !Dressing)
                {
                    return 732 - 94;
                }
                else if(!Cheese && Dressing)
                {
                    return 732 - 22;
                }
                else
                {
                    return 732 - 94 - 22;
                }

            }
        }

        /// <summary>
        /// Backing field for Dressing
        /// </summary>
        private bool _dressing = true;
        /// <summary>
        /// Indicates if wrap has dressing
        /// </summary>
        public bool Dressing 
        { 
            get => _dressing;

            set
            {
                _dressing = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            } 
        }

        /// <summary>
        /// Backing field for Cheese
        /// </summary>
        private bool _cheese = true;
        /// <summary>
        /// Indicates if wrap has cheese
        /// </summary>
        public bool Cheese 
        {
            get => _cheese;

            set
            {
                _cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            } 
        }

        public override List<string> SpecialInstructions 
        {
            get
            {
                List<string> si = new();
                if (!Cheese) si.Add("No Cheese");
                if (!Dressing) si.Add("No Dressing");
                return si;
            } 
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
