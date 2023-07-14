
Console.WriteLine("<----------------------Task1------------------------>");
#region task1
Car car1 = new Car("white", 3, "BMW", "XS-6", 60, 5);
car1.CurrentFuel = 24;
car1.AddFuel(21);
car1.ShowInfo();
#endregion
Console.WriteLine("<----------------------Task2------------------------>");
#region task2
Shape shape = new Shape();
shape.CalculateArea();
Shape object1 = new Circle(5);
object1.CalculateArea();
Shape object2 = new Rectangle(8,4);
object2.CalculateArea();
#endregion
Console.WriteLine("<----------------------Task3------------------------>");
#region task3
Employee employee1 = new Employee("Amin","Akhmedov",1500);
employee1.PersonalInfo();
Console.WriteLine("Bonus mebleg:"+ " " + employee1.CalculateBonus());
Employee employee2 = new Manager("Semed","Haciyev",2500);
employee2.PersonalInfo();
Console.WriteLine("Bonus mebleg:" + " " + employee2.CalculateBonus());
Employee employee3 = new Engineer("Yamen", "Rzayev", 3000);
employee3.PersonalInfo();
Console.WriteLine("Bonus mebleg:" + " " + employee3.CalculateBonus());
#endregion
Console.WriteLine("<----------------------Task4------------------------>");
#region task4
BankAccount bank1 = new BankAccount(17);
Console.WriteLine("Account Number:"+ " " +bank1.AccountNumber);
bank1.Deposit(10000);
bank1.WithDraw(500);
#endregion



