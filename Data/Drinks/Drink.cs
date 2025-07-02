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
    /// An abstract class that represents a drink
    /// </summary>
    public abstract class Drink: MenuItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The name of the Drink
        /// </summary>
        //public abstract string Name { get; }

        /// <summary>
        /// Backing field for Size
        /// </summary>
        private ServingSize _size = ServingSize.Small;
        /// <summary>
        /// Size of drink
        /// </summary>
        public ServingSize Size 
        {
            get => _size;

            set
            {
                _size = value;
                OnPropertyChanged(nameof(this.Calories));
                OnPropertyChanged(nameof(this.Price));
            }
        }

        /// <summary>
        /// The price of the Entree
        /// </summary>
        //public abstract decimal Price { get; }

        /// <summary>
        /// The calories of the Entree
        /// </summary>
        //public abstract uint Calories { get; }

        /// <summary>
        /// helps with property change in inherited classes
        /// </summary>
        /// <param name="propertyName">property you want to change</param>
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
