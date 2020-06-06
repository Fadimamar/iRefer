using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text;

namespace iRefer.Shared.Models
{
    public class AgencyRequest
    {
       public String Id { get; set; }
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


        public Stream Logo { get; set; }

        public string FileName { get; set; }
    }
}
