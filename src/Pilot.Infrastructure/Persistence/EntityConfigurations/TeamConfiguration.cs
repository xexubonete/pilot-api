using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pilot.Domain.Entities;

namespace Pilot.Infrastructure.Persistence.EntityConfigurations
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.ToTable("Team");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
            .ValueGeneratedNever();

            builder.Property(x => x.Name)
            .HasMaxLength(50)
            .IsRequired();

            builder.Property(x => x.Country)
            .HasMaxLength(50)
            .IsRequired();

            // builder.Property(x => x.Competitions)
            // .HasColumnName("")
            // .HasMaxLength(100)
            // .IsRequired();


        }
    }
}