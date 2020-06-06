using System.ComponentModel.DataAnnotations;

namespace iRefer.Shared.Models
{
    public enum UserTypes { SysAdmin, AgencyAdmin = 2, AgencyUser = 3 }
    public class AgencyRoleByIDRequest
    {
        [Required]
        public string AgencyRoleID { get; set; }
        [Required]
        //this is ID from Identity table called Employee ID to Diffrnicate from userID used to show who edited the record.
        public string EmployeeUserID { get; set; }

        [Required]
        public string AgencyID { get; set; }
        public UserTypes UserType { get; set; }
    }
    public class AgencyRoleByEmailRequest
    {
        [Required]
        public string AgencyRoleID { get; set; }
        [Required]
        //this is ID from Identity table called Employee ID to Diffrnicate from userID used to show who edited the record.
        public string Email { get; set; }

        [Required]
        public string AgencyID { get; set; }
        public UserTypes UserType { get; set; }
    }
}
