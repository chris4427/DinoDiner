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
using DinoDiner.Data;

namespace DinoDiner.PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Field for storing menuitemselectioncontrol
        /// </summary>
        MenuItemSelectionControl menuItemSelection;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new Order();
            menuItemSelection = new MenuItemSelectionControl();
            borderMenuItemSelection.Child = new MenuItemSelectionControl();
        }

        /// <summary>
        /// event for when function button is clicked
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">info about event</param>
        private void FunctionButtons_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button B)
            {
                if (B.Name == "cancelOrder")
                {
                    this.DataContext = new Order();
                    borderMenuItemSelection.Child = menuItemSelection;
                }
                if (B.Name == "selectMoreItems")
                {
                    borderMenuItemSelection.Child = menuItemSelection;
                }
                /*else
                {
                    Boarder1.Child = paymentOptionsControl;
                }*/
            }
        }
    }
}
