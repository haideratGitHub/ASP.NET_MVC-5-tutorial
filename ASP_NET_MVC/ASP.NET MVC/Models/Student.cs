using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ASP.NET_MVC.Models
{
    public class Student
    {
        //[Required(ErrorMessage ="Please enter your first name")]
        [MyValidation] //for custom validation
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Range(18,100)]
        public int age { get; set; }
    }
}