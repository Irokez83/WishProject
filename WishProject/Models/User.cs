using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WishProject.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Please provide valid E-mail address")]
        public string Email { get; set; }
    }
}