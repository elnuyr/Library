namespace Models
{
    public class Employee
    {
        public Employee(string name, bool isSuccessfull, int salary)
        {
            Name = name;
            IsSuccessfull = isSuccessfull;
            Salary = salary;
        }

        public string Name { get; set; }
        public bool IsSuccessfull { get; set; }
        public int Salary { get; set; }

        protected internal void UpdateSalary(int newSalary)
        {
            Salary = newSalary;
        }

    }
}
