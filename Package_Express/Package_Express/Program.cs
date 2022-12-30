using System;
Console.WriteLine("Welcome to Package Express! Please follow the instructions below.");
Console.WriteLine("Enter package weight in lbs:"); 

String Weight = Console.ReadLine();
double Weight2 = Convert.ToDouble(Weight);

if (Weight2 > 50)

{
    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
    Console.ReadLine(); // sets up the condition on the weight variable that if weight over 50 pounds to read out the message above

}
else

{
    Console.WriteLine("Enter package width."); 

    string Width = Console.ReadLine();

    Console.WriteLine("Enter package height");

    string Height = Console.ReadLine();

    Console.WriteLine("Enter package length"); // these three lines set up the inputs for the width/height/length

    string Length = Console.ReadLine();

    double Width2 = Convert.ToDouble(Width);

    double Height2 = Convert.ToDouble(Height);

    double Length2 = Convert.ToDouble(Length);

    double sum = Width2 + Height2 + Length2; // sets up the variable for the three different l/w/h inputs


    if (sum > 50) // if the sum of those three dimensions is over 50 total then read out the same too big message 

    {
        Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");

        Console.ReadLine();

    }

    else

    {
        double Sum2 = ((Width2 * Height2 * Length2) * Weight2)/ 100;

        Console.WriteLine("Your total shipping cost will be:");

        Console.WriteLine("$" + Sum2);

        Console.WriteLine("Thank you for choosing Package Express!");

        Console.ReadLine();

    } // this read out creates the total sum due if the total is under 50 divided by 100 to give an amount total

}
