using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of trip would you like to go on, musical, tropical, or adventurous? ");
            string vacationtype = Console.ReadLine();

            Console.WriteLine("How many are in your group? ");
            int groupsize = int.Parse(Console.ReadLine());

            if (vacationtype == "musical" && groupsize <= 2)
            {
                string result1 = ("Since you're a group of " + groupsize + " going on a " + vacationtype + " vacation, you should take first class to New Orleans.");
                Console.WriteLine(result1);
             }

            else if (vacationtype == "musical" && groupsize <= 5)
            {
                string result1 = ("Since you're a group of " + groupsize + " going on a " + vacationtype + " vacation, you should take a helicopter to New Orleans.");
                Console.WriteLine(result1);
            }

            else if (vacationtype == "musical" && groupsize >= 6)
            {
                string result1 = ("Since you're a group of " + groupsize + " going on a " + vacationtype + " vacation, you should take a charter flight to New Orleans.");
                Console.WriteLine(result1);
            }

            else if (vacationtype == "tropical" && groupsize <= 2)
            {
                string result1 = ("Since you're a group of " + groupsize + " going on a " + vacationtype + " vacation, you should take first class to a beach vacation in Mexico.");
                Console.WriteLine(result1);
            }

            else if (vacationtype == "tropical" && groupsize <= 5)
            {
                string result1 = ("Since you're a group of " + groupsize + " going on a " + vacationtype + " vacation, you should take a helicopter to a beach vacation in Mexico.");
                Console.WriteLine(result1);
            }

            else if (vacationtype == "tropical" && groupsize >= 6)
            {
                string result1 = ("Since you're a group of " + groupsize + " going on a " + vacationtype + " vacation, you should take a charter flight to a beach vacation in Mexico.");
                Console.WriteLine(result1);
            }

            else if (vacationtype == "adventurous" && groupsize <=2)
            {
                string result1 = ("Since you're a group of " + groupsize + " going on a " + vacationtype + " vacation, you should take first class to whitewater rafting the Grand Canyon.");
                Console.WriteLine(result1);
            }

            else if (vacationtype == "adventurous" && groupsize <= 5)
            {
                string result1 = ("Since you're a group of " + groupsize + " going on a " + vacationtype + " vacation, you should take a helicopter to whitewater rafting the Grand Canyon");
                Console.WriteLine(result1);
            }

            else if (vacationtype == "adventurous" && groupsize >= 6)
            {
                string result1 = ("Since you're a group of " + groupsize + " going on a " + vacationtype + " vacation, you should take a charter flight to whitewater rafting the Grand Canyon.");
                Console.WriteLine(result1);
            }
        }
    }
}
