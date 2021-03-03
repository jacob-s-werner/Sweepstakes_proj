using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesApplication
{
    class MarketingFirm
    {
        private ISweepstakesManager _manager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            _manager = manager;
        }
        public void CreateSweepstake()
        {
            string name = UserInterface.GetUserInputFor("What is the name of your new Sweepstakes?");
           
            Sweepstakes sweepstakes = new Sweepstakes(name);
            _manager.InsertSweepstakes(sweepstakes);

            Console.WriteLine($"Your sweepstakes {name} has been created and added to the manager!");
        }
    }
}
