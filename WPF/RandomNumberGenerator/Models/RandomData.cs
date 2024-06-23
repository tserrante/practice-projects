using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator.Models;

public class RandomData
{
    private string data = string.Empty;
    public string Data
    {
        get => data;
        set => data = value;
    }
    public RandomData() { }

    public void GetRandomData()
    {
        
    }
}
