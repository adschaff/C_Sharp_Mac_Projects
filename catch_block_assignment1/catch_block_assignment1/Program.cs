using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Pick a number!");
            int number1 = Convert.ToInt32(Console.ReadLine()); // instead of creating list of intergers i did toInt32 - is that okay?
            Console.WriteLine("Pick another number!");
            int number2 = Convert.ToInt32(Console.ReadLine()); // second number creation
            Console.WriteLine("Let's divid the 2:"); 
            int number3 = number1 / number2;
            Console.WriteLine(number1 + " divided by " + number2 + " equals " + number3); //the line that does the divison and spills ito ut
        }
        catch (FormatException)
        {
            Console.WriteLine("Hi there -- you have to type a whole number:"); // try catch block one
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("You can't divide by zero!!"); // try catch block two
        }
        finally
        {
            Console.ReadLine();
        }


    }
}