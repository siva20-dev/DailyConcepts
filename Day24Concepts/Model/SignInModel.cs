﻿using System.ComponentModel.DataAnnotations;
namespace BookStoreAPI.Model
{
    public class SignInModel
    {
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
