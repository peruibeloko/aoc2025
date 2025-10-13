namespace Aoc2025;

class Program
{
    public static void Main(string[] args)
    {
        var parseResult = ParseArgs(args);
        if (parseResult is null)
        {
            Console.WriteLine("Usage: aoc2025 <day> <part> <input file name>");
            Environment.Exit(1);
        }

        var (day, part, inputFile) = parseResult.Value;
        var input = Utils.ReadFile(day, inputFile);

        Console.WriteLine($"{Utils.BoxedText("Advent Of Code 2025")}\n");

        Console.Write("Running solution for day ");
        Utils.ColoredWrite($"{day}", ConsoleColor.Yellow);
        Console.Write(", part ");
        Utils.ColoredWrite($"{part}", ConsoleColor.Yellow);
        Console.Write(", using input file ");
        Utils.ColoredWriteLine($"{inputFile}.txt", ConsoleColor.Yellow);

        Console.Write("Result is ");
        Utils.ColoredWrite($"{RunSolution(day, part, input)}", ConsoleColor.Yellow);
    }

    private static string RunSolution(int day, int part, string input)
    {
        return day switch
        {
            1 => part == 1 ? Day1.Part1.Solution(input) : Day1.Part2.Solution(input),
            2 => part == 1 ? Day2.Part1.Solution(input) : Day2.Part2.Solution(input),
            3 => part == 1 ? Day3.Part1.Solution(input) : Day3.Part2.Solution(input),
            4 => part == 1 ? Day4.Part1.Solution(input) : Day4.Part2.Solution(input),
            5 => part == 1 ? Day5.Part1.Solution(input) : Day5.Part2.Solution(input),
            6 => part == 1 ? Day6.Part1.Solution(input) : Day6.Part2.Solution(input),
            7 => part == 1 ? Day7.Part1.Solution(input) : Day7.Part2.Solution(input),
            8 => part == 1 ? Day8.Part1.Solution(input) : Day8.Part2.Solution(input),
            9 => part == 1 ? Day9.Part1.Solution(input) : Day9.Part2.Solution(input),
            10 => part == 1 ? Day10.Part1.Solution(input) : Day10.Part2.Solution(input),
            11 => part == 1 ? Day11.Part1.Solution(input) : Day11.Part2.Solution(input),
            12 => part == 1 ? Day12.Part1.Solution(input) : Day12.Part2.Solution(input),
            13 => part == 1 ? Day13.Part1.Solution(input) : Day13.Part2.Solution(input),
            14 => part == 1 ? Day14.Part1.Solution(input) : Day14.Part2.Solution(input),
            15 => part == 1 ? Day15.Part1.Solution(input) : Day15.Part2.Solution(input),
            16 => part == 1 ? Day16.Part1.Solution(input) : Day16.Part2.Solution(input),
            17 => part == 1 ? Day17.Part1.Solution(input) : Day17.Part2.Solution(input),
            18 => part == 1 ? Day18.Part1.Solution(input) : Day18.Part2.Solution(input),
            19 => part == 1 ? Day19.Part1.Solution(input) : Day19.Part2.Solution(input),
            20 => part == 1 ? Day20.Part1.Solution(input) : Day20.Part2.Solution(input),
            21 => part == 1 ? Day21.Part1.Solution(input) : Day21.Part2.Solution(input),
            22 => part == 1 ? Day22.Part1.Solution(input) : Day22.Part2.Solution(input),
            23 => part == 1 ? Day23.Part1.Solution(input) : Day23.Part2.Solution(input),
            24 => part == 1 ? Day24.Part1.Solution(input) : Day24.Part2.Solution(input),
            25 => part == 1 ? Day25.Part1.Solution(input) : Day25.Part2.Solution(input),
            _ => "Not implemented"
        };
    }

    private static (int, int, string)? ParseArgs(string[] args)
    {
        if (args.Length != 3) return null;

        try
        {
            var day = int.Parse(args[0]);
            var part = int.Parse(args[1]);
            var inputFile = args[2];

            return (day, part, inputFile);
        }
        catch (Exception)
        {
            return null;
        }
    }
}