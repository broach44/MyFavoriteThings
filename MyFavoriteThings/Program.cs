using System;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("These are a few of my favorite things:");

            var band1 = new Bands("Coheed and Cambria", "Nashville");
            var band2 = new Bands("Muse", "London");
            
            band1.Perform();
            band1.Record();

            band2.Perform();
            band2.Record();

            var pet1 = new Animals("Chewie", "dog")
            {
                IsMale = true,
                Age = 1,
                IsSpayedOrNeutered = true
            };

            var pet2 = new Animals("Yoda", "dog")
            {
                IsMale = true,
                Age = 5,
                IsSpayedOrNeutered = false
            };

            pet1.AboutPet();
            pet2.AboutPet();

            pet1.VisitVet();
            pet2.VisitVet();

            var food1 = new Food("Pizza", "Dinner");
            var food2 = new Food("Ice Cream", "Dessert");

            food1.HungerStrike();
            food1.Restock();

            food2.HungerStrike();
            food2.Restock();

        }
    }
}
