using System;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("These are a few of my favorite things:");

            var band1 = new Bands("Coheed and Cambria", "Nashville");
            band1.Perform();
            band1.Record();
        }
    }
}
