using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pilot.Domain.Entities;

namespace Pilot.Infrastructure.Persistence.EntityConfigurations
{
    public class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.ToTable("PLAYER");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.FirstName)
            .HasColumnType("varchar(50)")
            .HasMaxLength(50)
            .IsRequired();

            builder.Property(x => x.SecondName)
            .HasColumnType("varchar(50)")
            .HasMaxLength(50)
            .IsRequired();

            builder.Property(x => x.Position)
            .HasColumnType("varchar(50)")
            .HasMaxLength(50)
            .IsRequired();   

            builder.Property(x => x.YellowCard)
            .HasColumnType("decimal(2,0)")
            .IsRequired();

            builder.Property(x => x.YellowCard)
            .HasColumnType("decimal(2,0)")
            .IsRequired();        
        
        
        }
    }
}