using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SweepstakesMGMT
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> sweepstakesQueue = new Queue<Sweepstakes>();

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesQueue.Enqueue(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            return sweepstakesQueue.Dequeue();
        }
        Sweepstakes ISweepstakesManager.GetSweepstakes()
        {
            throw new NotImplementedException();
        }

        void ISweepstakesManager.InsertSweepstakes(Sweepstakes sweepstakes)
        {
            throw new NotImplementedException();
        }

        void ISweepstakesManager.InsertSweepstakes(object p)
        {
            throw new NotImplementedException();
        }
    }
}