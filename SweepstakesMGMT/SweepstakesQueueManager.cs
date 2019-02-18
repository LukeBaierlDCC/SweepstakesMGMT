using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SweepstakesMGMT
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<_Sweepstakes> sweepstakesQueue = new Queue<_Sweepstakes>();

        public void InsertSweepstakes(_Sweepstakes sweepstakes)
        {
            sweepstakesQueue.Enqueue(sweepstakes);
        }

        public _Sweepstakes GetSweepstakes()
        {
            _Sweepstakes sweepstakesQueueStart = sweepstakesQueue.Dequeue();
            return sweepstakesQueue.Dequeue();
        }
        _Sweepstakes ISweepstakesManager.GetSweepstakes()
        {
            throw new NotImplementedException();
        }

        void ISweepstakesManager.InsertSweepstakes(_Sweepstakes sweepstakes)
        {
            throw new NotImplementedException();
        }

        void ISweepstakesManager.InsertSweepstakes(object p)
        {
            throw new NotImplementedException();
        }
    }
}