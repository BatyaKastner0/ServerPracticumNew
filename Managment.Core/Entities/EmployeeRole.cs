using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Core.Entities
{
    public  class EmployeeRole
    {
        [Key]
        public int EmployeeId{ get; set; }
        public int RoleId { get; set; }
        [Required(ErrorMessage = "Admin status is required")]
        public bool IsManagerial { get; set; }
        [Required(ErrorMessage = "Start date is required")]
        public DateTime StartDate { get; set; }
    }
}
