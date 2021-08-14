using Microsoft.EntityFrameworkCore;
using FileContextCore;
using XVideoManager.Core.Entities;

namespace XVideoManager.Core.Contexts
{
    class FileDbContext : DbContext
    {
        public DbSet<VideoEntity>? Videos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseFileContextDatabase();
        }
    }
}
