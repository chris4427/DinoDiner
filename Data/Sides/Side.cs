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
    /// An abstract class the represents a side item
    /// </summary>
    public abstract class Side: MenuItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The name of the Entree
        /// </summary>
        //public abstract string Name { get; }

        /// <summary>
        /// Backing field for Size
        /// </summary>
        private ServingSize _size = ServingSize.Small;
        /// <summary>
        /// Size of side
        /// </summary>
        public ServingSize Size 
        {
            get => _size;

            set
            {
                _size = value;
                OnPropertyChanged(nameof(this.Price));
                OnPropertyChanged(nameof(this.Name));
                OnPropertyChanged(nameof(this.Calories));
                OnPropertyChanged(nameof(this.Size));
            } 
        }

        /// <summary>
        /// The price of the Entree
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
                    return 5.00m;
                }
            } 
        }

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
