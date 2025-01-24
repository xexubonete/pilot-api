namespace Pilot.Domain.Entities
{
    public class Match
    {
        public Guid Id { get; init; }
        public Guid RefereeId { get; private set; }
        public int CompetitionId { get; private set; }

        //Navigational properties
        public Team LocalTeam { get; set; } = null!;
        public Team VisitorTeam { get; set; } = null!;

        private Match() {} // Para EF Core

        public Match(Guid id, Guid refereeId, int competitionId, Team localTeam, Team visitorTeam)
        {
            Id = id;
            RefereeId = refereeId;
            CompetitionId = competitionId;
            LocalTeam = localTeam;
            VisitorTeam = visitorTeam;
        }
    }
}