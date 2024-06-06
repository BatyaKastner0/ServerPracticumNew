using Managment.Core.Entities;
using Managment.Core.Repository;
using Managment.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Services
{
    public class RoleService:IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task<Role> AddAsync(Role role)
        {
            return await _roleRepository.AddAsync(role);
        }

        public async Task RemoveAsync(string tz)
        {
            await _roleRepository.RemoveAsync(tz);
        }

        public async Task<IEnumerable<Role>> GetAllAsync()
        {
            return await _roleRepository.GetAllAsync();
        }
        /// <summary>
        /// ///////////////
        /// </summary>
        /// <param name="tz"></param>
        /// <returns></returns>
        public async Task<Role> GetByIdAsync(string tz)
        {
            return await _roleRepository.GetByIdAsync(tz);
        }

        public async Task<Role> UpdateAsync(Role role)
        {
            return await _roleRepository.UpdateAsync(role);
        }
    }
}
