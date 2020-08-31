using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employees;
        public MockEmployeeRepository()
        {
            _employees = new List<Employee>
            {
                new Employee(){Id=1,Name="Pramod",Email="pramodv@chetu.com",Department=Dept.Development},
                new Employee(){Id=2,Name="Aakash",Email="aakashp@chetu.com",Department=Dept.IT},
                new Employee(){Id=3,Name="Servagya",Email="servagyac@chetu.com",Department=Dept.HR},
            };
        }

        public Employee Add(Employee employee)
        {
          employee.Id= _employees.Max(e => e.Id) + 1 ;
            _employees.Add(employee);
            return employee;
         
        }

        public Employee Delete(int id)
        {
            Employee employee = _employees.FirstOrDefault(e => e.Id == id);
            if (employee!=null)
            {
                _employees.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employees;
        }

        public Employee GetEmployee(int id)
        {
            return _employees.FirstOrDefault(e => e.Id==id);
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = _employees.FirstOrDefault(e => e.Id == employeeChanges.Id);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Department = employeeChanges.Department;
            }
            return employee;
        }
    }
}
