using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesApplication
{
    public static class SweepstakesManagerFactory
    {
        public static ISweepstakesManager CreateSweepstakesManager()
        {
            string managerType = UserInterface.GetUserInputFor("Type below which manager you would like to create: Stack or Queue?");
            switch (managerType.ToLower())
            {
                case "stack":
                    return new SweepstakesStackManager();
                case "queue":
                    return new SweepstakesQueueManager();
                default:
                    throw new ApplicationException(string.Format("Not a valid Sweepstakes Manager Type"));
            }
        }
    }
}
