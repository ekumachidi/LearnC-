using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Exercise_4
{
    class Employee : Person, IPayable
    
    {
        private string mailingAddress;
        private int salary;

	    public string MailingAddress
	    {
		    get { return mailingAddress;}
		    set { mailingAddress = value;}
	    }
	        
	    public int Salary
	    {
		    get { return salary;}
		    set { salary = value;}
	    }
                
        public void RetrieveAmountDue()
        {
            Console.WriteLine("Please enter your daily wage: ");
            Salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Your Net salary is: " + 30 * salary);
        }
        public void AddAmountDue()
        {            
            int s = 30 * Salary;            
        }
        public void PaymentAddress()
        {
            Console.WriteLine("Please Enter you payment Address: ");
            MailingAddress = Console.ReadLine();                       
        }
    }
 
    interface IPayable
    {
        void RetrieveAmountDue();
        void AddAmountDue();
        void PaymentAddress();
    }
}
