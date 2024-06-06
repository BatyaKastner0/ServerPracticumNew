using Managment.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Core.DTO
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string Tz { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime DateBorn { get; set; }
        public bool IsMale { get; set; }
        public List<EmployeeRoleDTO> Roles { get; set; }
        public bool IsActive { get; set; }

    }
}
