using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SharelyTodoList.Entities.AccessToken;

public class AccessTokenTypeConfiguration : IEntityTypeConfiguration<AccessToken>
{
    public void Configure(EntityTypeBuilder<AccessToken> builder)
    {
        builder.HasKey(at => at.Token);

        builder.Property(at => at.Token)
            .IsRequired();

        builder.Property(at => at.GroupId)
            .IsRequired();
    }
}