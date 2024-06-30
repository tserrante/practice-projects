using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication;  

public struct MaDeviceConfig
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate void DataCallback(IntPtr device, IntPtr output, IntPtr input, uint frameCount);

    public MaDeviceType deviceType;
    public MaFormat format;
    public uint channels;
    public uint sampleRate;
    public DataCallback dataCallback;
    public IntPtr pUserData;
}
