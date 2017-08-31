using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Favorite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favorite food: ");
            String food = Console.ReadLine();
            if (food == "pizza")
            {
                Console.WriteLine("You have great taste, good job!");
            }
            else
            {
                Console.WriteLine("Wrong. Pizza is the greatest.");
            }
        }
    }
}
