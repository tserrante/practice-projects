using RandomNumberGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator.ViewModels;

public class RandomDataViewModel
{
    private readonly RandomData randomData;

    public string RandomData => randomData.Data;

    public RandomDataViewModel(RandomData randomData)
    {
        this.randomData = randomData;
    }
}
