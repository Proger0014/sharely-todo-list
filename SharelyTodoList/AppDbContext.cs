using Microsoft.EntityFrameworkCore;
using SharelyTodoList.Models.Group;

namespace SharelyTodoList;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Group>? Groups { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new GroupTypeConfiguration()
            .Configure(modelBuilder.Entity<Group>());
    }
}
