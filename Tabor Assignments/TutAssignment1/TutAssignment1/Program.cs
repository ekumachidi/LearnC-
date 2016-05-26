using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TutAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = "";
            Console.WriteLine("Type in a sequence of numbers recorded from hourly readings and Press Enter..");
            number = Console.ReadLine();
            Console.WriteLine("Data Capture successful..........");
            if (number == "1")
            {
                Console.WriteLine("Incorrect number format");
                Console.Beep();
            }
        }
    }
}
