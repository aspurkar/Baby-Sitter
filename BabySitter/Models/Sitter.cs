using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BabySitter.Models
{
    public class Sitter
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string email { get; set; }

        [Required]
        [Display(Name = "Enter First Name")]
        public string firstName { get; set; }

        [Required]
        [Display(Name = "Enter Last Name")]
        public string lstName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Enter Password")]
        public string password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Re-enter Password")]
        [Compare("password", ErrorMessage = "do not match with password")]
        public string repassword { get; set; }

        [Required]
        [Display(Name = "Enter Phone Number")]
        public string contactNo { get; set; }



        [Required]
        [Display(Name = "Enter City")]
        public string city { get; set; }

        [Required]
        [Display(Name = "Enter State")]
        public string state { get; set; }

        [Required]
        [Display(Name = "Enter country")]
        public string country { get; set; }

        [Required]
        [Display(Name = "Expected Salary Range")]
        public string salaryRange { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string gender { get; set; }

        [Required]
        [Display(Name = "are You Married")]
        public bool isMarried { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        public string birthDate { get; set; }


        [Required]
        [Display(Name = "age")]
        public int age { get; set; }


        [Required]
        [Display(Name = "About Yourself")]
        public string about { get; set; }




        public byte[] image { get; set; }





    }
}