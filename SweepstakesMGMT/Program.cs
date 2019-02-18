using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesMGMT
{
    class Program
    {
        private static object GetManagerType;

        static void Main(string[] args)
        {
            SweepstakesStackManager stackManager = new SweepstakesStackManager();
            SweepstakesQueueManager queueManager = new SweepstakesQueueManager();

            Sweepstakes sweepstakes = new Sweepstakes("You may qualify for a $10,000 reward!");
            queueManager.InsertSweepstakes(sweepstakes);
            stackManager.InsertSweepstakes(sweepstakes);
            Console.WriteLine("For your chance to win, please enter and submit your information.");
            Console.ReadLine();
            Contestant contestant = sweepstakes.CreateContestant();
            sweepstakes.RegisterContestant(contestant);
            sweepstakes.CreateContestant();
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(sweepstakes.sweepstakesName);
                Console.WriteLine("Queue Manager: ");
                RunSweepStakes(stackManager);
                Console.WriteLine();
            }
        }
    }
}
