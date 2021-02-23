using EmployeeMangement.Models.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.Services
{
    public interface IEmployeeService
    {
        public List<Employee> Gets();
        public bool Create(Employee request);
        public Employee Get(int id);
        public bool Edit(Employee request);
        public bool Delete(int id);
    }
}
