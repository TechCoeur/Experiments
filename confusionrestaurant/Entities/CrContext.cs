using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace confusionrestaurant.Entities
{
    public class CrContext : IdentityDbContext
    {
        private IConfigurationRoot _config;

        public CrContext(DbContextOptions<CrContext> options, IConfigurationRoot config)
        :base(options)
        {
            _config = config;
        }
        public DbSet<Dish> Dishes {get; set;}
        public DbSet<Comment> Comments {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            
        }

    }
}