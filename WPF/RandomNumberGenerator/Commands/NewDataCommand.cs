﻿using RandomNumberGenerator.Models;
using RandomNumberGenerator.ViewModels;

namespace RandomNumberGenerator.Commands;

public class NewDataCommand : CommandBase
{
    private readonly MainWindowViewModel mainWindowViewModel;
    public NewDataCommand(MainWindowViewModel mainWindowViewModel)
    {
        this.mainWindowViewModel = mainWindowViewModel;
    }
    public override void Execute(object? parameter)
    {
        mainWindowViewModel.Data = new RandomData(); ;
    }
    
}
