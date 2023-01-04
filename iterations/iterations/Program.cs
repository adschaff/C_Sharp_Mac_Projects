using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace six_part_iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1 of assignment
            string[] First_Array = new string[] { "1, 2, 3, 4, 5, 6" };
            Console.WriteLine("Your Place in Line is:  ");
            string newNumber = Console.ReadLine();

            for (int i = 0; i < First_Array.Length; i++)
            {
                First_Array[i] = First_Array[i].Replace("number", newNumber);
            }
            foreach (string eStr in First_Array)
            {
                Console.WriteLine(eStr);
            }

            // Infinity Loop that works, I think
            Console.WriteLine("Infinity, Infinity, Infinity, ");
            int counter = 1;
            Console.WriteLine("Infinity, Infinity, Infinity, ");
            while (true)
            {
                Console.WriteLine("Infinity, Infinity, Infinity Infinity, Infinity");
                counter += 1;

                if (counter == 10)
                {
                    break;
                }
            }

            // Part 3 

            for (int countDown = 100; 0 < countDown; countDown--)
            {
                Console.WriteLine("Count Down to: " + countDown);

            }
            Console.WriteLine("Zero");

            for (int countDown = 10; 0 <= countDown; countDown--)
            {
                Console.WriteLine("Count Down to :" + countDown);
            }

            // Part four - match find

            List<string> numbers = new List<string>() { "one", "two", "three", "four", "five", "six"};
            Console.WriteLine("Please write out a number one - six to see its location : ");
            string searchNumber = Console.ReadLine();

            int d;
            for (d = 0; d < numbers.Count; d++)
            {
                if (numbers[d] == searchNumber)
                {
                    Console.WriteLine("The number you selected is here : " + d);
                    break;
                }

            }
            if (d > 9)
            {
                Console.WriteLine("The number you have selected is not stored");
            }

            // Part 5

            List<string> letters = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "c", "j" };
            Console.WriteLine("Please enter a letter a - j to see its location: ");
            string searchLetter = Console.ReadLine();

            int e;
            for (e = 0; k < letters.Count; e++)
            {
                if (letters[e] == searchLetter)
                {
                    Console.WriteLine("The letter(s) you selected is in index location : " + e);
                }

            }
            if (e > 9)
            {
                Console.WriteLine("We do not have your letter on file, sorry!");
            }

           

            // Part 6

              List<string> letters_two = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "c", "j" };
            List<string> letters_b = new List<string>();

            foreach (string letters_two in letters_two)
                
                if (letters_b.Contains(letters_two))
                {
                    Console.WriteLine(letters_two + " has already appeared in the list");
                }
                else
                {
                    Console.WriteLine(letters_two + " has not appeared in the list yet.");
                    letters_b.Add(letters_two);
                }


            Console.ReadLine();
        }
    }
}


