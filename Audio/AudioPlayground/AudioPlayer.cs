using System;
using System.Runtime.InteropServices;
namespace AudioPlayground;
public class AudioPlayer
{
    // Import the necessary functions from winmm.dll
    [DllImport("winmm.dll")]
    private static extern int waveOutOpen(out IntPtr hWaveOut, uint uDeviceID, WaveFormat lpFormat, WaveOutProc dwCallback, IntPtr dwInstance, uint dwFlags);

    [DllImport("winmm.dll")]
    private static extern int waveOutWrite(IntPtr hWaveOut, ref WaveHeader pwh, uint cbwh);

    [DllImport("winmm.dll")]
    private static extern int waveOutPrepareHeader(IntPtr hWaveOut, ref WaveHeader pwh, uint cbwh);

    [DllImport("winmm.dll")]
    private static extern int waveOutUnprepareHeader(IntPtr hWaveOut, ref WaveHeader pwh, uint cbwh);

    [DllImport("winmm.dll")]
    private static extern int waveOutClose(IntPtr hWaveOut);

    // Define WaveFormat structure
    [StructLayout(LayoutKind.Sequential)]
    private struct WaveFormat
    {
        public ushort wFormatTag;
        public ushort nChannels;
        public uint nSamplesPerSec;
        public uint nAvgBytesPerSec;
        public ushort nBlockAlign;
        public ushort wBitsPerSample;
        public ushort cbSize;
    }

    // Define WaveHeader structure
    [StructLayout(LayoutKind.Sequential)]
    private struct WaveHeader
    {
        public IntPtr lpData;
        public uint dwBufferLength;
        public uint dwBytesRecorded;
        public IntPtr dwUser;
        public uint dwFlags;
        public uint dwLoops;
        public IntPtr lpNext;
        public IntPtr reserved;
    }

    // Define callback delegate
    private delegate void WaveOutProc(IntPtr hWaveOut, uint uMsg, IntPtr dwInstance, IntPtr dwParam1, IntPtr dwParam2);

    private IntPtr hWaveOut;
    private WaveFormat waveFormat;

    public AudioPlayer()
    {
        // Initialize wave format
        waveFormat = new WaveFormat
        {
            wFormatTag = 1, // WAVE_FORMAT_PCM
            nChannels = 2,
            nSamplesPerSec = 44100,
            nAvgBytesPerSec = 44100 * 2 * 16 / 8,
            nBlockAlign = (ushort)(2 * 16 / 8),
            wBitsPerSample = 16,
            cbSize = 0
        };
    }

    public void Play(byte[] audioData)
    {
        if (waveOutOpen(out hWaveOut, 0, waveFormat, null, IntPtr.Zero, 0) != 0)
        {
            throw new Exception("Failed to open wave out.");
        }

        GCHandle hAudioData = GCHandle.Alloc(audioData, GCHandleType.Pinned);

        WaveHeader header = new WaveHeader
        {
            lpData = hAudioData.AddrOfPinnedObject(),
            dwBufferLength = (uint)audioData.Length,
            dwFlags = 0,
            dwLoops = 0
        };

        if (waveOutPrepareHeader(hWaveOut, ref header, (uint)Marshal.SizeOf(header)) != 0)
        {
            throw new Exception("Failed to prepare wave header.");
        }

        if (waveOutWrite(hWaveOut, ref header, (uint)Marshal.SizeOf(header)) != 0)
        {
            throw new Exception("Failed to write wave data.");
        }

        // Clean up
        waveOutUnprepareHeader(hWaveOut, ref header, (uint)Marshal.SizeOf(header));
        waveOutClose(hWaveOut);
        hAudioData.Free();
    }
}
