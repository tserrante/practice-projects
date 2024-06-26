namespace AudioPlayground;

public class Program
{
    static void Main(string[] args)
    {
        AudioPlayer player = new AudioPlayer();

        // Load your audio data here (e.g., from a file)
        byte[] audioData = LoadAudioData("taunt.wav");

        player.Play(audioData);

        Console.WriteLine("Audio played successfully.");
        Console.ReadKey();
    }

    static byte[] LoadAudioData(string filePath)
    {
        // Implement audio data loading logic
        return System.IO.File.ReadAllBytes(filePath);
    }
}
