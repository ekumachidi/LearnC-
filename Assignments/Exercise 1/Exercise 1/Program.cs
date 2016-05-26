using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_1
{

    public class Program
    {
        static void Main(string[] args)
        {

            // Ask user for their birthday
            Console.WriteLine("Please Enter your date of birth in this format (yyyy/mm/dd) : ");
            string Values = Console.ReadLine();
            string[] Birthday = Values.Split('/');

            # region declaration
            int Year, Month, Day;
            Year = int.Parse(Birthday[0]);
            Month = int.Parse(Birthday[1]);
            Day = int.Parse(Birthday[2]);
            #endregion

            # region Get user input
            DateTime Value = new DateTime(int.Parse(Birthday[0]), int.Parse(Birthday[1]), int.Parse(Birthday[2]));
            Console.WriteLine("You were born on : " + Value);
            #endregion

            # region // Calculate age

            DateTime Now = DateTime.Today;
            int age = Now.Year - int.Parse(Birthday[0]);
            #endregion

            # region Check if the age is impossible
            if (age >= 135)
            {
                Console.WriteLine("Invalid age: You should be dead by now!");
            }
            else if (age < 0)
            {
                Console.WriteLine("Please check your Birthday Again");
            }

            else if (age <= 135)
            {
                Console.WriteLine("You are " + age + "Years Old");
            }
            #endregion
            # region// Output the age of the user with a compliment
            if (Month == Now.Month && Day == Now.Day)
            {
                Console.WriteLine("Happy Birthday");
            }
            #endregion
            # region // Output the Computed Western sign to the console


            if ((Month == 1 && Day >= 21) || (Month == 2 && Day <= 19))
            {
                //Aquarius - January 21 - February 19
                Console.WriteLine("Your Western Star sign is Aquarius");
            }
            else if ((Month == 2 && Day >= 20) || (Month == 3 && Day <= 20))
            {
                //Pisces - February 20- March 20
                Console.WriteLine("Your Western Star sign is Pisces");
            }
            else if ((Month == 3 && Day >= 21) || (Month == 4 && Day <= 20))
            {
                //Aries - March 21 - April 20
                Console.WriteLine("Your Western Star sign is Aries");
            }
            else if ((Month == 4 && Day >= 21) || (Month == 5 && Day <= 21))
            {
                //Taurus - April 21 - May 21
                Console.WriteLine("Your Western Star sign is Taurus");
            }
            else if ((Month == 5 && Day >= 22) || (Month == 6 && Day <= 21))
            {
                //Gemini - May 22 - June 21
                Console.WriteLine("Your Western Star sign is Gemini");
            }
            else if ((Month == 6 && Day >= 22) || (Month == 7 && Day <= 22))
            {
                //Cancer - June 22 - July 22                
                Console.WriteLine("Your Western Star sign is Cancer");
            }
            else if ((Month == 7 && Day >= 23) || (Month == 8 && Day <= 21))
            {
                //Leo - July 23 -August 21
                Console.WriteLine("Your Western Star sign is Leo");
            }
            else if ((Month == 8 && Day >= 22) || (Month == 9 && Day <= 23))
            {
                //Virgo - August 22 - September 23
                Console.WriteLine("Your Western Star sign is Virgo");
            }
            else if ((Month == 9 && Day >= 24) || (Month == 10 && Day <= 23))
            {
                //Libra - September 24 - October 23
                Console.WriteLine("Your Western Star sign is Libra");
            }
            else if ((Month == 10 && Day >= 24) || (Month == 11 && Day <= 22))
            {
                //Scorpio - October 24 - November 22
                Console.WriteLine("Your Western Star sign is Scorpio");
            }
            else if ((Month == 11 && Day >= 23) || (Month == 12 && Day <= 22))
            {
                //Sagittarius - November 23 - December 22
                Console.WriteLine("Your Western Star sign is Sagittarius");
            }
            else if ((Month == 12 && Day >= 23) || (Month == 1 && Day <= 20))
            {
                //Capricorn - December 23 - January 20
                Console.WriteLine("Your Western Star sign is Capricorn");
            }
            #endregion
            # region // Output the Computed Western sign to the console

            string message = "Your Chinesse Astrological Sign is: ";

            if ((Day >= 24 && Month ==1 && Year == 1936) || ((Month >= 1 && Year < 1937) && (Month <=2 && Day<10 && Year<=1937)))
            {
                
                Console.WriteLine(message + "Rat");
            }
            else if ((Month == 2 && Day >= 20) || (Month == 3 && Day <= 20))
            {
                //Pisces - February 20- March 20
                Console.WriteLine(message + "Ox");
            }
            else if ((Month == 3 && Day >= 21) || (Month == 4 && Day <= 20))
            {
                //Aries - March 21 - April 20
                Console.WriteLine(message + "Tiger");
            }
            else if ((Month == 4 && Day >= 21) || (Month == 5 && Day <= 21))
            {
                //Taurus - April 21 - May 21
                Console.WriteLine(message + "Rabit");
            }
            else if ((Month == 5 && Day >= 22) || (Month == 6 && Day <= 21))
            {
                //Gemini - May 22 - June 21
                Console.WriteLine(message + "Dragon");
            }
            else if ((Month == 6 && Day >= 22) || (Month == 7 && Day <= 22))
            {
                //Cancer - June 22 - July 22                
                Console.WriteLine(message + "Snake");
            }
            else if ((Month == 7 && Day >= 23) || (Month == 8 && Day <= 21))
            {
                //Leo - July 23 -August 21
                Console.WriteLine(message + "Horse");
            }
            else if ((Month == 8 && Day >= 22) || (Month == 9 && Day <= 23))
            {
                //Leo - July 23 -August 21
                Console.WriteLine(message + "Sheep");
            }
            else if ((Month == 5 && Day >= 22) || (Month == 6 && Day <= 21))
            {
                //Gemini - May 22 - June 21
                Console.WriteLine(message + "Monkey");
            }
            else if ((Month == 6 && Day >= 22) || (Month == 7 && Day <= 22))
            {
                //Cancer - June 22 - July 22                
                Console.WriteLine(message + "Rooster");
            }
            else if ((Month == 7 && Day >= 23) || (Month == 8 && Day <= 21))
            {
                //Leo - July 23 -August 21
                Console.WriteLine(message + "Dog");
            }
            else if ((Month == 8 && Day >= 22) || (Month == 9 && Day <= 23))
            {
                //Leo - July 23 -August 21
                Console.WriteLine(message + "Pig");
            }
            #endregion
        }
    }
    

}
