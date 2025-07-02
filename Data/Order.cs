using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data
{
    /// <summary>
    /// Class represetns order 
    /// </summary>
    /// <summary>
    /// Class that creates the group of all menu items into one order
    /// </summary>
    public class Order : ObservableCollection<MenuItem>, ICollection<MenuItem>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        /// <summary>
        /// The tax rate
        /// </summary>
        public decimal SalesTaxRate { get; set; } = .09m;

        /// <summary>
        /// Cost of items before tax
        /// </summary>
        public decimal SubTotal
        {
            get
            {
                decimal price = 0;
                foreach (MenuItem item in this)
                {
                    price += item.Price;
                }
                return price;
            }
        }

        /// <summary>
        /// Cost due to tax
        /// </summary>
        public decimal Tax
        {
            get
            {
                return SubTotal * SalesTaxRate;
            }
        }
        /// <summary>
        /// The total cost of the order
        /// </summary>
        public decimal Total
        {
            get
            {
                return SubTotal + Tax;
            }
        }

        /// <summary>
        /// Overall calories of the order
        /// </summary>
        public uint Calories
        {
            get
            {
                uint numCals = 0;
                foreach (MenuItem item in this)
                {
                    numCals += item.Calories;
                }
                return numCals;
            }
        }

        /// <summary>
        /// Order number
        /// </summary>
        public int Number { get; }

        /// <summary>
        /// background number that will be used for order number
        /// </summary>
        private static int _number = 1;

        /// <summary>
        /// What time the order was placed at
        /// </summary>
        public DateTime PlacedAt { get; } = DateTime.Now;

        /// <summary>
        /// Constructor for the order
        /// </summary>
        public Order()
        {
            Number = _number;
            _number++;
            CollectionChanged += CollectionChangedListener;

        }

        /// <summary>
        /// Listener that checks to see if collection changed
        /// </summary>
        /// <param name="sender">The collection that is changing</param>
        /// <param name="e">describes the collection change</param>
        private void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(SubTotal)));
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(Tax)));
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(Total)));
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(Calories)));
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (MenuItem item in e.NewItems)
                {
                    CollectionChanged += CollectionChangedListener;
                    item.PropertyChanged += ItemChangedListener;
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach (MenuItem item in e.OldItems)
                {
                    CollectionChanged += CollectionChangedListener;
                    item.PropertyChanged += ItemChangedListener;
                }
            }
        }

        /// <summary>
        /// Checks if item changed
        /// </summary>
        /// <param name="sender">The object that changed</param>
        /// <param name="e">Details about the change</param>
        private void ItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(SubTotal)));
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(Tax)));
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(Total)));
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(Calories)));

        }

    }
}
