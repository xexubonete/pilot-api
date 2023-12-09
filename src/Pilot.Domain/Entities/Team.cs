using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.GuardClauses;
using Pilot.Domain.Enum;

namespace Pilot.Domain.Entities
{
    public class Team
    {
        public Guid Id { get; init; }
        public string Name { get; }
        public string Country { get; }
        public ICollection<Competition> Competitions { get; }

        //Navigational properties
        public ICollection<Match>? Matchs { get; }

        public Team(Guid id, string name, string competition, string country)
        {
            Id = id;
            Name = Guard.Against.NullOrEmpty(name, nameof(name));
            Competitions = competition.Select(x => (Competition)x).ToList();
            Country = Guard.Against.NullOrEmpty(country, nameof(country));
        }
    }
}