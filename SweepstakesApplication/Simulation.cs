using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesApplication
{
    class Simulation
    {


        public Simulation()
        {

        }
        public void CreateMarketingFirmWithManager()
        {
            ISweepstakesManager manager = SweepstakesManagerFactory.CreateSweepstakesManager();
            MarketingFirm marketingFirm = new MarketingFirm(manager);
        }
    }
}
