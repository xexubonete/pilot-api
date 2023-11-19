using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using Pilot.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pilot.Infrastructure.Persistence.EntityConfigurations
{
    public class MatchConfiguration : IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> builder)
        {
            builder.ToTable("MATCH");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            // builder.Property(x => x.Competition)
            // .IsRequired();

            // builder.Property(x => x.Teams)
            // .IsRequired();

            // builder.Property(x => x.RefereeId)
            // .IsRequired();
        }
    }
}