using System;
using System.Windows;
using Tesla_Demo.Commands;
using System.Reflection;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;

namespace Tesla_Demo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Exit(object sender, ExitEventArgs e)
        {
            Tesla_Demo.Properties.Settings.Default.Save();
        }
    }

}
