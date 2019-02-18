using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SweepstakesMGMT
{
    public interface ISweepstakesManager
    {
        void InsertSweepstakes(_Sweepstakes sweepstakes);
        _Sweepstakes GetSweepstakes();
        void InsertSweepstakes(object p);
    }
}