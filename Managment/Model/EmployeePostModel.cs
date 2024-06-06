using Managment.Core.Entities;

namespace Managment.API.Model
{
    public class EmployeePostModel
    {
        
        public string Tz { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime DateBorn { get; set; }
        public bool IsMale { get; set; }
        public List<EmployeeRolePostModel> Roles { get; set; }
        public bool IsActive { get; set; }=true;
    }
}
