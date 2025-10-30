namespace Models
{
    public class Assistant : Manager
    {
        public Assistant(string name, bool isSuccessfull, int salary) : base(name, isSuccessfull, salary)
        { }

        public void GetFeedback(Employee employee)
        {
            if (employee.IsSuccessfull)
            {
                GetPromotion(employee);
            }

        }

    }
}
