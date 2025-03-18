namespace Geometry;

public struct Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public static bool operator == (Point a, Point b)
    {
        return a.Equals(b);
    }
    public static bool operator != (Point a, Point b)
    {
        return  !a.Equals(b);
    }


}