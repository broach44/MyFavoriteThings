using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class Animals
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }
        public bool IsMale { get; set; }
        public bool IsSpayedOrNeutered { get; set; }

        public Animals(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public void VisitVet()
        {
            if (!IsSpayedOrNeutered)
            {
                Console.WriteLine($"{Name} needs to go to the vet to be spayed/neutered.");
            }
            else
            {
                Console.WriteLine($"{Name} can no longer reproduce, yay!");
            }
        }

        public void AboutPet()
        {
            var gender = (IsMale) ? "male" : "female";
            Console.WriteLine($"{Name} is a {Age} year old {gender} {Type}");
        }
    }

}
