using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pilot.Domain.Entities
{
    public class Player
    {
        public Guid Id { get; init; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Position { get; set; }
        public int YellowCard { get; set; }
        public int RedCard { get; set; }

        //FK Teams
        public Guid TeamId { get; set; }

    }
}