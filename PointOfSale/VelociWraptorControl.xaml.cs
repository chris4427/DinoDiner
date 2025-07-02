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
    /// Interaction logic for VelociWraptorControl.xaml
    /// </summary>
    public partial class VelociWraptorControl : UserControl
    {
        public VelociWraptorControl(VelociWraptor vw)
        {
            InitializeComponent();
            DataContext = vw;
        }
    }
}
