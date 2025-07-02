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
using DinoDiner.Data.Drinks;
using DinoDiner.Data.Entrees;
using DinoDiner.Data.Sides;

namespace DinoDiner.PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        /// <summary>
        /// Current Main window
        /// </summary>
        private MainWindow _mw = (MainWindow)Application.Current.MainWindow;

        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// menu buttons click event
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void MenuButtons_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button b && this.DataContext is Order order)
            {

                if (b.Name == "allosaurusAll_American")
                {
                    AllosaurusAll_AmericanBurger aab = new AllosaurusAll_AmericanBurger();
                    _mw.borderMenuItemSelection.Child = new BurgerControl(aab);
                    order.Add(aab);
                }
                else if (b.Name == "carnotaurusCheeseburger")
                {
                    CarnotaurusCheeseburger ccb = new CarnotaurusCheeseburger();
                    _mw.borderMenuItemSelection.Child = new BurgerControl(ccb);
                    order.Add(ccb);
                }
                else if (b.Name == "deinonychusDouble")
                {
                    DeinonychusDouble dd = new DeinonychusDouble();
                    _mw.borderMenuItemSelection.Child = new BurgerControl(dd);
                    order.Add(dd);
                }
                else if (b.Name == "t_rexTriple")
                {
                    TRexTriple trt = new TRexTriple();
                    _mw.borderMenuItemSelection.Child = new BurgerControl(trt);
                    order.Add(trt);
                }
                else if (b.Name == "brontowurst")
                {
                    Brontowurst bw = new Brontowurst();
                    _mw.borderMenuItemSelection.Child = new BrontowurstControl(bw);
                    order.Add(bw);
                }
                else if (b.Name == "dinoNuggets")
                {
                    DinoNuggets dn = new DinoNuggets();
                    _mw.borderMenuItemSelection.Child = new DinoNuggetsControl(dn);
                    order.Add(dn);
                }
                else if (b.Name == "prehistoricPBJ")
                {
                    PrehistoricPBJ pbj = new();
                    _mw.borderMenuItemSelection.Child = new PrehistoricPBJControl(pbj);
                    order.Add(pbj);
                }
                else if (b.Name == "velociWraptor")
                {
                    VelociWraptor vw = new();
                    _mw.borderMenuItemSelection.Child = new VelociWraptorControl(vw);
                    order.Add(vw);
                }
                else if (b.Name == "pterodactylWings")
                {
                    PterodactylWings pw = new();
                    _mw.borderMenuItemSelection.Child = new PterodactylWingsControl(pw);
                    order.Add(pw);
                }
                else if (b.Name == "fryceritops")
                {
                    Fryceritops fr = new Fryceritops();
                    _mw.borderMenuItemSelection.Child = new FryceritopsControl(fr);
                    order.Add(fr);
                }
                else if (b.Name == "meteorMacAndCheese")
                {
                    MeteorMacAndCheese mac = new();
                    _mw.borderMenuItemSelection.Child = new MeteorMacAndCheeseControl(mac);
                    order.Add(mac);
                }
                else if (b.Name == "mezzorellaSticks")
                {
                    MezzorellaSticks ms = new();
                    _mw.borderMenuItemSelection.Child = new MezzorellaSticksControl(ms);
                    order.Add(ms);
                }
                else if (b.Name == "triceritots")
                {
                    Triceritots tt = new();
                    _mw.borderMenuItemSelection.Child = new TriceritotsControl(tt);
                    order.Add(tt);
                }
                else if (b.Name == "plilosoda")
                {
                    Plilosoda ps = new();
                    _mw.borderMenuItemSelection.Child = new PlilsodaControl(ps);
                    order.Add(ps);
                }
                else if (b.Name == "cretaceousCoffee")
                {
                    CretaceousCoffee cc = new CretaceousCoffee();
                    _mw.borderMenuItemSelection.Child = new CretaceousCoffeeControl(cc);
                    order.Add(cc);
                }
            }
        }
    }
}
