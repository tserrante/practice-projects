
using System.Runtime.InteropServices;

namespace ConsoleApplication;

public class Program
{

    [DllImport("MiniAudioWrapper.dll")]
    public static extern void Test();

    [DllImport("MiniAudioWrapper.dll", EntryPoint="data_callback")]
    public static extern void DataCallback(IntPtr pDevice, IntPtr pOutput, IntPtr pInput, UInt32 frameCount);
    public static void Main(string[] args)
    {
        DataCallback(IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, 32);
    }
}
