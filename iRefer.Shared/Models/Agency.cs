using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;


namespace iRefer.Shared.Models
{
    class Agency
    {
       

        [Required]
        [StringLength(100)]
        public string AgencyName { get; set; }
        [StringLength(100)]
        public string Website { get; set; }
        [Required]
        [StringLength(20)]
        public string PhoneNo { get; set; }

        [StringLength(50)]
        public string Address1 { get; set; }
        [StringLength(50)]
        public string Address2 { get; set; }

        [StringLength(50)]
        public string City { get; set; }
        [StringLength(10)]
        public string ZipCode { get; set; }
        [StringLength(2)]
        public string State { get; set; }

        [StringLength(256)]
        public string Logo { get; set; }

      
    }
}
