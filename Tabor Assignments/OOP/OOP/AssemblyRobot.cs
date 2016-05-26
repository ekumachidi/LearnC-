using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class AssemblyRobot
    {
        public Auto AssembleCar(string model, Engine engineType)
        {
            Auto newCar = new Auto();
            newCar.Model = model;
            newCar.Engine = engineType;
            return newCar;
        
        }
    }
}
