using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesApplication
{
    class Sweepstakes
    {
        private Dictionary<int, Contestant> _contestants;
        private string _name;
        public string Name
        {
            get => _name;
        }

        public Sweepstakes()
        {

        }
    }
}
