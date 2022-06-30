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

namespace Tesla_Demo.Views
{
    /// <summary>
    /// Interaction logic for Safety.xaml
    /// </summary>
    public partial class Safety : UserControl
    {
        public Safety()
        {
            InitializeComponent();
        }

        string SafetyDemo = "https://www.youtube.com/watch?v=9KR2N_Q8ep8";
        string MoreSafety = "https://www.youtube.com/watch?v=il2jmMRgFV8";
        string SafetyData = "https://www.tesla.com/VehicleSafetyReport";
        string SafetyKillingSpree = "https://www.youtube.com/watch?v=-JObJucmz-c";
        private void SafetyDemo_Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(SafetyDemo);
        }

        private void MoreSafety_Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(MoreSafety);
        }

        private void SafetyData_Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(SafetyData);
        }

        private void ProbablyWontClick_Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(SafetyKillingSpree);
        }
        private void Safelol_Button_Click(object sender, RoutedEventArgs e)
        {
            Safe_PopUp.Visibility = Visibility.Visible;
            Safe_PopUp.IsHitTestVisible = true;
        }
        private void Safe_Close_Button_Click(object sender, RoutedEventArgs e)
        {
            Safe_PopUp.Visibility = Visibility.Hidden;
            Safe_PopUp.IsHitTestVisible = false;
        }
        private void TeslaSafety_Button_Click(object sender, RoutedEventArgs e)
        {
            SafetyDemo_PopUp.Visibility = Visibility.Visible;
            SafetyDemo_PopUp.IsHitTestVisible = true;
        }

        private void SafetyDemoClear_PopUp_Button_Click(object sender, RoutedEventArgs e)
        {
            SafetyDemo_PopUp.Visibility = Visibility.Hidden;
            SafetyDemo_PopUp.IsHitTestVisible = false;
        }

        private void idc_Button_Click(object sender, RoutedEventArgs e)
        {
            idc_PopUp.Visibility = Visibility.Visible;
            idc_PopUp.IsHitTestVisible = true;
        }

        private void idc_Close_Button_Click(object sender, RoutedEventArgs e)
        {
            idc_PopUp.Visibility = Visibility.Hidden;
            idc_PopUp.IsHitTestVisible = false;
        }
        private void Stilldontcare_Button_Click(object sender, RoutedEventArgs e)
        {
            Funny_PopUp.Visibility = Visibility.Visible;
            Funny_PopUp.IsHitTestVisible = true;
        }
        private void Funny_Close_Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
