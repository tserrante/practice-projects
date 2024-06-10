using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator.Models;

public class RandomData : INotifyPropertyChanged
{
    private string data = string.Empty;
    public string Data
    {
        get => data;
        set
        {
            data = value;
            OnPropertyChanged(nameof(Data));
        }
    }
    public RandomData() { }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public void GetRandomData()
    {
        Data = Convert.ToString(new Random().Next(0, 10000));
    }
}
