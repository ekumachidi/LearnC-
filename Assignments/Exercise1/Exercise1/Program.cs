﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region // Ask user for their birthday
            Console.WriteLine("Please Enter your date of birth in this format (yyyy/mm/dd) : ");
            string Values = Console.ReadLine();
            string[] Birthday = Values.Split('/');
            #endregion

            # region declaration
            int Year, Month, Day;
            Year = int.Parse(Birthday[0]);
            Month = int.Parse(Birthday[1]);
            Day = int.Parse(Birthday[2]);
            string message = "Your Chinesse Astrological ";
            int n,i, e, a;
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
                Console.Beep();
            }
            else if (age < 0)
            {
                Console.WriteLine("Please check your Birthday Again");
                Console.Beep();
            }

            else if (age <= 135)
            {
                Console.WriteLine("You are " + age + "Years Old");
            }
            #endregion

            if (age > 0)            
            {
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

                #region Compute Chinesse Star Sign
                n = Year % 2;
                if (n == 0)
                {
                    i = (n + 6 % 10);
                }
                else
                {
                    i = (n + 6 % 10) - 1;
                }

                e = i / 2;

                a = (n + 8 % 12);

                #endregion

                #region Output Computed Chinesse Sign

                string[] ElementName = { "Wood", "Fire", "Earth", "Metal", "Water" };
                string[] AnimalName = { "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Sheep", "Monkey", "Rooster", "Dog", "Pig" };
                Console.WriteLine(message + "Element is: " + ElementName[e]);
                Console.WriteLine(message + "Animal is: " + AnimalName[a]);

                #endregion
                
            }
           
        }
    }
}
