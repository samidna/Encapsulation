
using ConsoleApp3.Models;

//Book book = new("test", "admin", "user", 5);
//book.Increase(5);
//book.Decrease(2);

Employee employee = new(1, "John", "CEO", 5000);
//Employee employee2 = new(2, "Brian", "Engineer", 1500);
//Employee employee3 = new(3, "Cruyff", "Director", 3000);

employee.UpdateSalary(7500);
//employee2.ChangePosition("Data Analystic");
//employee3.UpdateSalary(4000);

employee.EmployeeInformation();

