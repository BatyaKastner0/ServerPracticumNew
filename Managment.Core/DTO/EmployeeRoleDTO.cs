using Managment.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Core.DTO
{
    public class EmployeeRoleDTO
    {
        
        public int RoleId { get; set; }

        public bool IsManagerial { get; set; }
        public DateTime StartDate { get; set; }
    }
}
