namespace testing_1.Services
{
    public class EmployeeService
    {
        public IEnumerable<Employee> GetEmployees()
        {
            // Пример заглушки для возвращения списка
            return new List<Employee>
            {
                new Employee { Name = "John Doe", Post = "Manager" }
            };
        }

        public Employee CreateEmployee(Employee employee)
        {
            // Пример заглушки для создания
            return employee;
        }
    }
}