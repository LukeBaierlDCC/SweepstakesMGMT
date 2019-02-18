using dictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SweepstakesMGMT
{
    public class Sweepstakes
    {
        int RegisterContestant;
        int PickWinner;
        int PrintContestantInfo;
        public ISweepstakesManager ISweepstakesManager
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            
            public string sweepstakesName;
            private Random random;
            private object UserInterface;
            private object contestants;
            int contestantCount;
               
            
            public Sweepstakes(string sweepstakesName)
            {
                this.sweepstakesName = sweepstakesName;
                random = new Random();
                contestantCount = 0;
            }

            public Contestant CreateContestant()
            {
                string firstName = UserInterface.GetFirstName();
                string lastName = UserInterface.GetLastName();
                string emailAddress = UserInterface.GetEmailAddress();
                contestantCount++;

                Contestant contestant = new Contestant(firstName, lastName, emailAddress, contestantCount);
                return contestant;
            }

            private void RegisterContestant(Contestant contestant)
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