using Darts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeSimpleDarts_Si
{
    public class Turn
    {
        public Dart Dart1;
        public Dart Dart2;
        public Dart Dart3;
        public int TurnScore;
        public int CumulativeTurnScore;
        static Random randomDart = new Random();

        public Turn performTurn(Player player)
        {
            Turn turn = new Turn();
            turn.Dart1 = new Dart(randomDart);
            turn.Dart1.Throw();
            turn.Dart2 = new Dart(randomDart);
            turn.Dart2.Throw();
            turn.Dart3 = new Dart(randomDart);
            turn.Dart3.Throw();
            turn.TurnScore += turn.Dart1.DartScore + turn.Dart2.DartScore + turn.Dart3.DartScore;
            player.PlayerScore += turn.TurnScore;
            return turn;
        }
    }
}