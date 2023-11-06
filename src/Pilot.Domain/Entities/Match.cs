using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pilot.Domain.Entities
{
    public class Match
    {
        public Guid Id { get; init; }
        
        //FK 
        public Guid CompetitionId { get; set; }
        public Guid RefereeId { get; set; }
        //Teams Collection
        public ICollection<Team> Teams { get; set; }
    }
}