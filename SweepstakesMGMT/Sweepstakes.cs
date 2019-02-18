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
            //dictionary.Add();

            foreach (KeyValuePair<int, string> kvp in dictionary)
            {
                Console.WriteLine(kvp.Key.ToString() + " - " + kvp.Value.ToString());
            }

            //Sweepstakes(string name) 
            //{

            //}

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