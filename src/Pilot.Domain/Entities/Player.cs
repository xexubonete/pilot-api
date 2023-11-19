using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.GuardClauses;

namespace Pilot.Domain.Entities
{
    public class Player
    {
        public Guid Id { get; init; }
        public string? FirstName { get; }
        public string? SecondName { get; }
        public string? Position { get; set; }
        public int YellowCard { get; set; }
        public int RedCard { get; set; }

        //Navigational properties
        public Guid TeamId { get; set; }
        
        public Player(Guid id, string firstName, string secondName, string position, int yellowCard, int redCard)
        {
            Id = id; 
            FirstName = Guard.Against.NullOrEmpty(firstName, nameof(firstName));
            SecondName = Guard.Against.NullOrEmpty(secondName, nameof(secondName));
            Position = Guard.Against.NullOrEmpty(position, nameof(position));
            YellowCard = Guard.Against.Negative(yellowCard, nameof(yellowCard));
            RedCard = Guard.Against.Negative(redCard, nameof(redCard));
        }
    }
}