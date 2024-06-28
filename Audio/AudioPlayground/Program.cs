using System.Windows.Media;
using System.Media;
using System.ComponentModel;

namespace AudioPlayground;

public class Program
{
    static void Main(string[] args)
    {
        //SystemSounds.Beep.Play();
        //SystemSounds.Exclamation.Play();
        //SystemSounds.Question.Play();

        Taunt.PlayTauntingFrenchman();
        
        Console.Read();
    }
}
