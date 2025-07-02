using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// Represents a brautwurst with fried peppers and onions 
    /// </summary>
    public class Brontowurst : Entree , INotifyPropertyChanged
    {
        public Brontowurst()
        {

        }
        /// <summary>
        /// Name of item
        /// </summary>
        public override string Name { get { return "Brontowurst"; } }

        /// <summary>
        /// Price of item
        /// </summary>
        public override decimal Price { get { return 5.86m; } }

        /// <summary>
        /// Calories of item
        /// </summary>
        public override uint Calories { get { return 512; } }

        private bool _onions = true;
        /// <summary>
        /// Indicates if item has onions or not
        /// </summary>
        public bool Onions 
        {
            get => _onions;
            set
            {
                _onions = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            } 
        }

        private bool _peppers = true;
        /// <summary>
        /// Indicates if item has peppers or not
        /// </summary>
        public bool Peppers 
        {
            get => _peppers;
            set
            {
                _peppers = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        public override List<string> SpecialInstructions {

            get 
            {
                List<string> si = new();
                if (!Onions) si.Add("No Onions");
                if (!Peppers) si.Add("No Peppers");
                return si;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

    }
}
