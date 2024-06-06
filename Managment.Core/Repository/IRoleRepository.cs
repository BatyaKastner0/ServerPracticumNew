using Managment.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Core.Repository
{
    public interface IRoleRepository
    {
        public Task<Role> UpdateAsync(Role role);
        public Task<Role> GetByIdAsync(string tz);
        public Task RemoveAsync(string tz);
        public Task<IEnumerable<Role>> GetAllAsync();
       public Task<Role> AddAsync(Role role);

    }
}
