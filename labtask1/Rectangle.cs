using System;

class Rectangle:Shape
{
    private int length;
    public int Length 
    {
        get 
        {
            return length;
        }
        set 
        {
            length = value;
        } 
    }
    public int Width
    {
        get
        {
            return width;
        }
        set
        {
            width = value;
        }
    }
    private int width;

    public Rectangle( int _length, int _width)
    {
        length = _length;
        width = _width;
    }
    public override void CalculateArea()
    {
        Console.WriteLine("Duzbucaqlinin sahesi:" + " " + length*width);
    }

}

