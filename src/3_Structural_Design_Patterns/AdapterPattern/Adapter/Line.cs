namespace Adapter;

public class Line
{
    public Point Start, End;

    public Line(Point start, Point end)
    {
        ArgumentNullException.ThrowIfNull(start, nameof(start));
        ArgumentNullException.ThrowIfNull(end, nameof(end));

        Start = start;
        End = end;
    }
}