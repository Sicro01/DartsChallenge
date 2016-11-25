using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeSimpleDarts_Si
{
    public class Round
    {
        public Turn Turn1 { get; set; }
        public Turn Turn2 { get; set; }
        public int RoundNumber { get; set; }

        public static int totalNumberOfRounds = 0;
        public Round()
        {
            RoundNumber = totalNumberOfRounds;
            totalNumberOfRounds++;
            Turn1 = new Turn();
            Turn2 = new Turn();
        }
        public static int GetNumberOfRounds()
        {
            return totalNumberOfRounds;
        }
    }
}