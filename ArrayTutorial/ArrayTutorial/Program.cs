using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; ++i)
            {
                Console.WriteLine(numbers[i].ToString());
            }
            string myText = "Now Is The Time For All Men";
            char[] charArray=myText.ToCharArray();
            Console.WriteLine(charArray);
            Console.ReadLine();
            
        }
    }
}
