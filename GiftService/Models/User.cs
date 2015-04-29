using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace GiftService.Models
{
    public enum Occasionals { Birthday, Christmas, Anniversary, Valentines, Other }
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Please provide valid E-mail address")]
        public string Email { get; set; }
        //each user has a collection of preferences
        List<Preference> prefs { get; set; }
    }
    public class UserContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Preference> Preferences { get; set; }
    }
}