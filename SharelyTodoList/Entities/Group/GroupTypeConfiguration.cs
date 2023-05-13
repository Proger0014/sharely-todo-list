using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharelyTodoList.Models;

namespace SharelyTodoList.Entities.Group;

public class GroupTypeConfiguration : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.HasKey(g => g.Id);

        builder.Property(g => g.Name)
            .HasMaxLength(GroupModel.NameMaxLength);

        builder.Property(g => g.Password)
            .HasMaxLength(GroupModel.PasswordMaxLength);
    }
}
