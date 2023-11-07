using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pilot.Domain.Entities
{
    public class Player
    {
        public Guid Id { get; init; }
        public string FirstName { get; }
        public string SecondName { get; }
        public string Position { get; set; }
        public int YellowCard { get; set; }
        public int RedCard { get; set; }

        //Navigational properties
        public Guid TeamId { get; set; }

    }
}