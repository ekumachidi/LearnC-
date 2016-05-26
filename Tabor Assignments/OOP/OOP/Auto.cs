using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class Auto
    {
        public string Manufacturer;
        public string Model;
        public int Year;
        public string Colour;
        public int Miles;
        public int Speed;
        public Engine Engine;
        
        public AutoCustomer Customer = new AutoCustomer();
        
        public int CurrentSpeed
        {
            get { return Speed;}
            set
            {
            if (value < 0)
                Speed = 0;
            else if (value > 0)
                Speed = 110;
            else
                Speed = value;
            }
        }

        public int Accelerate(int  increasedSpeed)
        {
            Speed += increasedSpeed;
            //Console.WriteLine("Current Speed: "+ Speed.ToString());
            writeLine("Current speed: " + CurrentSpeed);
            return CurrentSpeed;
        }
        
        public int Decelerate(int decreasedSpeed)
        {
            Speed -= decreasedSpeed;
            //Console.WriteLine("Current Speed: " + Speed.ToString());
            writeLine("Current speed: " + CurrentSpeed);
            return CurrentSpeed;
        }
        private void writeLine(string message)
        {
            Console.Write("From my helper method...");
            Console.WriteLine(message);
        }
    }
}
