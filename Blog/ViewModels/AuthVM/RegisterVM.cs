﻿using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels.AuthVM
{
    public class RegisterVM
    {
       
        public string Email { get; set; }
       
        public string Password { get; set; }

       
        public string ConfirmPassword { get; set; }
    }
}
