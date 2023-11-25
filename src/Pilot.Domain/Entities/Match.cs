using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Ardalis.GuardClauses;
using Pilot.Domain.Enum;


namespace Pilot.Domain.Entities
{
    public class Match
    {
        public Guid Id { get; init; }
        public Competition Competition { get; set; }
        public Guid RefereeId { get; }

        //Navigational properties
        public ICollection<Team> Teams { get; set; }

        public Match(Guid id, int competition, Guid refereeId, ICollection<Team> teams)
        {
            Id = id;
            Competition =  (Competition)competition;
            RefereeId = refereeId;
            if (teams.Count() != 2 && teams.All(x => x is Team))
            {
                throw new ArgumentException();
            }
            else
            {
                Teams = teams;
            }
            
        }
    }
}