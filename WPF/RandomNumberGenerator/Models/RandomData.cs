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
    private readonly string data;
    public string Data { get => data; }
    public RandomData() 
    {
        data = new Random().Next(0, 101).ToString();
    }
    public RandomData(int a, int b)
    {
        data = new Random().Next(a, b).ToString();
    }
}
