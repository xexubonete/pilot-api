using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Threading.Tasks;
using Ardalis.GuardClauses;
using Pilot.Domain.Enum;


namespace Pilot.Domain.Entities
{
    public class Match
    {
        public Guid Id { get; init; }
        
        //Navigational properties
        public Competition Competition { get; set; }
        public Guid RefereeId { get; }
        public ICollection<Team> Teams { get; set; }

        public Match(Guid id, Competition competition, Guid refereeId, ICollection<Team> teams)
        {
            Id = id;
            Competition =  competition;
            RefereeId = refereeId;

        }
    }
}