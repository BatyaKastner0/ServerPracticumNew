using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Core.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Tz { get; set; }
        [StringLength(15, ErrorMessage = "First Name must be less than 15 characters")]

        public string FirstName { get; set; }
        [StringLength(20, ErrorMessage = "Last Name must be less than 20 characters")]

        public string LastName { get; set; }
        [Required(ErrorMessage = "Start date is required")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "Date of born is required")]
        public DateTime DateBorn { get; set; }
        [Required(ErrorMessage = "Gender is required")]
        public bool IsMale { get; set; }
 public List<EmployeeRole> Roles { get; set; }
        [Required(ErrorMessage = "Activation status is required")]
        public bool IsActive { get; set; } = true;
    }
}
