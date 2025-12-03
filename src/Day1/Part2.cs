namespace Aoc2025.Day1;

class Part2
{
    public static string Solution(String input)
    {
        int position = 50;
        int password = 0;

        foreach (var line in input.Split("\n"))
        {
            var direction = line[0] == 'R' ? 1 : -1;
            var distance = int.Parse(line.Substring(1));

            var (newPosition, passes) = Move(position, direction, distance);
            
            password += passes;
            position = newPosition;
        }

        return password.ToString();
    }

    static (int, int) Move(int startPos, int dir, int dist)
    {
        var newPos = startPos + dist * dir;
        var (passes, endPos) = Math.DivRem(newPos, 100);
        
        passes = Math.Abs(passes);
        
        if (endPos == 0 && startPos != 0) passes++;
        
        return (endPos < 0 ? endPos + 100 : endPos, passes);
    }
}