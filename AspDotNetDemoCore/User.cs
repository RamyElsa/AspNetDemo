using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspDotNetDemoCore
{
    public class User
    {
        [Required(ErrorMessage ="The ID Of User Is Rquired ")]
        [Display(Name ="Id")]
        public int Id { get; set; }


        [Required(ErrorMessage = "The FirstName Of User Is Rquired ")]
        [Display(Name = "FirstName")]
        [MaxLength(15,ErrorMessage ="Please enter corrct value"),MinLength(2)]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "The LastName Of User Is Rquired ")]
        [Display(Name = "LastName ")]
        [MaxLength(15, ErrorMessage = "Please enter corrct value"),MinLength(2)]
        [DataType(DataType.Text)]
        public string LastName { get; set; }


        [Required(ErrorMessage = "The Email Of User Is Rquired ")]
        [Display(Name = "Email  ")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "The Password Of User Is Rquired ")]
        [Display(Name = "Password  ")]
        [DataType(DataType.Password)]
        [MinLength(8),MaxLength(16)]
        public string Password { get; set; }

        [Display(Name = "PhoneNumber  ")]
        [DataType(DataType.PhoneNumber)]
        public long PhoneNumber { get; set; }

        
        [Display(Name = "Bio  ")]
        public string Bio { get; set; }
    }
}
