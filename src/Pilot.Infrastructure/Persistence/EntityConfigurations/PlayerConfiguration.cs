using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            .IsRequired();
        }
    }
}