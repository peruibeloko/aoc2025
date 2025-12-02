namespace Aoc2025.Day1;

class Part1
{
    public static string Solution(String input)
    {
        int position = 50;
        int password = 0;

        foreach (var line in input.Split("\n"))
        {
            var direction = line[0] == 'R' ? 1 : -1;
            var distance = int.Parse(line.Substring(1));

            position = Move(position, direction, distance);

            if (position == 0) password++;
        }

        return password.ToString();
    }

    static int Move(int position, int direction, int distance)
    {
        var newPos = (position + distance * direction) % 100;
        return newPos < 0 ? 100 + newPos : newPos;
    }
}