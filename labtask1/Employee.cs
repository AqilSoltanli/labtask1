using System;

class Employee
{
    public string name;
    public string Name 
    { 
        get 
        {
            return name;
        }
        set 
        {
            name = value;
        } 
    }
    public string surName;
    public string Surname
    {
        get
        {
            return surName;
        }
        set
        {
            surName = value;
        }
    }
    public int salary;
    public int Salary
    {
        get
        {
            return salary;
        }
        set
        {
            salary = value;
        }
    }
    public Employee(string _name, string _surname, int _salary)
    {
        name = _name;
        surName = _surname;
        salary = _salary;
    }

    public void PersonalInfo()
    {
        Console.WriteLine($"AD:{name},SOYAD:{surName},MAAS:{salary}");
    }    

    public virtual double CalculateBonus()
    {
        return salary * 0.1;
    }
}

