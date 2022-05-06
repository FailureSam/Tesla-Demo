using Tesla_Demo.Commands;
using System;
using Tesla_Demo.ViewModels;
using System.Windows.Input;

namespace Tesla_Demo.ViewModels
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand LoginViewCommand { get; set; }
        public RelayCommand QuickControlsViewCommand { get; set; }
        public RelayCommand LightsViewCommand { get; set; }
        public RelayCommand SafetyViewCommand { get; set; }
        public RelayCommand DisplayViewCommand { get; set; }


        public LoginViewModel LoginVM { get; set; }
        public QuickControlsViewModel QuickControlsVM { get; set; }
        public LightsViewModel LightsVM { get; set; }
        public SafetyViewModel SafetyVM { get; set; }
        public DisplayViewModel DisplayVM { get; set; }

        private object _SelectedView;

        public object SelectedView
        {
            get { return _SelectedView; }
            set
            {
                _SelectedView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            

            LoginVM = new LoginViewModel();
            QuickControlsVM = new QuickControlsViewModel();
            LightsVM = new LightsViewModel();
            SafetyVM = new SafetyViewModel();
            DisplayVM = new DisplayViewModel();

            LoginViewCommand = new RelayCommand(o =>
            {
                SelectedView = LoginVM;
            });

            QuickControlsViewCommand = new RelayCommand(o =>
            {
                SelectedView = QuickControlsVM;
            });

            LightsViewCommand = new RelayCommand(o =>
            {
                SelectedView = LightsVM;
            });

            SafetyViewCommand = new RelayCommand(o =>
            {
                SelectedView = SafetyVM;
            });

           DisplayViewCommand = new RelayCommand(o =>
            {
                SelectedView = DisplayVM;
            });

            SelectedView = LoginVM;
        }
    }
}