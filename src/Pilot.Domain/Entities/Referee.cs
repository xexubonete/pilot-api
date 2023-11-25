using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.GuardClauses;
using Pilot.Domain.Enum;

namespace Pilot.Domain.Entities
{
    public class Referee
    {
        public Guid Id { get; init; }
        public string? FirstName { get; }
        public string? SecondName { get; }
        public ICollection<Language>? Languages { get; set; }
        public Referee(Guid id, string firstName, string secondName, ICollection<int> languages)
        {
            Id = id;
            FirstName = Guard.Against.NullOrEmpty(firstName, nameof(firstName));
            SecondName = Guard.Against.NullOrEmpty(secondName, nameof(secondName));
            
            Languages = languages.Select(x => (Language)x).ToList();
        }
    }
}