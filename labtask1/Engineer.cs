using System;

class Engineer:Employee
{
    public Engineer(string name, string surName, int salary) : base(name,surName,salary)
    {

    }

    public override double CalculateBonus()
    {
        return salary * 0.2;
    }
}

