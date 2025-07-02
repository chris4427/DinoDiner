using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// Abstract class represetning a burger
    /// </summary>
    public abstract class Burger: Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// private backing field for Patties
        /// </summary>
        private uint _patties = 1;
        /// <summary>
        /// Amount of patties on burger
        /// </summary>
        public virtual uint Patties
        {
            get => _patties;

            set
            {
                _patties = value;
                OnPropertyChanged(nameof(this.Patties));
                OnPropertyChanged(nameof(this.Price));
                OnPropertyChanged(nameof(this.Calories));

                //this.SpecialInstructions.Add($"{value} Patties");
                OnPropertyChanged(nameof(this.SpecialInstructions));
            }
        }

        /// <summary>
        /// private backing field for Ketchup
        /// </summary>
        protected bool _ketchup = false;
        /// <summary>
        /// If burger has ketchup
        /// </summary>
        public virtual bool Ketchup
        {
            get => _ketchup;

            set
            {
                _ketchup = value;
                OnPropertyChanged(nameof(this.Ketchup));
                OnPropertyChanged(nameof(this.Price));
                OnPropertyChanged(nameof(this.Calories));
                OnPropertyChanged(nameof(this.SpecialInstructions));

                //if (value == true) this.SpecialInstructions.Add("Add Ketchup");
                //if (value == false) this.SpecialInstructions.Add("No Ketchup"); 
                //OnPropertyChanged(nameof(this.SpecialInstructions));
            }
        }

        /// <summary>
        /// Backing field for Mustard
        /// </summary>
        private bool _mustard = false;
        /// <summary>
        /// If burger has mustard
        /// </summary>
        public virtual bool Mustard
        {
            get => _mustard;

            set
            {
                _mustard = value;
                OnPropertyChanged(nameof(this.Mustard));
                OnPropertyChanged(nameof(this.Price));
                OnPropertyChanged(nameof(this.Calories));
                OnPropertyChanged(nameof(this.SpecialInstructions));
            }
        }

        /// <summary>
        /// Backing field for Pickle
        /// </summary>
        private bool _pickle = false;
        /// <summary>
        /// If buger has pickles
        /// </summary>
        public virtual bool Pickle
        {
            get => _pickle;

            set
            {
                _pickle = value;
                OnPropertyChanged(nameof(this.Pickle));
                OnPropertyChanged(nameof(this.Price));
                OnPropertyChanged(nameof(this.Calories));
                OnPropertyChanged(nameof(this.SpecialInstructions));
            }
        }

        /// <summary>
        /// Backing field for Mayo
        /// </summary>
        private bool _mayo = false;
        /// <summary>
        /// If burger has mayo
        /// </summary>
        public virtual bool Mayo
        {
            get => _mayo;

            set
            {
                _mayo = value;
                OnPropertyChanged(nameof(this.Mayo));
                OnPropertyChanged(nameof(this.Price));
                OnPropertyChanged(nameof(this.Calories));
                OnPropertyChanged(nameof(this.SpecialInstructions));
            }
        }

        /// <summary>
        /// Backing field for BBQ
        /// </summary>
        private bool _bbq = false;
        /// <summary>
        /// If burger has BBQ sauce
        /// </summary>
        public virtual bool BBQ
        {
            get => _bbq;

            set
            {
                _bbq = value;
                OnPropertyChanged(nameof(this.BBQ));
                OnPropertyChanged(nameof(this.Price));
                OnPropertyChanged(nameof(this.Calories));
                OnPropertyChanged(nameof(this.SpecialInstructions));
            }
        }

        /// <summary>
        /// Backing field for Onion
        /// </summary>
        private bool _onion = false;
        /// <summary>
        /// If burger has onions
        /// </summary>
        public virtual bool Onion
        {
            get => _onion;

            set
            {
                _onion = value;
                OnPropertyChanged(nameof(this.Onion));
                OnPropertyChanged(nameof(this.Price));
                OnPropertyChanged(nameof(this.Calories));
                OnPropertyChanged(nameof(this.SpecialInstructions));
            }
        }

        /// <summary>
        /// Backing field for Tomato
        /// </summary>
        private bool _tomato = false;
        /// <summary>
        /// If burger has tomato
        /// </summary>
        public virtual bool Tomato
        {
            get => _tomato;

            set
            {
                _tomato = value;
                OnPropertyChanged(nameof(this.Tomato));
                OnPropertyChanged(nameof(this.Price));
                OnPropertyChanged(nameof(this.Calories));
                OnPropertyChanged(nameof(this.SpecialInstructions));
            }
        }

        /// <summary>
        /// Backing field for Lettuce
        /// </summary>
        private bool _lettuce = false;
        /// <summary>
        /// If burger has lettuce
        /// </summary>
        public virtual bool Lettuce
        {
            get => _lettuce;

            set
            {
                _lettuce = value;
                OnPropertyChanged(nameof(this.Lettuce));
                OnPropertyChanged(nameof(this.Price));
                OnPropertyChanged(nameof(this.Calories));
                OnPropertyChanged(nameof(this.SpecialInstructions));
            }
        }

        /// <summary>
        /// Backing field for AmericanCheese
        /// </summary>
        private bool _americanCheese = false;
        /// <summary>
        /// If burger has american cheese
        /// </summary>
        public virtual bool AmericanCheese
        {
            get => _americanCheese;

            set
            {
                _americanCheese = value;
                OnPropertyChanged(nameof(this.AmericanCheese));
                OnPropertyChanged(nameof(this.Price));
                OnPropertyChanged(nameof(this.Calories));
                OnPropertyChanged(nameof(this.SpecialInstructions));
            }
        }

        /// <summary>
        /// Backing field for SwissCheese
        /// </summary>
        private bool _swissCheese = false;
        /// <summary>
        /// If burger has Swiss Cheese
        /// </summary>
        public virtual bool SwissCheese
        {
            get => _swissCheese;

            set
            {
                _swissCheese = value;
                OnPropertyChanged(nameof(this.SwissCheese));
                OnPropertyChanged(nameof(this.Price));
                OnPropertyChanged(nameof(this.Calories));
                OnPropertyChanged(nameof(this.SpecialInstructions));
            }
        }

        /// <summary>
        /// Backing field for Bacon
        /// </summary>
        private bool _bacon = false;
        /// <summary>
        /// If burger has bacon
        /// </summary>
        public virtual bool Bacon
        {
            get => _bacon;

            set
            {
                _bacon = value;
                OnPropertyChanged(nameof(this.Bacon));
                OnPropertyChanged(nameof(this.Price));
                OnPropertyChanged(nameof(this.Calories));
                OnPropertyChanged(nameof(this.SpecialInstructions));
            }
        }

        /// <summary>
        /// Backing field for Mushrooms
        /// </summary>
        private bool _mushrooms = false;
        /// <summary>
        /// If burger has mushrooms
        /// </summary>
        public virtual bool Mushrooms
        {
            get => _mushrooms;

            set
            {
                _mushrooms = value;
                OnPropertyChanged(nameof(this.Mushrooms));
                OnPropertyChanged(nameof(this.Price));
                OnPropertyChanged(nameof(this.Calories));
                OnPropertyChanged(nameof(this.SpecialInstructions));
            }
        }

        /// <summary>
        /// private backing field for Price
        /// </summary>
        private decimal _price = 0;
        /// <summary>
        /// Price of burger
        /// </summary>
        public override decimal Price
        {
            get
            {
                _price = 0;
                _price += 1.50m * Patties;
                if (Ketchup) _price += .20m;
                if (Mustard) _price += .20m;
                if (Pickle) _price += .20m;
                if (Mayo) _price += .20m;
                if (BBQ) _price += .10m;
                if (Onion) _price += .40m;
                if (Tomato) _price += .40m;
                if (Lettuce) _price += .30m;
                if (AmericanCheese) _price += .25m;
                if (SwissCheese) _price += .25m;
                if (Bacon) _price += .50m;
                if (Mushrooms) _price += .40m;
                return _price;
            }
        }

        /// <summary>
        /// Backing field for Calories
        /// </summary>
        private uint _calories = 0;
        /// <summary>
        /// Calories in burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                _calories = 0;
                if (Ketchup) _calories += 19;
                if (Mustard) _calories += 3;
                if (Pickle) _calories += 7;
                if (Mayo) _calories += 94;
                if (BBQ) _calories += 29;
                if (Onion) _calories += 44;
                if (Tomato) _calories += 22;
                if (Lettuce) _calories += 5;
                if (AmericanCheese) _calories += 104;
                if (SwissCheese) _calories += 106;
                if (Bacon) _calories += 43;
                if (Mushrooms) _calories += 4;
                _calories += 204 * Patties;
                return _calories;
            }
        }

        /// <summary>
        /// Special instruction for menu item
        /// </summary>
        //public override List<string> SpecialInstructions { get; }

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
