using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise2
{
    class Person
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string emailAddress;

        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        private DateTime dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
                     
            int Day, Month, Year, age;
            DateTime Now = DateTime.Today;
                    
            public void GetPersonInfo()
            {
                Console.WriteLine("Please Enter your First Name, Last Name, Email Address and Date of Birth: ");
                Console.WriteLine("Please your date of birth should be in this format (yyyy/mm/dd)");
                string details = Console.ReadLine();
                string[] Details = details.Split(' ', ',');
                FirstName = Details[0];
                LastName = Details[1];
                EmailAddress = Details[2];
                string[] Birthday = Details[3].Split('/');
                int Year = int.Parse(Birthday[0]), Month = int.Parse(Birthday[1]), Day = int.Parse(Birthday[2]);
                DateTime Now = DateTime.Today;
                int age = Now.Year - Year;
                DateOfBirth = new DateTime(int.Parse(Birthday[0]), int.Parse(Birthday[1]), int.Parse(Birthday[2]));
                Console.WriteLine(FirstName + " " + LastName + " " + "Your Email Address is: " + EmailAddress + " You were born on: " + DateOfBirth);                                 
                       
                if (age >= 18)
                {
                    Console.WriteLine("You are an adult");
                }
                # region// Output the age of the user with a compliment

                if (Month == Now.Month && Day == Now.Day)
                {
                    Console.WriteLine("Happy Birthday");
                }
                else
                    Console.WriteLine("Today's not your birthday");
                #endregion

                # region // Output the Computed sign to the console


                if ((Month == 1 && Day >= 21) || (Month == 2 && Day <= 19))
                {
                    //Aquarius - January 21 - February 19
                    Console.WriteLine("You are an Aquarius");
                }
                else if ((Month == 2 && Day >= 20) || (Month == 3 && Day <= 20))
                {
                    //Pisces - February 20- March 20
                    Console.WriteLine("You are a Pisces");
                }
                else if ((Month == 3 && Day >= 21) || (Month == 4 && Day <= 20))
                {
                    //Aries - March 21 - April 20
                    Console.WriteLine("You are an Aries");
                }
                else if ((Month == 4 && Day >= 21) || (Month == 5 && Day <= 21))
                {
                    //Taurus - April 21 - May 21
                    Console.WriteLine("You are a Taurus");
                }
                else if ((Month == 5 && Day >= 22) || (Month == 6 && Day <= 21))
                {
                    //Gemini - May 22 - June 21
                    Console.WriteLine("You are a Gemini");
                }
                else if ((Month == 6 && Day >= 22) || (Month == 7 && Day <= 22))
                {
                    //Cancer - June 22 - July 22                
                    Console.WriteLine("You are a Cancer");
                }
                else if ((Month == 7 && Day >= 23) || (Month == 8 && Day <= 21))
                {
                    //Leo - July 23 -August 21
                    Console.WriteLine("You are a Leo");
                }
                else if ((Month == 8 && Day >= 22) || (Month == 9 && Day <= 23))
                {
                    //Virgo - August 22 - September 23
                    Console.WriteLine("You are a Virgo");
                }
                else if ((Month == 9 && Day >= 24) || (Month == 10 && Day <= 23))
                {
                    //Libra - September 24 - October 23
                    Console.WriteLine("You are a Libra");
                }
                else if ((Month == 10 && Day >= 24) || (Month == 11 && Day <= 22))
                {
                    //Scorpio - October 24 - November 22
                    Console.WriteLine("You are a Scorpio");
                }
                else if ((Month == 11 && Day >= 23) || (Month == 12 && Day <= 22))
                {
                    //Sagittarius - November 23 - December 22
                    Console.WriteLine("You are a Sagittarius");
                }
                else if ((Month == 12 && Day >= 23) || (Month == 1 && Day <= 20))
                {
                    //Capricorn - December 23 - January 20
                    Console.WriteLine("You are a Capricorn");
                }
                #endregion    }
            }
    }
}
 