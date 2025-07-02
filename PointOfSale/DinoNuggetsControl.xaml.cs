using DinoDiner.Data.Entrees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
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
    /// Interaction logic for DinoNuggetsControl.xaml
    /// </summary>
    public partial class DinoNuggetsControl : UserControl
    {
        /// <summary>
        /// private field for dino nugget
        /// </summary>
        private DinoNuggets _dn;
        public DinoNuggetsControl(DinoNuggets dinoNuggets)
        {
            InitializeComponent();
            this.DataContext = dinoNuggets;
            _dn = dinoNuggets;
        }

        /// <summary>
        /// Click event for adding nuggets
        /// </summary>
        /// <param name="sender">button sending click</param>
        /// <param name="e">info about click</param>
        private void AddNuggets_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button b)
            {
                if (b.Name == "addOneNugget") _dn.Count++;
                else if (b.Name == "addFiveNuggets") _dn.Count += 5;
                else if (b.Name == "addTenNuggets") _dn.Count += 10;
                else if (b.Name == "addTwentyNuggets") _dn.Count += 20;
            }
        }
    }
}
