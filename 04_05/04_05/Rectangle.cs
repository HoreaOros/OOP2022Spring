// See https://aka.ms/new-console-template for more information
using _03_22;
using System.Text;
public class Rectangle: IEquatable<Rectangle>
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
    public override bool Equals(object? obj) => Equals(obj as Rectangle);
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
}