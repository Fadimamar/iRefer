using System;
using System.Collections.Generic;
using System.Text;

namespace iRefer.Shared.Models
{
    public class AgencyRole
    {
        public Agency Agency { get; set; }
        
        public string EmployeeUserID { get; set; }
        
        public string AgencyId { get; set; }
        
        public int UserRoleID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string email { get; set; }

    }
}
