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
    public class RoleRepository:IRoleRepository
    {
        private readonly DataContext _dataContext;

        public RoleRepository(DataContext context)
        {
            _dataContext = context;
        }

        public async Task<IEnumerable<Role>> GetAllAsync()
        {
            return await _dataContext.RoleNamesArr.ToListAsync();
//Include(e => e.Name)
        }

        public async Task<Role> AddAsync(Role role)
        {
            _dataContext.RoleNamesArr.Add(role);
            await _dataContext.SaveChangesAsync();
            return role;
        }



        public Task<Role> UpdateAsync(Role role)
        {
            throw new NotImplementedException();
        }

        public Task<Role> GetByIdAsync(string tz)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(string tz)
        {
            throw new NotImplementedException();
        }
    }
}
