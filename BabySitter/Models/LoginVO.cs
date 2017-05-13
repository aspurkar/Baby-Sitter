using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BabySitter.Models
{
    public class LoginVO
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name ="Enter Email")]
        public string email { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Enter Password")]
        public string password { get; set; }
    }
}