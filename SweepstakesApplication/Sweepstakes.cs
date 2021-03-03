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

        public Sweepstakes(string name)
        {
            _name = name;
        }
        public void RegisterContestant(Contestant contestant)
        {
            _contestants.Add(contestant.RegistrationNumber,contestant);
        }
        public void PrintContestantInfo(Contestant contestant)
        {

        }
        public Contestant PickWinner()
        {

        }
    }
}
