using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pilot.Domain.Enum;

namespace Pilot.Domain.Entities
{
    public class Referee
    {
        public Guid Id { get; init; }
        public string FirstName { get; }
        public string SecondName { get; }
        public ICollection<Language> Language { get; set; }
    }
}