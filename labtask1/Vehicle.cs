using System;

class Vehicle
{
    private string color;
    private int year;
    public string Color 
    {
        get 
        {
            return color;
        }
        set
        {
            color = value;
        }
    }
    public int Year
    {
        get
        {
            return year;
        }
        set
        {
            year = value;
        }
    }
    public Vehicle(string _color,int _year)
    {
        color = _color;
        year = _year;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Color:{color},Year:{year}");
    }
    
}

