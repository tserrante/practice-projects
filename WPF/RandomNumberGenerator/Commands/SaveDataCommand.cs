using RandomNumberGenerator.Models;
using RandomNumberGenerator.ViewModels;
using System.Windows.Input;

namespace RandomNumberGenerator.Commands;

public class SaveDataCommand : CommandBase
{
    private readonly MainWindowViewModel mainWindowViewModel;
    public SaveDataCommand(MainWindowViewModel mainWindowViewModel)
    {
        this.mainWindowViewModel = mainWindowViewModel;
    }
    public override void Execute(object? parameter)
    {
        mainWindowViewModel.AddToHistory(mainWindowViewModel.Data);
    }
}