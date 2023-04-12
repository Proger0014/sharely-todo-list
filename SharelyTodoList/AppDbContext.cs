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

    public DbSet<TaskGroup> TaskGroups { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new TaskGroupTypeConfiguration()
            .Configure(modelBuilder.Entity<TaskGroup>());
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
