namespace Geometry;

public class Segment
{
    public Point Start { get; }
    public Point End { get; }


    public Segment (Point start, Point end)
    {
        Start = start; 
        End = end;
    }

    public override bool Equals(object? obj)
    {
        var item = obj as Segment;

        if (item == null)
        {
            return false;
        }

        return Start == item.Start && End == item.End;
    }
}
