using System;
using System.Data.Entity;


namespace WishProject.Models
{
    public class WishProjectContext : DbContext
    {
        
        public WishProjectContext() : base("name=WishProjectContext")
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Preference> Preferences { get; set; }
    
    }
}
