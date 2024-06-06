using Managment.Core.Entities;
using Managment.Core.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataContext _dataContext;
        public EmployeeRepository(DataContext context)
        {
            _dataContext = context;
        }


        public async Task<Employee> AddAsync(Employee employee)
        {
            _dataContext.Employees.Add(employee);
            await _dataContext.SaveChangesAsync();
            return employee;
        }   
        public async Task<IEnumerable<Employee>> GetAllAsync()
    {
        return await _dataContext.Employees.Include(c => c.Roles).ToListAsync();
    }

        public async Task RemoveAsync(string tz)
        {
            var employee = await GetByIdAsync(tz);
            _dataContext.Employees.Remove(employee);
            await _dataContext.SaveChangesAsync();
        }
        public async Task<Employee> GetByIdAsync(string tz)
        {
            //return await _dataContext.Employees.FindAsync(tz);
            return await _dataContext.Employees
               .Include(c => c.Roles)
                     .FirstOrDefaultAsync(c => c.Tz == tz);
        }

        public async Task<Employee> UpdateAsync(Employee employee)
        {
            Employee employeeToUpdate = await GetByIdAsync(employee.Tz);
            _dataContext.Entry(employeeToUpdate).CurrentValues.SetValues(employeeToUpdate);
            await _dataContext.SaveChangesAsync();
            return employeeToUpdate;
        }
        //public async Task<Employee> UpdateAsync(Employee employee)
        //{
        //    _dbContext.Employees.Update(employee);
        //    await _dbContext.SaveChangesAsync();
        //    return employee;
        //}
    }
}
