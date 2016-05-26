using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AverageSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum = 0, Count = 0, avg = 0;
            Console.WriteLine("Enter the values to calculate average seperated by space or ,: ");
            string Values = Console.ReadLine();

            string[] Vals = Values.Split(' ',',');

            foreach (var Value in Vals)
            {
                Sum += int.Parse(Value);
                Count++;
            }
            avg = Sum / Count;
            Console.WriteLine("Average is : " + avg);

        }
    }
}
