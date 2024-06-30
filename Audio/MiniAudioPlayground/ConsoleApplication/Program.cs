
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace ConsoleApplication;

public class Program
{
    private const string dllLib = "MiniAudioWrapper.dll";

    [DllImport(dllLib)]
    public static extern void Test();
    [DllImport(dllLib/*, EntryPoint= "ma_decoder_read_pcm_frames"*/)]
    private static extern void ma_decoder_read_pcm_frames(IntPtr decoder, IntPtr framesOut, UInt64 frameCount, UInt64 frameRead);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate void DataCallback(IntPtr device, IntPtr output, IntPtr input, uint frameCount);
    private static void DataCallbackFunction(IntPtr device, IntPtr output, IntPtr input, uint frameCount)
    {
        if (device == IntPtr.Zero) return;

        //ma_decoder_read_pcm_frames(pDecoder, pOutput, frameCount, NULL);
        ma_decoder_read_pcm_frames(device, output, frameCount, 0);
    }

    private struct MaDevice
    {
        public IntPtr pUserData;
        // Other members as needed
    }

    private struct MaDeviceConfig
    {
        public MaDeviceType deviceType;
        public MaFormat format;
        public uint channels;
        public uint sampleRate;
        public DataCallback dataCallback;
        public IntPtr pUserData;
    }

    private enum MaDeviceType
    {
        Playback = 1,
    }

    private enum MaFormat
    {
        F32 = 2,
    }

    //[DllImport("MiniAudioWrapper.dll", EntryPoint="data_callback")]
    //public static extern void DataCallback(IntPtr pDevice, IntPtr pOutput, IntPtr pInput, UInt32 frameCount);
    public static void Main(string[] args)
    {
        DataCallbackFunction(IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, 0);  
    }
}
