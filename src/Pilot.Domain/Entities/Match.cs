using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Threading.Tasks;
using Ardalis.GuardClauses;


namespace Pilot.Domain.Entities
{
    public class Match
    {
        public Guid Id { get; init; }
        
        //Navigational properties
        public Guid CompetitionId { get; }
        public Guid RefereeId { get; }
        public ICollection<Team> Teams { get; }

        public Match(Guid id, Guid competitionId, Guid refereeId, ICollection<Team> teams)
        {
            Id = id;
            CompetitionId =  competitionId;
            RefereeId = refereeId;

        }
    }
}