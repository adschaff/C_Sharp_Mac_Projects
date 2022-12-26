using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine()); //Prompts user to ask age and the program and converts the age input into a variable
            Console.WriteLine("Have you ever had a DUI? answer true or false.");
            bool DUI = Convert.ToBoolean(Console.ReadLine()); //converts the true false into boolean
            Console.WriteLine("How many speeding tickets do you have?");
            int speedTicket = Convert.ToInt32(Console.ReadLine()); //converts the answer into a variable intgere

            Console.WriteLine("Qualified?"); //this section evavaluates based on the stored in the variables "age", "DUI", and "speedTicket" if someone qualifies for insurance
            bool ageQual = age > 15; 
            bool ticketQual = speedTicket <= 3;
            bool noDUI = DUI == false;
            Console.WriteLine(ageQual && ticketQual && noDUI);
            Console.ReadLine();
        }
    }
}