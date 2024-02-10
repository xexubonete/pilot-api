using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pilot.Domain.Entities;

namespace Pilot.Infrastructure.Persistence.EntityConfigurations
{
    public class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.ToTable("Player");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.FirstName)
            .HasMaxLength(50)
            .IsRequired();

            builder.Property(x => x.SecondName)
            .HasMaxLength(50)
            .IsRequired();

            builder.Property(x => x.Position)
            .HasMaxLength(50)
            .IsRequired();   

            builder.Property(x => x.YellowCard)
            .IsRequired();

            builder.Property(x => x.YellowCard)
            .IsRequired();        
        
        
        }
    }
}