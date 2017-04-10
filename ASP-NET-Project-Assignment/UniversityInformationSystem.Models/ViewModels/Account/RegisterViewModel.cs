﻿namespace UniversityInformationSystem.Models.ViewModels.Account
{
    using System.ComponentModel.DataAnnotations;

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email:")]
        public string Email { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "The password must be between 8 and 16 symbols")]
        [MaxLength(16, ErrorMessage = "The password must be between 8 and 16 symbols")]
        [DataType(DataType.Password)]
        [Display(Name = "Password:")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password:")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [RegularExpression(@"^[a-z\d]{5,10}$", ErrorMessage = "The username must contain only lowercase letters and digits between 5-10")]
        [Display(Name = "Username:")]
        public string UserName { get; set; }
    }
}