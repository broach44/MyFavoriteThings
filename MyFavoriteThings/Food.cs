using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class Food
    {
        public string Name { get; set; }
        public string Category { get; set; }
        
        public Food(string name, string category)
        {
            Name = name;
            Category = category;
        }

        public void Restock()
        {
            Console.WriteLine($"We need to restock {Name}");
        }

        public void HungerStrike()
        {
            Console.WriteLine($"I am in the mood to eat some {Category}");
        }

    }
}
