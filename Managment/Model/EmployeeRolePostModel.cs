namespace Managment.API.Model
{
    public class EmployeeRolePostModel
    {
        public int EmployeeId { get; set; }
        public int RoleId { get; set; }
        public bool IsManagerial { get; set; }
        public DateTime StartDate { get; set; }
    }
}
