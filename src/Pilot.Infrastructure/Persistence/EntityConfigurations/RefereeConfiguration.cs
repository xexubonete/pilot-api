using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pilot.Domain.Entities;

namespace Pilot.Infrastructure.Persistence.EntityConfigurations
{
    public class RefereeConfiguration : IEntityTypeConfiguration<Referee>
    {
        public void Configure(EntityTypeBuilder<Referee> builder)
        {
            builder.ToTable("REFEREE");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.Property(x => x.FirstName)
            .HasColumnName("varchar(50)")
            .HasMaxLength(50)
            .IsRequired();

            builder.Property(x => x.SecondName)
            .HasColumnName("varchar(50)")
            .HasMaxLength(50)
            .IsRequired();

            builder.Property(x => x.Languages)
            .HasColumnType("varchar(100)")
            .HasMaxLength(100)
            .IsRequired();
        }
    }
}