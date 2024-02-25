using Ardalis.GuardClauses;

namespace Pilot.Domain.Entities
{
    public class Competition
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigational properties
        public IEnumerable<Match>? Matches { get; set; }
        public Competition(){}
        public Competition(int id, string name, IEnumerable<Match> matches)
        {
            Id = id;
            Name = Guard.Against.NullOrEmpty(name, nameof(name));
            Matches = matches;
        }
    }
}