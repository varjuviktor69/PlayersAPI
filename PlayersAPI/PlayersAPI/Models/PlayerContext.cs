using Microsoft.EntityFrameworkCore;

namespace PlayersAPI.Models
{
    public class PlayerContext : DbContext
    {
        public PlayerContext (DbContextOptions<PlayerContext> options)
            : base(options)
        {

        }
        public DbSet<Player> Players { get; set; }
        public DbSet<Club> Clubs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder
        optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;userid = root; database = db_elso", ServerVersion.Parse("10.4.21 - mariadb"));
            }
        }
    }
}
