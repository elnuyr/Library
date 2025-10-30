using Models;
Employee employee = new Employee("Elnur", true, 500);
Assistant assistant = new Assistant("Kamran", true, 1000);

Console.WriteLine($"Before : {employee.Name} - Salary: {employee.Salary}");
assistant.GetFeedback(employee);
Console.WriteLine($"After : {employee.Name} - Salary: {employee.Salary}");

Console.WriteLine($"Assistant Ad : {assistant.Name} - Salary: {assistant.Salary}");
