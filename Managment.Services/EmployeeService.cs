using Managment.Core.Entities;
using Managment.Core.Repository;
using Managment.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Managment.Services.EmployeeService;

namespace Managment.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Employee> AddAsync(Employee employee)
        {
            var existingEmployees = await _employeeRepository.GetAllAsync();
            if (!employee.Tz.All(char.IsDigit) ||
                existingEmployees.Any(x => x.Tz == employee.Tz))
            {
                return null;
            }
            return await _employeeRepository.AddAsync(employee);
        }

        public async Task RemoveAsync(string tz)
        {
            await _employeeRepository.RemoveAsync(tz);
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await _employeeRepository.GetAllAsync();
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Employee> GetByIdAsync(string tz)
        {
            return await _employeeRepository.GetByIdAsync(tz);
        }

        public async Task<Employee> UpdateAsync(Employee employee)
        {
            return await _employeeRepository.UpdateAsync(employee);
        }
    }
}
