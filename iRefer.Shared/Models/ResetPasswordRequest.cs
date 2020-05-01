﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace iRefer.Shared.Models
{
   
        public class ResetPasswordRequest
        {
            [Required]
            public string Token { get; set; }
            [Required]
            public string Email { get; set; }
            [Required]
            [StringLength(50, MinimumLength = 5)]
            public string Password { get; set; }

            [Required]
            [StringLength(50, MinimumLength = 5)]
            public string ConfirmPassword { get; set; }

        }
    public class ForogtPasswordRequest
    {
      
        [Required]
        public string Email { get; set; }
       
        

    }
}