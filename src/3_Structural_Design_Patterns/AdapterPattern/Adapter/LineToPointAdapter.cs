using System.Collections.ObjectModel;

namespace Adapter;

public class LineToPointAdapter : Collection<Point>
{
    private static int _count;

    public LineToPointAdapter(Line line)
    {
        ArgumentNullException.ThrowIfNull(line, nameof(line));

        Console.WriteLine($"{++_count}: Generating points for line [{line.Start.x},{line.Start.y}]-[{line.End.x},{line.End.y}]");

        int left = Min(line.Start.x, line.End.x);
        int right = Max(line.Start.x, line.End.x);
        int top = Min(line.Start.y, line.End.y);
        int bottom = Max(line.Start.y, line.End.y);
        int dx = right - left;
        int dy = line.End.y - line.Start.y;

        if (dx == 0)
        {
            for (int y = top; y <= bottom; ++y)
            {
                Add(new Point(left, y));
            }
        }
        else if (dy == 0)
        {
            for (int x = left; x <= right; ++x)
            {
                Add(new Point(x, top));
            }
        }
    }

    private static int Min(int a, int b) => a <= b ? a : b;

    private static int Max(int a, int b) => a >= b ? a : b;
}