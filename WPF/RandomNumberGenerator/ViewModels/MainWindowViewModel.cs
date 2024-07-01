using System.Windows.Input;
using System.Collections.ObjectModel;

using RandomNumberGenerator.Models;
using RandomNumberGenerator.Commands;

namespace RandomNumberGenerator.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ObservableCollection<RandomDataViewModel> history;
    public IEnumerable<RandomDataViewModel> History => history;
    private RandomData data;
    public RandomData Data 
    {
        get => data;
        set
        {
            data = value;
            OnPropertyChanged(nameof(Data));
        }
    }
    public void AddToHistory(RandomData dataToAdd)
    {

        bool canAdd = true;
        foreach(RandomDataViewModel randomDataViewModel in history)
        {
            if(randomDataViewModel.RandomData.Data.Equals(dataToAdd.Data))
            {
                canAdd = false;
            }
        }
        if(canAdd)
        {
            history.Add(new RandomDataViewModel(dataToAdd));
        }
    }
    public ICommand NewDataCommand { get; set; }
    public ICommand SaveDataCommand { get; set; }
    public MainWindowViewModel() 
    {
        NewDataCommand = new NewDataCommand(this);
        SaveDataCommand = new SaveDataCommand(this);
        history = new ObservableCollection<RandomDataViewModel>();
    }
}
