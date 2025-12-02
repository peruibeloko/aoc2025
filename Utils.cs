namespace Aoc2025;

public class Utils
{
    public static readonly string projectDirectory =
        Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

    public static string ReadFile(int day, string inputFile)
    {
        return File.ReadAllText(Path.Join([projectDirectory, "src", $"Day{day}", $"{inputFile}.txt"]));
    }

    public static string BoxedText(string text)
    {
        int size = text.Length;
        var parts = (TL: '╔', H: '═', TR: '╗', V: '║', BL: '╚', BR: '╝');
        return
            parts.TL + new string(parts.H, size + 2) + parts.TR + "\n" +
            parts.V + " " + text + " " + parts.V + "\n" +
            parts.BL + new string(parts.H, size + 2) + parts.BR;
    }

    public static void ColoredWrite(string text, ConsoleColor fg)
    {
        Console.ForegroundColor = fg;
        Console.Write(text);
        Console.ResetColor();
    }

    public static void ColoredWriteLine(string text, ConsoleColor fg)
    {
        ColoredWrite(text + "\n", fg);
    }
}