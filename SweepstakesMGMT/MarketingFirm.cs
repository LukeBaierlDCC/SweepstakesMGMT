using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SweepstakesMGMT
{
    public class MarketingFirm
    {
        //Implement dependency injection to utilize sweepstakes manager.
        ISweepstakesManager sweepstakesManager;

        public MarketingFirm(ISweepstakesManager sweepstakesManager)
        {
            this.sweepstakesManager = sweepstakesManager;
        }

        public _Sweepstakes GetSweepstakes()
        {
            return sweepstakesManager.GetSweepstakes();
        }

        public void InsertSweepstakes()
        {
            sweepstakesManager.InsertSweepstakes(CreateSweepstakes());
        }

        private _Sweepstakes CreateSweepstakes()
        {
            throw new NotImplementedException();
        }

        public void DetermineMarketFirmAction()
        {
            while (true)
            {
                switch (DetermineMarketingFirmAction())
                {
                    case "1":
                        GetSweepstakes();
                        break;
                    case "2":
                        InsertSweepstakes();
                        break;
                    case "3":
                        return;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        DetermineMarketFirmAction();
                        break;
                }
            }
        }

        private string DetermineMarketingFirmAction()
        {
            throw new NotImplementedException();
        }
    }
}