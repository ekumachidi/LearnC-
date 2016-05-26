using System;

namespace Program1
{
    public class Program
    {
        // this is where my program starts
        static void Main(string[] args)
        {
            //prompt user to enter name
            Console.WriteLine(" Enter your name, please:");
            // read the name entered
            var name = Console.ReadLine();
            // greet the user
            Console.WriteLine("Welcome " + name);
            // read users response
            Console.WriteLine("press enter to exit program");
        }
    }
}

