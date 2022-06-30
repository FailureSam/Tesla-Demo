using System;
using System.Windows;
using System.Windows.Controls;

namespace Tesla_Demo.Views
{
    /// <summary>
    /// Interaction logic for Driving.xaml
    /// </summary>
    public partial class Driving : UserControl
    {
        public Driving()
        {
            InitializeComponent();
        }

        string NotSlowlol = "https://youtu.be/1fVnpEDEuWQ?t=349";
        string NotaTesla = "https://www.notateslaapp.com";
        string TractionDemo = "https://insideevs.com/news/380003/tesla-model-3-moose-test-video/";

        private void itsdeep_Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            itsdeep_Popup.Visibility = Visibility.Visible;
            itsdeep_Popup.IsHitTestVisible = true;
        }

        private void itsdeep_Continue_Button_Click(object sender, RoutedEventArgs e)
        {
            itsdeep_Popup.Visibility = Visibility.Hidden;
            itsdeep_Popup.IsHitTestVisible = false;
        }

        private void Tesla_Slow_Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(NotSlowlol);
            Nope_Popup.Visibility = Visibility.Visible;
            Nope_Popup.IsHitTestVisible = true;
        }

        private void Nope_Continue_Button_Click(object sender, RoutedEventArgs e)
        {
            Nope_Popup.Visibility = Visibility.Hidden;
            Nope_Popup.IsHitTestVisible = false;
        }
        private void NotATesla_Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(NotaTesla);
        }

        private void TractionDemo_Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(TractionDemo);
        }
    }
}
