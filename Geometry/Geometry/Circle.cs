using Geometry;

public class Circle
{
    public Point? Center { get; }
    public double Radius { get;}

    public Circle(double radius, Point center)
    {
        Radius = radius;
        Center = center;
    }

    public Circle(double radius)
    {
        Radius=radius;
    }

    public double Area => Math.PI * Math.Pow(Radius, 2);
      

    public bool? BelongsToCircle(Point point)
    {
        if (Center == null) return null;

        var center_x = Center.Value.X;
        var center_y = Center.Value.Y;

        var equestion = Math.Pow(point.X - center_x, 2) + Math.Pow(point.Y - center_y, 2);
        return equestion <= Math.Pow(Radius, 2);
    }
}