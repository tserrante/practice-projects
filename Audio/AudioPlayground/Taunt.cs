using System.Media;
using System.ComponentModel;

namespace AudioPlayground;

public static class Taunt
{
    public static void PlayTauntingFrenchman()
    {
        SoundPlayer soundPlayer = new SoundPlayer("./taunt.wav");
        Console.WriteLine("Now go away or I shall taunt you a second time!");
        soundPlayer.Play();
    }
}