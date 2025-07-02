using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data
{
    /// <summary>
    /// Class for menuitem
    /// </summary>
    public abstract class MenuItem : INotifyPropertyChanged
    {
        /// <summary>
        /// name of menu item
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// price of menu item
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// calories of menu item
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instruction for menu item
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
