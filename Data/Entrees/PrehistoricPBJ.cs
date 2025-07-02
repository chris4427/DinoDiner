using System.ComponentModel;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A class representing a Prehistoric PBJ sandwich
    /// </summary>
    public class PrehistoricPBJ : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Name of item
        /// </summary>
        public override string Name { get { return "Prehistoric PBJ"; } }

        /// <summary>
        /// Backing field for PeanutButter
        /// </summary>
        private bool _peanutButter = true;
        /// <summary>
        /// Indicates if the PBJ was made with peanut butter
        /// </summary>
        public bool PeanutButter 
        {
            get => _peanutButter;

            set
            {
                _peanutButter = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            } 
        }

        /// <summary>
        /// Backing field for Jelly
        /// </summary>
        private bool _jelly = true;
        /// <summary>
        /// Indicates the PBJ was made with jelly
        /// </summary>
        public bool Jelly 
        {
            get => _jelly;

            set
            {
                _jelly = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            } 
        }

        private bool _toasted = true;
        /// <summary>
        /// Indicates the PBJ is served toasted
        /// </summary>
        public bool Toasted 
        {
            get => _toasted;
            set
            {
                _toasted = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// The price of the PBJ
        /// </summary>
        public override decimal Price { get; } = 3.75m;

        /// <summary>
        /// The calories of the PBJ
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint calories = 148;
                if (PeanutButter) calories += 188;
                if (Jelly) calories += 62;
                return calories;
            }
        }

        public override List<string> SpecialInstructions
        {

            get
            {
                List<string> si = new();
                if (!PeanutButter) si.Add("No Peanut Butter");
                if (!Jelly) si.Add("No Jelly");
                if (!Toasted) si.Add("Not Toasted");
                return si;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}