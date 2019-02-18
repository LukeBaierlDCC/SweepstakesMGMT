using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SweepstakesMGMT
{
    public interface UserInterface
    {

        string UserInterface.GetFirstName()
        {
            Console.WriteLine("Enter the contestant's first name here: ");
            return Console.ReadLine();
        }

        string GetLastName()
        {
            Console.WriteLine("Enter the contestant's last name here: ");
            return Console.ReadLine();
        }

        string GetEmailAddress()
        {
            Console.WriteLine("Enter the contestant's email address here: ");
            return Console.ReadLine();
        }

        string GetRegistrationNumber()
        {
            Console.WriteLine("Enter the contestant's registration number here: ");
            return Console.ReadLine();
        }

        string GetManagerType()
        {
            string managerType = GetUserInput("");
            return managerType;
        }

        Sweepstakes CreateSweepstakes()
        {
            Sweepstakes newSweepstakes = new Sweepstakes();
            return newSweepstakes;
        }

        string DetermineMarketingFirmAction()
        {
            userInput = GetUserInput("");
            return userInput;
        }
    }
}