using System;
using System.Collections.Generic;
using System.Text;

namespace TennisGame.Library
{
    public class GamePlayer : IGamePlayer
    {
        private IPointPlayer _pointPlayer;
        public Players? GameWinner { get; private set; }
        public int PlayerOneScore { get ; set; }
        public int PlayerTwoScore { get ; set ; }

        public GamePlayer(IPointPlayer playPoint)
        {
            _pointPlayer = playPoint;
            GameWinner = null;
            PlayerOneScore = 0;
            PlayerTwoScore = 0;
        }

        public void PlayGame()
        {
            while(GameWinner == null)
            {
                CheckIfTheGameHasAWinner();
                PlayPoint(); 
            }
        }

        private void PlayPoint()
        {
            if (PlayerOneWinsThePoint())
            {
                PlayerOneScore++;
            }
            else
            {
                PlayerTwoScore++;
            }
        }

        private bool PlayerOneWinsThePoint()
        {
            return _pointPlayer.AssignNextPoint() == 0 ? true : false;
        }

        private void CheckIfTheGameHasAWinner()
        {
            int scoreDiff = Math.Abs(PlayerOneScore - PlayerTwoScore);


            if (PlayerOneScore >= 4 && scoreDiff >= 2)
            {
                GameWinner = Players.player1;
                return;
            }

            if (PlayerTwoScore >= 4 && scoreDiff >= 2)
            {
                GameWinner = Players.player2;
                return;
            }

        }

    }
}
