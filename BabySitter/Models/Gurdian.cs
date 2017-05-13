using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BabySitter.Models
{
    public class Gurdian
    {
       

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name ="Email Address")]
        public string email { get; set; }

        [Required]
        [Display(Name = "Enter First Name")]
        public string firstName { get; set; }


        [Required]
        [Display(Name = "Enter Last Name")]
        public string lstName { get; set; }




        [Required]
        [Display(Name = "Enter City")]
        public string city { get; set;}


        [Required]
        [Display(Name = "Enter State")]
        public string state { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Enter Password")]
        public string password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Re-enter Password")]
        [Compare("password", ErrorMessage = "do not match with password")]
        public string repassword { get; set; }


        [Display(Name ="Select Image")]
        public byte[] image { get; set; }

        [Required]
        [Display(Name = "Enter country")]
        public string country { get; set; }

        [Required]
        [Display(Name = "Contact Number")]
        public string contactNo { get; set;  }

        [Required]
        [Display(Name = "Write about yourself:")]
        public string about { get; set; }


    }
}