using System;

class Car:Vehicle
{
    private string brand;
    private string model;
    private double fuelCapacity;
    private double fuelFor1Km;
    private double currentFuel;
    public string Brand 
    { get 
      {
        return brand;
      } 
      set 
      {
            brand = value;
      } 
    }
    public string Model
    { get 
      {
        return model;
      } 
      set 
      {
            model = value;
      } 
    }
    public double FuelCapacity
    {
        get
        {
            return fuelCapacity;
        }
        set
        {
            fuelCapacity = value;
        }
    }
    public double FuelFor1Km
    {
        get
        {
            return fuelFor1Km;
        }
        set
        {
            fuelFor1Km = value;
        }
    }
    public double CurrentFuel
    {
        get
        {
            return currentFuel;
        }
        set
        {
            currentFuel = value;
        }
    }



    public Car(string color,int year,string _brand,string _model,double _fuelCapacity,double _fuelFor1Km):base(color,year)
    {
        brand = _brand;
        model = _model;
        fuelCapacity = _fuelCapacity;
        fuelFor1Km = _fuelFor1Km;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Color:{Color}\nYear:{Year}\nBrand:{brand}\nModel{model}\nFuelCapacity:{fuelCapacity}\nFuelFor1Km:{fuelFor1Km}\nCurrentFuel:{currentFuel}");
    }
    public void AddFuel(double amount)
    {
        if (amount <= fuelCapacity) 
        {
            currentFuel += amount;
            Console.WriteLine($"Current Fuel:{currentFuel}");
        }
        else 
        {
            Console.WriteLine("FuelCapacity must be bigger than amount");
        }
    }
}

