using RandomNumberGenerator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using RandomNumberGenerator.Commands;

namespace RandomNumberGenerator.ViewModels;

public class MainWindowViewModel
{
    private RandomData data = new RandomData();
    public string Data 
    {
        get => data.Data;
    }
    private ICommand newDataCommand = null;
    public List<RandomData> History = new List<RandomData>();
    public ICommand NewDataCommand => newDataCommand ??= new NewDataCommand();
    public MainWindowViewModel() { }
}
