using System;


class Manager:Employee
{
    public Manager(string name,string surName,int salary):base(name,surName,salary)
    {
        
    }

    public override double CalculateBonus()
    {
        return salary * 0.15;
    }
}

