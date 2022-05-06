using Tesla_Demo.Commands;
using System;
using System.ComponentModel;

namespace Tesla_Demo.ViewModels
{
    class QuickControlsViewModel : ObservableObject, INotifyPropertyChanged
    {
        /*protected void OnPropertyChanged(string isChecked)
        {
            var temp = PropertyChanged;
            if (temp != null)
                temp(this, new PropertyChangedEventArgs(isChecked));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private System.Windows.Media.Brush _backgroundColor = System.Windows.Media.Brushes.DodgerBlue;

        public System.Windows.Media.Brush BackgroundColor
        {
            get { return _backgroundColor; }
            set
            {
                _backgroundColor = value;
                OnPropertyChanged("BackgroundColor");
            }
        } */
    }
}