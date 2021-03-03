using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesApplication
{
    class SweepstakesStackManager
    {
        Stack<Sweepstakes> _stack;

        public SweepstakesStackManager()
        {

        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            _stack.Push(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakesPopped = _stack.Pop();
            return sweepstakesPopped;
        }
    }
}
