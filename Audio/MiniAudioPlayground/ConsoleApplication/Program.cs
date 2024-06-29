
using System.Runtime.InteropServices;

namespace ConsoleApplication;

public class Program
{
    [DllImport("MiniAudioWrapper.dll")]
    public static extern void Test();
    public static void Main(string[] args)
    {
        
    }
}