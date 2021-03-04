using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesApplication
{
    public class Sweepstakes
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
            if (_contestants.ContainsKey(contestant.RegistrationNumber))
            {
                Console.WriteLine($"------Contestant Information------\n" +
                    $"Full Name - {_contestants[contestant.RegistrationNumber].FirstName} {_contestants[contestant.RegistrationNumber].LastName}\n" +
                    $"Registration Number - {_contestants[contestant.RegistrationNumber].RegistrationNumber}\n" +
                    $"Email Address - {_contestants[contestant.RegistrationNumber].EmailAddress}\n");
            }
            else
            {
                Console.WriteLine("Contestant not found.");
            }
        }
        public Contestant PickWinner()
        {
            Contestant winningContestant = null; //gets rid of assignment error for return
            Random random = new Random();
            int winningPosition = random.Next(_contestants.Count);
            int currentIndex = 0;

            foreach (KeyValuePair<int, Contestant> keyValuePair in _contestants)
            {
                if (currentIndex == winningPosition)
                {
                    winningContestant = keyValuePair.Value;
                    break;
                }
                currentIndex++;
            }
            NotifyAllContestantsOfWinner(winningContestant);

            return winningContestant;
        }
        public void NotifyAllContestantsOfWinner(Contestant winningContestant)
        {
            foreach (KeyValuePair<int, Contestant> keyValuePair in _contestants)
            {

                keyValuePair.Value.Notify(winningContestant);
                if (keyValuePair.Key == winningContestant.RegistrationNumber)
                {
                     winningContestant.Notify(winningContestant, winningContestant.RegistrationNumber);
                }
            }
        }
    }
}
