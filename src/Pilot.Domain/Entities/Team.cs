using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.GuardClauses;

namespace Pilot.Domain.Entities
{
    public class Team
    {
        public Guid Id { get; init; }
        [Required]
        public string Name { get; }
        public string League { get; }
        public string Country { get; }

        //Navigational properties
        public ICollection<Match>? Matchs { get; }

        public Team(Guid id, string name, string league, string country)
        {
            Id = id;
            Name = Guard.Against.NullOrEmpty(name, nameof(name));
            League = Guard.Against.NullOrEmpty(league, nameof(league));
            Country = Guard.Against.NullOrEmpty(country, nameof(country));
        }
    }
}