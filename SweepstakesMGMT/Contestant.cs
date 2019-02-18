using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SweepstakesMGMT
{
    class Contestant : Program
    {
        //first name, last name, email address and registration number

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
    }
}