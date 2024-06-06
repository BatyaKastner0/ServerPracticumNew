using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Core.Entities
{
    public class Role  
    {   
        [Key]
      public  int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(10, ErrorMessage = "Name must be less than 10 characters")]
        public  string Name { get; set; }
    }
}
