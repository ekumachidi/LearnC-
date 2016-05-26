using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Day2Hmwrk_ReadinTxtFile
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StreamReader myReader = new StreamReader("Decode this.txt");
            string line = "";

            StreamWriter myWriter = new StreamWriter("Write this.txt");

            Console.WriteLine(".....Starting");

            while (line != null)
            {
                line = myReader.ReadLine();
                if (line != null)
                {
                    char[] charArray = line.ToCharArray();
                    Array.Reverse(charArray);
                    //Console.WriteLine(charArray);
                    myWriter.WriteLine(charArray);
                }
            }
            myReader.Close();
            myWriter.Close();

            Console.WriteLine("......Finished");
            Console.ReadLine();
        }
    }
}
