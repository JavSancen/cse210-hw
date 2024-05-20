public class Square : Shape
{
    private double sideLength;

    public Square(string color, double sideLength) : base(color)
    {
        this.sideLength = sideLength;
    }

    public override double GetArea()
    {
        return sideLength * sideLength;
    }
}