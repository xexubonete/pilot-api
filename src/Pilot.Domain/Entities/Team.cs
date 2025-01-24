using Ardalis.GuardClauses;

namespace Pilot.Domain.Entities
{
    public class Team
    {
        public Guid Id { get; init; }
        public string Name { get; init; } = string.Empty;
        public string Country { get; init; } = string.Empty;
        public IEnumerable<Competition> Competitions { get; init; } = new List<Competition>();

        //Navigational properties
        public IEnumerable<Match>? LocalMatchs { get; set; }
        public IEnumerable<Match>? VisitorMatchs { get; set; }
        public Team(){}
        public Team(Guid id, string name, IEnumerable<Competition> competitions, string country)
        {
            Id = id;
            Name = Guard.Against.NullOrEmpty(name, nameof(name));
            Competitions = competitions;
            Country = Guard.Against.NullOrEmpty(country, nameof(country));
        }
    }
}