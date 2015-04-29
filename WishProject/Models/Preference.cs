﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WishProject.Models
{
    public enum Occasionals { Birthday, Christmas, Anniversary, Valentines, Other }

    public class Preference
    {
        [Key]
        public int PreferenceId { get; set; }

        [Display(Name = "Please choose occasion:")]
        public Occasionals Occasions { get; set; }

        [Display(Name = "Type in your gift expectation:")]
        [StringLength(200, ErrorMessage = "No more than 200 characters allowed for preference description")]
        public string UserPreference { get; set; }

        [Display(Name = "Flowers YES/NO")]
        public bool Flowers { get; set; }


        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

    }
}