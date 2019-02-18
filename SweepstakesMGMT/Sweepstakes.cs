using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SweepstakesMGMT
{
    public class _Sweepstakes
    {
        //int RegisterContestant;
        //int PickWinner;
        //int PrintContestantInfo;
        
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
            
        public string sweepstakesName;
        Random random;
        public object Userinterface;
        //int contestants;
        int contestantCount;

        public _Sweepstakes(string sweepstakesName)
        {
            this.sweepstakesName = sweepstakesName;
            random = new Random();
            contestantCount = 0;
        }

        public Contestant CreateContestant()
        {
            string firstName = Userinterface.GetFirstName();
            string lastName = Userinterface.GetLastName();
            string emailAddress = Userinterface.GetEmailAddress();
            contestantCount++;

            Contestant contestant = new Contestant(firstName, lastName, emailAddress, contestantCount);
            return contestant;
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.registrationNumber, contestant);
        }

        public string PickWinner()
        {
            int winningContestant = random.Next(1, contestantCount);
            Contestant contestant;
            contestants.TryGetValue(winningContestant, out contestant);
            return $"{contestant.firstName} {contestant.lastName}";
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            foreach (KeyValuePair<int, Contestant> pair in contestants)
            {
                Console.WriteLine(pair.Key + "" + pair.Value);
            }
        }
    }
}