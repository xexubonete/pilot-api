using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pilot.Domain.Entities
{
    public class Team
    {
        public Guid Id { get; init; }
        public string Name { get; set; }
        public string League { get; set; }
        public string Country { get; set; }

        //Matchs collection
        public ICollection<Match> Matchs { get; set; }
    }
}