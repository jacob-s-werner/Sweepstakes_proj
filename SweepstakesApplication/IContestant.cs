using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesApplication
{
    public interface IContestant
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        void Notify(IContestant contestant);
    }
}
