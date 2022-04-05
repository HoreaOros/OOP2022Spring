// See https://aka.ms/new-console-template for more information
using _03_22;
using _04_05;
using System.Text;
public class Rectangle : IEquatable<Rectangle>, IPolygon, ICloneable
{
    public Point TopLeft { get; set; }
    public uint Width { get; set; }
    public uint Height { get; set; }

    public Rectangle(Point topLeft, uint width, uint height)
    {
        TopLeft = new Point(topLeft.X, topLeft.Y);
        Width = width;
        Height = height;
    }

    public Rectangle() : this(new Point(0, 0), 0, 0) { }

    public uint ComputeArea() => Height * Width;

    public uint ComputePerimeter() => 2 * Height + 2 * Width;

    public override bool Equals(object? obj) => 
        Equals(obj as Rectangle);
    
    public Rectangle? Intersect(Rectangle other)
    {
        if (Equals(other))
            return Clone() as Rectangle;

        Segment horizontal = new Segment((int)TopLeft.X, 
            (int)TopLeft.X + (int)Width);
        Segment horizontalOther = new Segment((int)other.TopLeft.X,
            (int)other.TopLeft.X + (int)other.Width);
        Segment vertical = new Segment((int)TopLeft.Y,
            (int)TopLeft.Y + (int)Height);
        Segment verticalOther = new Segment((int)other.TopLeft.Y,
            (int)other.TopLeft.Y + (int)other.Height);

        Segment? horizontalIntersect = horizontal
            .Intersect(horizontalOther);
        Segment? verticalIntersect = vertical
            .Intersect(verticalOther);

        if (horizontalIntersect == null || verticalIntersect == null)
            return null;

        return new Rectangle(new Point(horizontalIntersect.Start, 
            verticalIntersect.Start), 
            (uint)horizontalIntersect.Length, 
            (uint)verticalIntersect.Length);
    }
    
    public override string ToString()
    {
        return new StringBuilder("Rectangle{")
            .Append(TopLeft.ToString())
            .Append(",Width=")
            .Append(Width)
            .Append(",Height=")
            .Append(Height)
            .Append("}")
            .ToString();
    }

    public bool Equals(Rectangle? other)
    {
        if (other == null)
            return false;

        if (Object.ReferenceEquals(this, other))
            return true;

        if (this.GetType() != other.GetType())
            return false;

        return other.TopLeft.X == TopLeft.X &&
            other.TopLeft.Y == TopLeft.Y &&
            other.Width == Width &&
            other.Height == Height;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(TopLeft.X, TopLeft.Y, Width, Height);
    }

    public object Clone()
    {
        return new Rectangle(new Point(TopLeft.X, TopLeft.Y), Width,
            Height);
    }
}