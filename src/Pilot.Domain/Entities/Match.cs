namespace Pilot.Domain.Entities
{
    public class Match
    {
        public Guid Id { get; init; }
        public Guid RefereeId { get; }
        public int CompetitionId { get; }

        //Navigational properties
        public Team LocalTeam { get; set; }
        public Team VisitorTeam { get; set; }

        public Match(){}
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