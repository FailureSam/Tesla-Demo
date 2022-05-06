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
    /// Interaction logic for QuickControls.xaml
    /// </summary>
    public partial class QuickControls : UserControl
    {

        public QuickControls()
        {
            InitializeComponent();
        }

        protected bool _isDragging;
        Point _mouseLocationWithinMe;

        private void BrightnessSlider_Canvas_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            _isDragging = true;
            _mouseLocationWithinMe = e.GetPosition(this);

            CaptureMouse();
        }

        private void BrightnessSlider_Canvas_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            _isDragging = false;
            this.ReleaseMouseCapture();
        }

        private void BrightnessSlider_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (_isDragging)
            {
                var mouseWithinParent = e.GetPosition(Parent as UIElement);

                Canvas.SetLeft(this, mouseWithinParent.X - _mouseLocationWithinMe.X);
                Canvas.SetTop(this, mouseWithinParent.Y - _mouseLocationWithinMe.Y);
            }
        }

        private void SoundsGreat_Button_Click(object sender, RoutedEventArgs e)
        {
            Great_Popup.Visibility = Visibility.Visible;
            Great_Popup.IsHitTestVisible = true;
        }

        private void Stupid_Button_Click(object sender, RoutedEventArgs e)
        {
            Stupid_Popup.Visibility = Visibility.Visible;
            Stupid_Popup.IsHitTestVisible = true;
        }

        private void Stupid_Close_Button_Click(object sender, RoutedEventArgs e)
        {
            Stupid_Popup.Visibility = Visibility.Hidden;
            Stupid_Popup.IsHitTestVisible = false;
        }

        private void GreatPopUp_Close_Button_Click(object sender, RoutedEventArgs e)
        {
            Great_Popup.Visibility = Visibility.Hidden;
            Great_Popup.IsHitTestVisible = false;
        }
    }
}
