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
        public void CreateMarketingFirmWithManager() //In this method, Dependency Injection is used to take the creation of a SweepstakesManager out of MarketingFirm or Simulation and have its own Factory. This loosens the tight coupling which would've happened.
        {
            ISweepstakesManager manager = SweepstakesManagerFactory.CreateSweepstakesManager();
            MarketingFirm marketingFirm = new MarketingFirm(manager);
        }
    }
}
