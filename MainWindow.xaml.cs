using Tesla_Demo.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using Tesla_Demo.Commands;
using System.Collections.ObjectModel;

namespace Tesla_Demo
{
    public partial class MainWindow : Window
    {
        public interface IPageViewModel
        {

        }

        
        public MainWindow()
        {
            InitializeComponent();
            System.Windows.Threading.DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();

            DataContext = new MainViewModel();
        }

        private void GetBatteryPercent()
        {
            System.Management.ManagementClass wmi = new System.Management.ManagementClass("Win32_Battery");
            var allBatteries = wmi.GetInstances();

            foreach (var battery in allBatteries)
            {
                int estimatedChargeRemaining = Convert.ToInt32(battery["EstimatedChargeRemaining"]);

                double batteryProgress = Convert.ToDouble(battery["EstimatedChargeRemaining"]);

                BatteryPercent_Text.Text = estimatedChargeRemaining.ToString() + "%";

                BatteryProgress.Value = batteryProgress;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            GetBatteryPercent();
        }
        public void ChangeTheme(string ThemeName)
        {
            ResourceDictionary dict = new ResourceDictionary();
            dict.Source = new Uri("..\\Styles\\" + ThemeName + ".xaml", UriKind.Relative);
            App.Current.Resources.MergedDictionaries.Add(dict);
        }

        private void Theme_Control_Checked(object sender, RoutedEventArgs e)
        {
            ChangeTheme("Dark");
            UpdateLayout();
        }

        private void Theme_Control_Unchecked(object sender, RoutedEventArgs e)
        {
            ChangeTheme("Light");
            UpdateLayout();
        }
        private void TopLeft_Panel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            TeslaWindow.Close();
        }

        private void Exit_Button_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Theme_Control.IsChecked == true)
            {
                Exit.Fill = new SolidColorBrush(Color.FromArgb(127, 30, 144, 255));
                Exit.Stroke = new SolidColorBrush(Color.FromArgb(127, 30, 144, 255));
            }
            else if (Theme_Control.IsChecked == false)
            {
                Exit.Fill = new SolidColorBrush(Color.FromArgb(127, 30, 144, 255));
                Exit.Stroke = new SolidColorBrush(Color.FromArgb(127, 30, 144, 255));
            }
        }

        private void Exit_Button_MouseLeave(object sender, MouseEventArgs e)
        {
            if (Theme_Control.IsChecked == true)
            {
                Exit.Fill = new SolidColorBrush(Color.FromArgb(127, 163, 163, 163));
                Exit.Stroke = new SolidColorBrush(Color.FromArgb(127, 163, 163, 163));
            }
            else if (Theme_Control.IsChecked == false)
            {
                Exit.Fill = new SolidColorBrush(Color.FromArgb(127, 155, 155, 155));
                Exit.Stroke = new SolidColorBrush(Color.FromArgb(127, 155, 155, 155));
            }
        }

        private void TeslaWindow_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void InfoBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Tips_Button_Click(object sender, RoutedEventArgs e)
        {
            Tip_PopUp.Visibility = Visibility.Visible;
            Tip_PopUp.IsHitTestVisible = true;
        }

        private void Tip_Close_Button_Click(object sender, RoutedEventArgs e)
        {
            Tip_PopUp.Visibility = Visibility.Hidden;
            Tip_PopUp.IsHitTestVisible = false;
        }

        private void TeslaWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }
    }
}