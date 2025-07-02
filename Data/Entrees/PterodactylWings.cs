using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Enums;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// represetns an order of pterodactyl wings
    /// </summary>
    public class PterodactylWings : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Gives name and sauce of wings
        /// </summary>
        public override string Name 
        { 
            get 
            {
                if (Sauce == WingSauce.Buffalo || Sauce == WingSauce.Teriyaki) return $"{Sauce} Pterodactyl Wings";
                else return "Honey Glaze Pterodactyl Wings";
            } 
        }

        /// <summary>
        /// Backing field for Sauce
        /// </summary>
        private WingSauce _sauce = WingSauce.Buffalo;

        /// <summary>
        /// Type of sauce on wings
        /// </summary>
        public WingSauce Sauce 
        {
            get => _sauce;

            set
            {
                _sauce = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        /// <summary>
        /// price of wings
        /// </summary>
        public override decimal Price { get { return 8.95m; } }

        /// <summary>
        /// Calories of wings
        /// </summary>
        public override uint Calories 
        { 
            get
            {
                switch (Sauce)
                {
                    case WingSauce.Buffalo:
                        return 360;
                    case WingSauce.Teriyaki:
                        return 342;
                    case WingSauce.HoneyGlaze:
                        return 359;
                }

                throw new Exception("Sauce should default to buffalo");
            } 
        }

        public override List<string> SpecialInstructions { get; }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
