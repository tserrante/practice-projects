using Reservroom.Exceptions;
using Reservroom.Models;
using Reservroom.ViewModels;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Reservroom
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly Hotel hotel;
        public App()
        {
            hotel = new Hotel("Hotel California");
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(hotel)
            };
            MainWindow.Show();


            base.OnStartup(e);
        }
    }

}
