using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class Vacation
    {
        public int DaysUntil { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public Vacation(string name, string location)
        {
            Name = name;
            Location = location;
        }

        public void FinalCountdown()
        {
            Console.WriteLine($"There are {DaysUntil} days until our {Name} to {Location}");
        }

        public void Dreaming()
        {
            Console.WriteLine($"I would really like to travel to {Location}");
        }
    }
}
