using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SharelyTodoList.Models.TaskGroup;

public class TaskGroupTypeConfiguration : IEntityTypeConfiguration<TaskGroup>
{
    public void Configure(EntityTypeBuilder<TaskGroup> builder)
    {
        builder.HasKey(tg => tg.Id);
    }
}
