using System;

class Circle:Shape
{
    private int radius;
    public int Radius {
        get 
        {
            return radius;
        }
        set
        {
            radius = value;
        }
    }
    public Circle(int _radius)
    {
        radius = _radius;
    }

    public override void CalculateArea()
    {
        Console.WriteLine("Dairenin sahesi:" + " " + Math.PI*Math.Pow(radius,2));
    }
}

