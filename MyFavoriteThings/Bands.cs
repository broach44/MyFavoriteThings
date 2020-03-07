using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class Bands
    {
        public string Name { get; set; }
        public bool IsTogether { get; set; }
        public string Hometown { get; set; }
        public string CurrentLocation { get; set; }

        public Bands(string name, string currentLocation)
        {
            Name = name;
            CurrentLocation = currentLocation;
        }

        public void Perform()
        {
            Console.WriteLine($"{Name} is performing tonight in {CurrentLocation}");
        }

        public void Record()
        {
            Console.Write($"{Name} is recording a new album in {CurrentLocation}");
        }
    }
}
