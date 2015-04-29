using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WishProject.Models
{
    public enum Occasionals { Birthday, Christmas, Anniversary, Valentines, Other }

    public class Preference
    {
        [Key]
        public int PreferenceId { get; set; }

        public Occasionals Occasions { get; set; }

        public string UserPreference { get; set; }

        public bool Flowers { get; set; }


        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

    }
}