using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SweepstakesMGMT
{
    public static class UserInterface
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

        public static string GetManagerType()
        {
            string managerType = GetUserInput("");
            return managerType;
        }

        private static string GetUserInput(string v)
        {
            throw new NotImplementedException();
        }

        //public static CreateSweepstakes()
        //{
        //    _Sweepstakes newSweepstakes = new _Sweepstakes();
        //    return newSweepstakes;
        //}

        //public static string DetermineMarketingFirmAction()
        //{
        //    userInput = GetUserInput("");
        //    return userInput;
        //}
    }
}