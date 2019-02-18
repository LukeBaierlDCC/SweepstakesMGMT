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
        public ISweepstakesManager ()//ISweepstakesManager
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            public string sweepstakesName;

            private object UserInterface;
            int contestantCount;
            //dictionary.Add();

            //foreach (KeyValuePair<int, string> kvp in dictionary)
            //{
            //    Console.WriteLine(kvp.Key.ToString() + " - " + kvp.Value.ToString());
            //}

            public Sweepstakes(string sweepstakesName)
            {
                this.sweepstakesName = sweepstakesName;
                
                contestantCount = 0;
            }

            public Contestant CreateContestant()
            {
                string firstName = UserInterface.GetFirstName();
                string lastName = UserInterface.GetLastName();
            }

            //void RegisterContestant(Contestant contestant)
            //{

            //}

            //string PickWinner()
            //{

            //}

            //void PrintContestantInfo(Contestant contestant)
            //{

            //}

        }
    }
}