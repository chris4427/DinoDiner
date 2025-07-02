using DinoDiner.Data;
using DinoDiner.Data.Drinks;
using DinoDiner.Data.Entrees;
using DinoDiner.Data.Sides;
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
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// listener for edit/remove button click
        /// </summary>
        /// <param name="sender">object that is sending event</param>
        /// <param name="e">description of event</param>
        private void EditRemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is Button b && this.DataContext is Order order)
            {
                if (b.Name == "removeButton")
                {
                    order.Remove((DinoDiner.Data.MenuItem)b.DataContext);
                }
                else if (b.Name == "editButton")
                {
                    if (b.DataContext is Brontowurst bw)
                    {
                        ((MainWindow)Application.Current.MainWindow).borderMenuItemSelection.Child = new BrontowurstControl(bw);
                    }
                    else if (b.DataContext is AllosaurusAll_AmericanBurger aab)
                    {
                        ((MainWindow)Application.Current.MainWindow).borderMenuItemSelection.Child = new BurgerControl(aab);
                    }
                    else if (b.DataContext is CarnotaurusCheeseburger cc)
                    {
                        ((MainWindow)Application.Current.MainWindow).borderMenuItemSelection.Child = new BurgerControl(cc);
                    }
                    else if (b.DataContext is DeinonychusDouble dd)
                    {
                        ((MainWindow)Application.Current.MainWindow).borderMenuItemSelection.Child = new BurgerControl(dd);
                    }
                    else if (b.DataContext is TRexTriple tt)
                    {
                        ((MainWindow)Application.Current.MainWindow).borderMenuItemSelection.Child = new BurgerControl(tt);
                    }
                    else if (b.DataContext is DinoNuggets dn)
                    {
                        ((MainWindow)Application.Current.MainWindow).borderMenuItemSelection.Child = new DinoNuggetsControl(dn);
                    }
                    else if (b.DataContext is PrehistoricPBJ pbj)
                    {
                        ((MainWindow)Application.Current.MainWindow).borderMenuItemSelection.Child = new PrehistoricPBJControl(pbj);
                    }
                    else if (b.DataContext is PterodactylWings pw)
                    {
                        ((MainWindow)Application.Current.MainWindow).borderMenuItemSelection.Child = new PterodactylWingsControl(pw);
                    }
                    else if (b.DataContext is VelociWraptor vw)
                    {
                        ((MainWindow)Application.Current.MainWindow).borderMenuItemSelection.Child = new VelociWraptorControl(vw);
                    }
                    else if (b.DataContext is Fryceritops fry)
                    {
                        ((MainWindow)Application.Current.MainWindow).borderMenuItemSelection.Child = new FryceritopsControl(fry);
                    }
                    else if (b.DataContext is MeteorMacAndCheese mac)
                    {
                        ((MainWindow)Application.Current.MainWindow).borderMenuItemSelection.Child = new MeteorMacAndCheeseControl(mac);
                    }
                    else if (b.DataContext is MezzorellaSticks ms)
                    {
                        ((MainWindow)Application.Current.MainWindow).borderMenuItemSelection.Child = new MezzorellaSticksControl(ms);
                    }
                    else if (b.DataContext is Triceritots tots)
                    {
                        ((MainWindow)Application.Current.MainWindow).borderMenuItemSelection.Child = new TriceritotsControl(tots);
                    }
                    else if (b.DataContext is CretaceousCoffee ccoffee)
                    {
                        ((MainWindow)Application.Current.MainWindow).borderMenuItemSelection.Child = new CretaceousCoffeeControl(ccoffee);
                    }
                    else if (b.DataContext is Plilosoda ps)
                    {
                        ((MainWindow)Application.Current.MainWindow).borderMenuItemSelection.Child = new PlilsodaControl(ps);
                    }

                    ((MainWindow)Application.Current.MainWindow).selectMoreItems.IsEnabled = true;
                }
            }
        }
    }
}
