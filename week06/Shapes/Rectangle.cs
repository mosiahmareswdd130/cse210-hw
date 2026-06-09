namespace Shapes;

public class Rectangle : Shape
{
    private double _lenght;
    private double _width;

    public Rectangle(string color, double lenght, double width) : base (color)
{
    lenght = _lenght;
    width = _width;
}

    public override double GetArea()
    {
        return _lenght * _width;
    }
}