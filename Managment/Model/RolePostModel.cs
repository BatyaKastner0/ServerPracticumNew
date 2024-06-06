using Managment.Core.Entities;

namespace Managment.API.Model
{
    public class RolePostModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
      public List<EmployeeRolePostModel> RolsForEmployee { get; set; }

    }
}
