
using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;


using RandomNumberGenerator.ViewModels;

namespace RandomNumberGenerator;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindowViewModel ViewModel { get; set; } = new MainWindowViewModel();
    public MainWindow()
    {
        InitializeComponent(); 
    }
}