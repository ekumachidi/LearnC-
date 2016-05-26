using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_2
{
    class Age
    {
        #region Private Declarations
        private int day;
        private int month;
        private int year;
        string[] DateOfBirth;
        DateTime Now = DateTime.Today;
        string message = "Your Chinesse Astrological ";
        int n, i, e, a;
        #endregion

        //#region Public properties
        //public DateTime Day
        //{
        //    get { return day; }
        //    set { day = value; }
        //}
                
        //public DateTime Month
        //{
        //    get { return month; }
        //    set { month = value; }
        //}
              
        //public DateTime Year
        //{
        //    get { return year; }
        //    set { year = value; }
        //}
        //#endregion

        public DateTime GetUserAge()
        {
            Console.WriteLine("Please Enter your date of birth in this format (yyyy/mm/dd) : ");
            string Values = Console.ReadLine();
            string[] DateOfBirth = Values.Split('/');            
            DateTime details = new DateTime(int.Parse(DateOfBirth[0]), int.Parse(DateOfBirth[1]), int.Parse(DateOfBirth[2]));        
            Console.Write("You were born on: " + details);
            return details;
            year = int.Parse(DateOfBirth[0]); month = int.Parse(DateOfBirth[1]); day = int.Parse(DateOfBirth[2]);          
        }
        

        public string VerifyAge()
        {
            string message;         
            int age = Now.Year - int.Parse(DateOfBirth[0]);
            message = "You are and Adult";
            return message;
        }
        public void WesternSign()
        {
            if ((month == 1 && day >= 21) || (month == 2 && day <= 19))
            {               
                Console.WriteLine("Your Western Star sign is Aquarius");
            }
            else if ((month == 2 && day >= 20) || (month == 3 && day <= 20))
            {
                Console.WriteLine("Your Western Star sign is Pisces");
            }
            else if ((month == 3 && day >= 21) || (month == 4 && day <= 20))
            {
                Console.WriteLine("Your Western Star sign is Aries");
            }
            else if ((month == 4 && day >= 21) || (month == 5 && day <= 21))
            {
                Console.WriteLine("Your Western Star sign is Taurus");
            }
            else if ((month == 5 && day >= 22) || (month == 6 && day <= 21))
            {
                Console.WriteLine("Your Western Star sign is Gemini");
            }
            else if ((month == 6 && day >= 22) || (month == 7 && day <= 22))
            {
                Console.WriteLine("Your Western Star sign is Cancer");
            }
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 21))
            {
                Console.WriteLine("Your Western Star sign is Leo");
            }
            else if ((month == 8 && day >= 22) || (month == 9 && day <= 23))
            {
                Console.WriteLine("Your Western Star sign is Virgo");
            }
            else if ((month == 9 && day >= 24) || (month == 10 && day <= 23))
            {
                Console.WriteLine("Your Western Star sign is Libra");
            }
            else if ((month == 10 && day >= 24) || (month == 11 && day <= 22))
            {
                Console.WriteLine("Your Western Star sign is Scorpio");
            }
            else if ((month == 11 && day >= 23) || (month == 12 && day <= 22))
            {
                Console.WriteLine("Your Western Star sign is Sagittarius");
            }
            else if ((month == 12 && day >= 23) || (month == 1 && day <= 20))
            {
                Console.WriteLine("Your Western Star sign is Capricorn");
            }
        }
        public void ChinesseSign()
        {
            n = int.Parse(DateOfBirth[0]);
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
            string[] ElementName = { "Wood", "Fire", "Earth", "Metal", "Water" };
            string[] AnimalName = { "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Sheep", "Monkey", "Rooster", "Dog", "Pig" };
            Console.WriteLine(message + "Element is: " + ElementName[e]);
            Console.WriteLine(message + "Animal is: " + AnimalName[a]);
        }
        public void BirthdayMessage()
        {
            if (month == Now.Month && int.Parse(DateOfBirth[2]) == Now.Day)
            {
                Console.WriteLine("Happy Birthday");
            }
        }
    }
}
