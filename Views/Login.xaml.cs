using System;
using System.Windows;
using System.Windows.Controls;

namespace Tesla_Demo.Views
{
    /// <summary>
    /// Interaction logic for LoginV2.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Email_Fillout_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        string TwitterLink = "https://Twitter.com/miohsam";
        string InstagramLink = "https://instagram.com/computesam";
        string FacebookLink = "https://www.facebook.com/sam.kinman.39";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(InstagramLink);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(FacebookLink);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(TwitterLink);
        }
    }
}
