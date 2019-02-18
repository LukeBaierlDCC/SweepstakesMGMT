using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SweepstakesMGMT
{
    public interface UserInterface
    {

        public static string GetFirstName()
        {
            Console.WriteLine("Enter the contestant's first name here: ");
            return Console.ReadLine();
        }

        public static string GetLastName()
        {
            Console.WriteLine("Enter the contestant's last name here: ");
            return Console.ReadLine();
        }

        public static string GetEmailAddress()
        {
            Console.WriteLine("Enter the contestant's email address here: ");
            return Console.ReadLine();
        }

        public static string GetRegistrationNumber()
        {
            Console.WriteLine("Enter the contestant's registration number here: ");
            return Console.ReadLine();
        }
    }
}