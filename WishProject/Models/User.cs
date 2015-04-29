﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WishProject.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Email { get; set; }
    }
}