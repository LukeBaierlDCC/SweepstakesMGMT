using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SweepstakesMGMT
{
    class Contestant : Program
    {
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;

        public Contestant()
        {
            firstName = GetFirstName();
            lastName = GetLastName();
            emailAddress = GetEmailAddress();
            registrationNumber = GetRegistrationNumber();
        }
        public Contestant(string firstName, string lastName, string emailAddress, int contestantCount)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
        }

        private int GetRegistrationNumber()
        {
            throw new NotImplementedException();
        }

        private string GetEmailAddress()
        {
            throw new NotImplementedException();
        }

        private string GetLastName()
        {
            throw new NotImplementedException();
        }

        private string GetFirstName()
        {
            throw new NotImplementedException();
        }

    }
}