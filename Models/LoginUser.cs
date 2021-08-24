using System;
using System.ComponentModel.DataAnnotations;

namespace ApartmentNetwork.Models
{
    public class LoginUser
    {
        [Display(Name = "User Email")]
        [Required(ErrorMessage = "You need to add an email!")]
        // [Required(String =".com")]
        [MinLength(5, ErrorMessage = "You need to add an email with at least 5 letters!")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string LoginEmail {get;set;}

        [Display(Name = "User Password")]
        [Required(ErrorMessage = "You need to add a password!")]
        [MinLength(8, ErrorMessage = "You need to add a password with at least 8 letters!")]
        [DataType(DataType.Password)]
        public string LoginPassword {get;set;}
    }
}