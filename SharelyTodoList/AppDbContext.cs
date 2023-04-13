using Microsoft.EntityFrameworkCore;
using SharelyTodoList.Models.TaskGroup;

namespace SharelyTodoList;

public class AppDbContext : DbContext
{
    private readonly IConfiguration _configuration;

    public AppDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public DbSet<Group> TaskGroups { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new GroupTypeConfiguration()
            .Configure(modelBuilder.Entity<Group>());
    }

    protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseInMemoryDatabase(
                databaseName: _configuration["InMemoryDb:Name"] ?? "sharely-todo-list-db")
            .UseSnakeCaseNamingConvention();
    }
}
