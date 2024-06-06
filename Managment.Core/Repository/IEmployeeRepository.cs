using Managment.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Core.Repository
{
    public interface IEmployeeRepository
    {
        public  Task<Employee> UpdateAsync(Employee employee);
        public  Task<Employee> GetByIdAsync(string tz);
        public  Task RemoveAsync(string tz);
        public  Task<IEnumerable<Employee>> GetAllAsync();
        public  Task<Employee> AddAsync(Employee employee);






    }
}
