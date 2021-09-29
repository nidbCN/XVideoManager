using Microsoft.EntityFrameworkCore;
using FileContextCore;
using XVideoManager.Core.Entities;

namespace XVideoManager.Core.Contexts
{
    public class FileDbContext : DbContext
    {

#nullable disable
        public DbSet<VideoEntity> Videos { get; set; }
#nullable restore

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseFileContextDatabase();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var videoEntity = modelBuilder.Entity<VideoEntity>();

            videoEntity.Property(x => x.Code).IsRequired();
            videoEntity.Property(x => x.Title).IsRequired();
            videoEntity.Property(x => x.Banner).IsRequired();
            videoEntity.Property(x => x.Link).IsRequired();

            videoEntity.HasIndex(x => x.Code);
        }
    }
}
