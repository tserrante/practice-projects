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

    private string data = "test";
    public string Data 
    {
        get => data;
        set
        {
            data = value;
            OnPropertyChanged(nameof(Data));
        }
    }
    private ICommand newDataCommand = null;
    public ICommand NewDataCommand => newDataCommand ??= new NewDataCommand();
    public MainWindowViewModel() 
    {
        CurrentViewModel = this;
        history = new ObservableCollection<RandomDataViewModel>()
        /*{
            new RandomDataViewModel(new RandomData()),
            new RandomDataViewModel(new RandomData()),
            new RandomDataViewModel(new RandomData())
        }*/;
    }
}
