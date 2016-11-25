using Darts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleDarts_Si
{
    public partial class Default : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            ShallWePlayAGame();
        }
        public void ShallWePlayAGame()
        {
            Game game = new Game("Simon", "Bob");
            resultLabel.Text = "";

            game = playGame(game);
            game.printGameResult(game, resultLabel);
        }

        private Game playGame(Game game)
        {
            while (game.Player1.PlayerScore <= 300 && game.Player2.PlayerScore <= 300)
            {
                Round round = new Round();
                round.Turn1 = round.Turn1.performTurn(game.Player1);
                round.Turn1.CumulativeTurnScore = game.Player1.PlayerScore;
                if (game.Player1.PlayerScore >= 300)
                {
                    round.Turn2 = null;
                    game.Rounds.Add(round);
                    break;
                }
                round.Turn2 = round.Turn2.performTurn(game.Player2);
                round.Turn2.CumulativeTurnScore = game.Player2.PlayerScore;

                game.Rounds.Add(round);
            }
            return game;
        }
    }
}