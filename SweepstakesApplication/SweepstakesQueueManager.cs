using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesApplication
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> _queue;

        public SweepstakesQueueManager()
        {

        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            _queue.Enqueue(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakesDequeued = _queue.Dequeue();
            return sweepstakesDequeued;
        }
    }
}
