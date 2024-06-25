using RandomNumberGenerator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using RandomNumberGenerator.Commands;
using System.Collections.ObjectModel;

namespace RandomNumberGenerator.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase CurrentViewModel { get; set; }

    private ObservableCollection<RandomDataViewModel> history;
    public IEnumerable<RandomDataViewModel> History => history;

    private string data = string.Empty;
    public string Data 
    {
        get => data;
    }
    private ICommand newDataCommand = null;
    public ICommand NewDataCommand => newDataCommand ??= new NewDataCommand();
    public MainWindowViewModel() 
    {
        CurrentViewModel = this;
        history = new ObservableCollection<RandomDataViewModel>()
        {
            new RandomDataViewModel(new RandomData()),
            new RandomDataViewModel(new RandomData()),
            new RandomDataViewModel(new RandomData())
        };
    }
}
