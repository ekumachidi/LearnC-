using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine v4 = new Engine();
            v4.Size = "v4";
            v4.HorsePower = 200;
            v4.FuelConsumptionRate = 1.6;

            Engine v6 = new Engine();
            v6.Size = "v6";
            v6.HorsePower = 350;
            v6.FuelConsumptionRate = 2.6;

            Engine v8 = new Engine();
            v8.Size = "v8";
            v8.HorsePower = 500;
            v8.FuelConsumptionRate = 3.6;

            //Auto myCar = new Auto();
            //myCar.Engine = v6;

            
            AssemblyRobot robot = new AssemblyRobot();
            Auto myCar = robot.AssembleCar("745li", v8);

            Console.WriteLine(myCar.Engine.HorsePower.ToString());

            myCar.Customer.LastName = "Tabor";
            myCar.Customer.Address = "123 E. Main St.";
            myCar.Customer.DateOfPurchase = DateTime.Now;

            Console.WriteLine("Owned by: " + myCar.Customer.LastName);

        }
    }
}
