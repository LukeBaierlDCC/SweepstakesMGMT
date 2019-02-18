using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SweepstakesMGMT
{
    public interface ISweepstakesManager
    {
        void InsertSweepstakes(Sweepstakes sweepstakes);
        Sweepstakes GetSweepstakes();
        
    }
}