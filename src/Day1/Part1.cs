namespace Aoc2025.Day1;

class Part1
{
    public static string Solution(String input)
    {
        Console.WriteLine("");
        int position = 50;
        int password = 0;
        
        foreach (var line in input.Split("\n"))
        {
            var direction = line[0] == 'R' ? 1 : -1;
            var distance = int.Parse(line.Substring(1));
            
            position = Move(position, direction, distance);
            Console.WriteLine($"position {position}");

            if (position == 0) password++;
        }

        return password.ToString();
    }

    static int Move(int position, int direction, int distance)
    {
        if (direction > 0) return (position + distance) % 100;

        var offset = (position - distance) % 100;

        if (offset < 0) return 100 + offset;
        
        return offset;
    }
}