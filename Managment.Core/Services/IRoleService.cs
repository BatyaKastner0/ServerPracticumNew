using Managment.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Core.Services
{
    public interface IRoleService
    {
        public Task<Role> AddAsync(Role role);
        public Task RemoveAsync(string tz);
        public Task<Role> UpdateAsync(Role role);
        public Task<Role> GetByIdAsync(string tz);
        public Task<IEnumerable<Role>> GetAllAsync();

    }
}
