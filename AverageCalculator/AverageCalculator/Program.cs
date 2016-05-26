using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AverageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            # region declaration             

            float Average;
            int x;
            int Sum = 0;
            int userValue;

            #endregion
            
            // Read x numbers from users
            Console.WriteLine("Please Enter the number of items to Calculate average");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the numbers");
            Console.WriteLine("Please press enter after each number");
            int[] numbersArray = { int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())};//new int[x]

             do
            {
              userValue = int.Parse(Console.ReadLine());
            } 
             while (userValue<x);
            
            
            // sum numbers
            for (int i = 0; i < numbersArray.Length; i++)
            {
                Sum += numbersArray[i];
                            }
            //calculate the average
            Average = Sum / numbersArray.Length;
            Console.WriteLine("The Average is: "+ Average);
            Console.ReadLine();
        }

        private static void userValue()
        {
            int userValue = int.Parse(Console.ReadLine());
        }
    }
}
