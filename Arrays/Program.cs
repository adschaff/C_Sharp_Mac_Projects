using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] planetArray = { "earth", "sun", "saturn", "venus", "mars" }; //Creates the one-dimensional Array
            Console.WriteLine("Pick a number between 0 and 4."); //Asks the user to pick a number that is tied to the array
            int planetIndex = Convert.ToInt32(Console.ReadLine());
            if (planetIndex >= 0 && planetIndex <= 4)
            {
                Console.WriteLine("You chose " + planetArray[planetIndex]);
            }
            else
            {
                Console.WriteLine("You did not pick a number between 0 and 4.");
            } // in case someone doesn't pick through the very basic 0 through 4


            int[] integer_Array = { 1, 2, 3, 4, 5, 6, 7 }; // A one-dimensional Array of integers. 
            Console.WriteLine("Pick a number between 0 and 7."); //  Ask the user to select an index of the Array
            int integer_Index = Convert.ToInt32(Console.ReadLine());
            if (integer_Index >= 0 && integer_Index <= 7)
            {
                Console.WriteLine("You chose " + integer_Array[integer_Index]); //Display the integer at that index on the screen.
            }
            else
            {
                Console.WriteLine("You did not pick a number between 0 and 5."); //a message that displays when the user selects an index that doesn’t exist.
            }

            List<string> string_List = new List<string>(); // a list of strings
            string_List.Add("France");
            string_List.Add("Australia");
            string_List.Add("Thailand");
            string_List.Add("Russia");

            Console.WriteLine("Pick a number between 0 and 3."); // Ask the user to select an index of the list 
            int lstIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your next vacation should be " + string_List[lstIndex]); // and then display the content at that index on the screen.
            Console.ReadLine();

        }
    }
}