using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LoopAssignments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the best beverage?"); //sets the question for the do while loop
            string beverage = Console.ReadLine();
            bool isGuessed = beverage == "Coffee";

            do
            {
                switch (beverage) //sets the different ansewrs/case for several beverage options
                {
                    case "Alcohol":
                        Console.WriteLine("You guessed alcohol. Wrong!");
                        Console.WriteLine("Guess again!");
                        beverage = Console.ReadLine();
                        break;
                    case "Soda":
                        Console.WriteLine("You guessed soda. Wrong!");
                        Console.WriteLine("Guess again!");
                        beverage = Console.ReadLine();
                        break;
                    case "Water":
                        Console.WriteLine("You guessed water. Wrong!");
                        Console.WriteLine("Guess again!");
                        beverage = Console.ReadLine();
                        break;
                    case "Coffee":
                        Console.WriteLine("You guessed Coffee. That is correct!!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess again!");
                        beverage = Console.ReadLine();
                        break;
                }
            }
            while (!isGuessed); //Once the correct option is picked, the next loop starts:

            Console.WriteLine("Now pick what type of coffee is best?!");
            string coffee_type = Console.ReadLine();
            bool isCorrect = coffee_type == "espresso";

            while (!isCorrect) // sets the different options for type of coffee 
            {
                switch (coffee_type)
                {
                    case "drip":
                        Console.WriteLine("You picked drip. Wrong! Try again!");
                        coffee_type = Console.ReadLine();
                        break;
                    case "french press":
                        Console.WriteLine("You picked french press. Nope! Try Again!");
                        coffee_type = Console.ReadLine();
                        break;
                    case "turkish":
                        Console.WriteLine("You picked turkish. Not even close!");
                        Console.WriteLine("One more try?");
                        coffee_type = Console.ReadLine();
                        break;
                    case "espresso":
                        isCorrect = true;
                        break; // lets the program know that espresso is the correct answer and to break out of the loop

                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess again!");
                        coffee_type = Console.ReadLine();
                        break;
                }

            }
            Console.WriteLine("You picked espresso! That is correct!!!");
            Console.ReadLine();
        }
    }
}