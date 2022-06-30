using System;
using System.Windows;
using System.Windows.Controls;

namespace Tesla_Demo.Views
{
    /// <summary>
    /// Interaction logic for Lights.xaml
    /// </summary>
    public partial class Lights : UserControl
    {

        public Lights()
        {
            InitializeComponent();
        }

        private void LearnMore_Button_Click(object sender, RoutedEventArgs e)
        {
            Understand_Popup.Visibility = Visibility.Hidden;
            Understand_Popup.IsHitTestVisible = false;
        }

        private void Understand_Button_Click(object sender, RoutedEventArgs e)
        {
            Understand_Popup.Visibility = Visibility.Visible;
            Understand_Popup.IsHitTestVisible = true;
        }

        private void Confused_Button_Click(object sender, RoutedEventArgs e)
        {
            Unclear_Popup.Visibility = Visibility.Visible;
            Unclear_Popup.IsHitTestVisible = true;
        }

        private void UnClearPopUp_Button_Click(object sender, RoutedEventArgs e)
        {
            Unclear_Popup.Visibility = Visibility.Hidden;
            Unclear_Popup.IsHitTestVisible = false;
        }

        string VoxelNet = "https://www.youtube.com/watch?v=kHBsUThTbOk";
        string NeuralNet = "https://twitter.com/karpathy/status/1465796331247575042";
        string FSDHardware = "https://www.teslarati.com/tesla-parallel-processing-system-runtime-state-reload-patent/";
        string FSDSoftware = "https://www.youtube.com/watch?v=qmgmYyfufGk";
        string DeepUnderstanding_Part1 = "https://saneryee-studio.medium.com/deep-understanding-tesla-fsd-part-1-hydranet-1b46106d57";
        string DeepUnderstanding_Part2 = "https://saneryee-studio.medium.com/deep-understanding-tesla-fsd-part-2-vector-space-2964bfc10b17";
        string DeepUnderstanding_Part3 = "https://saneryee-studio.medium.com/deep-understanding-tesla-fsd-part-3-planning-control-9a25cc6d04f0";
        string DeepUnderstanding_Part4 = "https://saneryee-studio.medium.com/deep-understanding-tesla-fsd-part-4-auto-labeling-simulation-60c9bfd3bcb5";


        private void VoxelNetBox_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(VoxelNet);
        }
        private void NeuralNetBox_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(NeuralNet);
        }
        private void FSDHardware_Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(FSDHardware);
        }
        private void FSDSoftware_Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(FSDSoftware);
        }

        private void DeepUnderstanding_Button_Click(object sender, RoutedEventArgs e)
        {
            AIDay_PopUp.Visibility = Visibility.Visible;
            AIDay_PopUp.IsHitTestVisible = true;
        }
        private void AIDay_Back_Button_Click(object sender, RoutedEventArgs e)
        {
            AIDay_PopUp.Visibility = Visibility.Hidden;
            AIDay_PopUp.IsHitTestVisible = false;
        }

        private void AIDay_Part1_Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(DeepUnderstanding_Part1);
        }

        private void AIDay_Part2_Button1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(DeepUnderstanding_Part2);
        }

        private void AIDay_Part3_Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(DeepUnderstanding_Part3);
        }

        private void AIDay_Part4_Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(DeepUnderstanding_Part4);
        }

        private void Tippp_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;

            mainWindow.Tip_PopUp.Visibility = Visibility.Visible;
            mainWindow.Tip_PopUp.IsHitTestVisible = true;
        }
    }
}
