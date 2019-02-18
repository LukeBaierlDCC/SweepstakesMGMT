using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SweepstakesMGMT
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<_Sweepstakes> sweepstakesStack = new Stack<_Sweepstakes>();
        public void InsertSweepstakes(_Sweepstakes sweepstakes)
        {
            sweepstakesStack.Push(sweepstakes);
        }

        public _Sweepstakes GetSweepstakes()
        {
            return sweepstakesStack.Pop();
        }

        void ISweepstakesManager.InsertSweepstakes(_Sweepstakes sweepstakes)
        {
            throw new NotImplementedException();
        }

        _Sweepstakes ISweepstakesManager.GetSweepstakes()
        {
            throw new NotImplementedException();
        }

        void ISweepstakesManager.InsertSweepstakes(object p)
        {
            throw new NotImplementedException();
        }
    }
}