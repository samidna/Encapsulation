namespace ConsoleApp3.Models;

public class Employee
{
    int _id;
    string _name;
    string _position;
    double _salary;

    public int Id
    {
        get => _id;
        set => _id = value;
    }
    public string Name
    {
        get => _name;
        set
        {
            if (value.Length <3) Console.WriteLine("Name characters must be more than 3");
            else _name = value;
        }
    }
    public string Position
    {
        get => _position;
        set => _position = value;
    }
    public double Salary
    {
        get => _salary;
        set
        {
            if(value < 400) Console.WriteLine("Employee salary must be more than 400");
            else _salary = value;
        }
    }

    public Employee(int id, string name, string position, double salary)
    {
        Id=id;
        Name=name;
        Position=position;
        Salary=salary;
    }

    public void UpdateSalary(double newSalary)
    {
        Salary = newSalary;
    }
    public void ChangePosition(string newPosition)
    {
        Position = newPosition;
    }
    public void EmployeeInformation()
    {
        Console.WriteLine($"Employee id : {Id}\nEmployee name : {Name}\nEmployee position : {Position}\nEmployee salary : {Salary}");
    }
}
