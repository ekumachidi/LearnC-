using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AverageCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum=0;
            float Average;
            string cont;

            do
            {
                // Read the number of values the user intends to enter
                Console.Write("Enter the number of values you want to average: ");
                int numElements = int.Parse(Console.ReadLine());

                // Declare an Array of that size
                int[] intArray = new int[numElements];

                // Build an Array that size
                for (int i = 0; i < intArray.Length; i++)
                {
                    //Prompt user to enter values
                    Console.WriteLine("Please enter value#" + i + 1 + ": ");
                    int value = int.Parse(Console.ReadLine());

                    //Add this number to the Array
                    intArray[i] = value;
                }
                // Sum up all the elements of the Array
                for (int i = 0; i < intArray.Length; i++)
                {
                   Sum += intArray[i];
                }
                // Calculate the Average
                Average = Sum / numElements;
                Console.WriteLine("The Average is: " + Average);
                
                // Repeat process
                Console.WriteLine("Do you wis to continue? (y/n");
                cont=Console.ReadLine();
            } while (cont == "y");
            
        }
    }
}
