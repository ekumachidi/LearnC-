using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person P1 = new Person();
            Age n = new Age();

            P1.GetPersonInfo();
            
            P1.DisplayPersonInfo();            
            n.WesternSign();
            n.ChinesseSign();
            n.BirthdayMessage();
            Console.ReadLine();
        }
    }
}
