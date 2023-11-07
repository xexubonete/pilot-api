using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pilot.Domain.Entities
{
    public class Team
    {
        public Guid Id { get; init; }
        public string Name { get; }
        public string League { get; }
        public string Country { get; }

        //Navigational properties
        public ICollection<Match> Matchs { get; }
    }
}