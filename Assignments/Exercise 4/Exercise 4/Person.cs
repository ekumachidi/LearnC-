using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_4
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

        private Age dateOfBirth;

        public Age DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        
        public void GetPersonInfo()
        {
            Console.WriteLine("Please Enter your First Name, Last Name and Email Address: ");
            string details = Console.ReadLine();
            string[] Details = details.Split(' ', ',');
            FirstName = Details[0];
            
            LastName = Details[1];
            EmailAddress = Details[2];
            DateOfBirth = new Age();
            Console.WriteLine(DateOfBirth.GetUserAge());            
        }
        //public void ScreenName()
        //{
        //    Console.WriteLine("Would you want to create a screen name? (y/n)");
        //    string response = Console.ReadLine();
        //    if (response == "y")
        //    {
        //        string name;
        //        Console.WriteLine("Please enter your new screen name");
        //        name = Console.ReadLine();
        //        //Screen name - a default screen name that you might see being offered to a first time user of AOL or Yahoo 
        //        //(e.g. John Doe born on Feburary 25th, 1980 might be jdoe225 or johndoe022580)                
        //    }
        //    else
        //    {
        //        Console.WriteLine("Welcome" + firstName+);
        //    }
            
            
        //}
        public void DisplayPersonInfo()
        {
            Console.WriteLine("Welcome" + FirstName + " " + LastName + " " + "Your Email Address is: " + EmailAddress);                
        }

    }
}
