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
    /// Represents a philosoda drink
    /// </summary>
    public class Plilosoda: Drink
    {
        /// <summary>
        /// The name of the Entree
        /// </summary>
        public override string Name 
        {
            get
            {
                if(Size == ServingSize.Small)
                {
                    if(Flavor == SodaFlavor.Cola) return $"{Size} Cola Plilosoda";
                    else if(Flavor == SodaFlavor.CherryCola) return $"{Size} Cherry Cola Plilosoda";
                    else if(Flavor == SodaFlavor.DoctorDino) return $"{Size} Doctor Dino Plilosoda";
                    else if(Flavor == SodaFlavor.LemonLime) return $"{Size} Lemon-Lime Plilosoda";
                    else return $"{Size} Dino Dew Plilosoda";
                }
                else if(Size == ServingSize.Medium)
                {
                    if (Flavor == SodaFlavor.Cola) return $"{Size} Cola Plilosoda";
                    else if (Flavor == SodaFlavor.CherryCola) return $"{Size} Cherry Cola Plilosoda";
                    else if (Flavor == SodaFlavor.DoctorDino) return $"{Size} Doctor Dino Plilosoda";
                    else if (Flavor == SodaFlavor.LemonLime) return $"{Size} Lemon-Lime Plilosoda";
                    else return $"{Size} Dino Dew Plilosoda";
                }
                else
                {
                    if(Flavor == SodaFlavor.Cola) return $"{Size} Cola Plilosoda";
                    else if (Flavor == SodaFlavor.CherryCola) return $"{Size} Cherry Cola Plilosoda";
                    else if (Flavor == SodaFlavor.DoctorDino) return $"{Size} Doctor Dino Plilosoda";
                    else if (Flavor == SodaFlavor.LemonLime) return $"{Size} Lemon-Lime Plilosoda";
                    else return $"{Size} Dino Dew Plilosoda";
                }
            } 
        }

        /// <summary>
        /// Backing field for Flavor
        /// </summary>
        private SodaFlavor _sodaFlavor = SodaFlavor.Cola;
        /// <summary>
        /// Flavor of soda
        /// </summary>
        public SodaFlavor Flavor 
        {
            get => _sodaFlavor;

            set
            {
                _sodaFlavor = value;
                OnPropertyChanged(nameof(this.Calories));
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
                    return 1.00m;
                }
                else if (Size == ServingSize.Medium)
                {
                    return 1.75m;
                }
                else
                {
                    return 2.50m;
                }
            } 
        }

        /// <summary>
        /// The calories of the Entree
        /// </summary>
        public override uint Calories 
        {
            get
            {
                if (Size == ServingSize.Small)
                {
                    if (Flavor == SodaFlavor.Cola) return 180;
                    else if (Flavor == SodaFlavor.CherryCola) return 100;
                    else if (Flavor == SodaFlavor.DoctorDino) return 120;
                    else if (Flavor == SodaFlavor.LemonLime) return 41;
                    else return 141;
                }
                else if (Size == ServingSize.Medium)
                {
                    if (Flavor == SodaFlavor.Cola) return 288;
                    else if (Flavor == SodaFlavor.CherryCola) return 160;
                    else if (Flavor == SodaFlavor.DoctorDino) return 192;
                    else if (Flavor == SodaFlavor.LemonLime) return 66;
                    else return 256;
                }
                else
                {
                    if (Flavor == SodaFlavor.Cola) return 432;
                    else if (Flavor == SodaFlavor.CherryCola) return 240;
                    else if (Flavor == SodaFlavor.DoctorDino) return 288;
                    else if (Flavor == SodaFlavor.LemonLime) return 98;
                    else return 338;
                }
            } 
        }

        public override List<string> SpecialInstructions { get; }
    }
}
