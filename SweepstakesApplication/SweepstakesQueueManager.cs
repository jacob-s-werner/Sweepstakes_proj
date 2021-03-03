using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesApplication
{
    class SweepstakesQueueManager
    {
        Queue<Sweepstakes> _queue;

        public SweepstakesQueueManager()
        {

        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            _queue.Enqueue(sweepstakes);
        }
    }
}
