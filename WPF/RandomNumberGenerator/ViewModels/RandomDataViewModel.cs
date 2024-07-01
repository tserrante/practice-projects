using RandomNumberGenerator.Models;

namespace RandomNumberGenerator.ViewModels;

public class RandomDataViewModel
{
    private readonly RandomData randomData;

    public RandomData RandomData => randomData;

    public RandomDataViewModel(RandomData randomData)
    {
        this.randomData = randomData;
    }
}
