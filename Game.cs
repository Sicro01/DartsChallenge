using Darts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ChallengeSimpleDarts_Si
{
    public class Game
    {
            public Player Player1 { get; set; }
            public Player Player2 { get; set; }
            public List<Round> Rounds { get; set; }

            public Game(string player1Name, string player2Name)
            {
                Rounds = new List<Round>();
                Player1 = new Player();
                Player2 = new Player();
                Player1.PlayerName = player1Name;
                Player2.PlayerName = player2Name;
                Round.totalNumberOfRounds = 0;
            }

            public void printGameResult(Game game, Label resultLabel)
            {
                foreach (Round round in game.Rounds)
                {
                    resultLabel.Text += "<br> </br>" + $"Round Number: {round.RoundNumber}" + "<br> </br>";

                    resultLabel.Text += $"Player: {game.Player1.PlayerName} thows....." + "<br> </br>";
                    printPlayer1(game, round, resultLabel);

                    if (round.Turn2 != null)
                    {
                        resultLabel.Text += $"Player: {game.Player2.PlayerName} thows....." + "<br> </br>";
                        printPlayer2(game, round, resultLabel);
                    }
                }
                printFinalResult(game, resultLabel);
            }
            private void printPlayer1(Game game, Round round, Label resultLabel)
            {
                printTurnResult(round.Turn1, resultLabel);
                resultLabel.Text += $"Player: {game.Player1.PlayerName} " + $"has scored {round.Turn1.TurnScore} this round " +
                    $"and has a cumulative score of {round.Turn1.CumulativeTurnScore}" + "<br> </br>";
            }
            private void printPlayer2(Game game, Round round, Label resultLabel)
            {
                printTurnResult(round.Turn2, resultLabel);
                resultLabel.Text += $"Player: {game.Player2.PlayerName} " + $"has a score of {round.Turn2.TurnScore} this round " +
                    $"and has a cumulative score of {round.Turn2.CumulativeTurnScore}" + "<br> </br>";

            }

            private void printTurnResult(Turn turn, Label resultLabel)
            {
                printSingleDartThrowResult(turn.Dart1, resultLabel);
                printSingleDartThrowResult(turn.Dart2, resultLabel);
                printSingleDartThrowResult(turn.Dart3, resultLabel);
            }
            private void printSingleDartThrowResult(Dart dart, Label resultLabel)
            {
                resultLabel.Text +=
                    $"Scores: {dart.DartScore}     :     " +
                    $"(Board Segment: {dart.BoardSegment}     :     " +
                    $"Random Uplift Score: {dart.UpliftScore}     :     " +
                    $"Uplift Description: {dart.ThrowResultDescription})" +
                    "<br> </br>"
                    ;
            }
            private void printFinalResult(Game game, Label resultLabel)
            {
                if (game.Player1.PlayerScore >= 300)
                {
                    resultLabel.Text += "<br> </br>" +
                        $"The winner of the game is {game.Player1.PlayerName} with a score of {game.Player1.PlayerScore}";
                }
                else
                {
                    resultLabel.Text += "<br> </br>" +
                        $"The winner of the game is {game.Player2.PlayerName} with a score of {game.Player2.PlayerScore}";
                }
        }
     }
 }