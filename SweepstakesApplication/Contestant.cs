using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesApplication
{
    public class Contestant : IContestant
    {
        private string firstName, lastName;
        public string EmailAddress;
        public int RegistrationNumber;

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }
        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }
        

        public Contestant()
        {

        }


        public void Notify(IContestant contestant)
        {
            Console.Write($"Contestant {contestant.FirstName} {contestant.LastName} won the Sweepstakes!\n");
        }
    }
}
