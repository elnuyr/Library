namespace Models
{
    public class Manager : Employee
    { 

        public Manager(string name, bool isSuccessfull, int salary) : base(name, isSuccessfull, salary)
        { }

        protected internal void GetPromotion(Employee employee)
        {
            if (employee.IsSuccessfull)
            {
                employee.UpdateSalary(employee.Salary + 100);

            }
        }
    }
}
