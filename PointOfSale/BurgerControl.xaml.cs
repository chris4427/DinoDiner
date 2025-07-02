using DinoDiner.Data.Entrees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DinoDiner.PointOfSale
{
    /// <summary>
    /// Interaction logic for BurgerControl.xaml
    /// </summary>
    public partial class BurgerControl : UserControl
    {
        /// <summary>
        /// Private field for burger
        /// </summary>
        private Burger _burger;
        public BurgerControl(Burger burger)
        {
            InitializeComponent();
            this.DataContext = burger;
            _burger = burger;
        }

        /// <summary>
        /// button click event to add number of patties
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">info about event</param>
        private void AddPatty_Click(object sender, RoutedEventArgs e)
        {
            _burger.Patties++;
        }

        /// <summary>
        /// Button click event to subtract number of patties
        /// </summary>
        /// <param name="sender">button that sent the event</param>
        /// <param name="e">info about the event</param>
        private void SubtractPatty_Click(object sender, RoutedEventArgs e)
        {
            if (_burger.Patties != 0) _burger.Patties--;
        }
    }
}
