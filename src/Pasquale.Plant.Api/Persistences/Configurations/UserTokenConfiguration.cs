using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pasquale.Plant.Api.Domains.Entities;

namespace Pasquale.Plant.Api.Persistences.Configurations;

public class UserTokenConfiguration : IEntityTypeConfiguration<UserToken>
{
    public void Configure(EntityTypeBuilder<UserToken> builder)
    {
        builder.ToTable("user_tokens");

        builder.Property(x => x.UserId)
            .HasColumnName("user_id")
            .IsRequired();

        builder.Property(x => x.LoginProvider)
            .HasColumnName("login_provider")
            .IsRequired();

        builder.Property(x => x.Name)
            .HasColumnName("name")
            .IsRequired();

        builder.Property(x => x.Value)
            .HasColumnName("value")
            .IsRequired(false);
    }
}