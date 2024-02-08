using Ardalis.GuardClauses;

namespace Pilot.Domain.Entities
{
    public class Referee
    {
        public Guid Id { get; init; }
        public string? FirstName { get; }
        public string? SecondName { get; }

        // Navigational properties
        public IEnumerable<Language>? Languages { get; set; }
        public Referee(){}
        public Referee(Guid id, string firstName, string secondName, IEnumerable<Language> languages)
        {
            Id = id;
            FirstName = Guard.Against.NullOrEmpty(firstName, nameof(firstName));
            SecondName = Guard.Against.NullOrEmpty(secondName, nameof(secondName));
            Languages = languages;
        }
    }
}