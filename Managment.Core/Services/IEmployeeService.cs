using Managment.Core.Entities;
using Managment.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Core.Services
{
    public interface IEmployeeService
    {
        public  Task<Employee> AddAsync(Employee employee);
        public  Task RemoveAsync(string tz);
        public Task<Employee> UpdateAsync(Employee employee);
        public Task<Employee> GetByIdAsync(string tz);
        public Task<IEnumerable<Employee>> GetAllAsync();






    }
}
