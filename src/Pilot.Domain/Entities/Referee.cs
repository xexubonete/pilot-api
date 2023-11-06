using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pilot.Domain.Entities
{
    public class Referee
    {
        public Guid Id { get; init; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Language { get; set; }
    }
}