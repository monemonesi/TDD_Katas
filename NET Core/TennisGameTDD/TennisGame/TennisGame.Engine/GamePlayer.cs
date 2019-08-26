using System;
using System.Collections.Generic;
using System.Text;

namespace TennisGame.Library
{
    public class GamePlayer : IGamePlayer
    {
        private IPointPlayer _pointPlayer;
        private int _playerOneScore, _playerTwoScore;
        public Players? GameWinner { get; private set; }

        public GamePlayer(IPointPlayer playPoint)
        {
            _pointPlayer = playPoint;
            GameWinner = null;
        }

        public void PlayGame()
        {
            while(GameWinner == null)
            {
                PlayPoint();
                
                CheckIfTheGameHasAWinner();
            }
        }

        private void PlayPoint()
        {
            int point = _pointPlayer.AssignNextPoint();
            if (point == 0)
            {
                _playerOneScore++;
            }
            else
            {
                _playerTwoScore++;
            }
        }

        private void CheckIfTheGameHasAWinner()
        {
            int scoreDiff = Math.Abs(_playerOneScore - _playerTwoScore);
            if(_playerOneScore >= 4 && scoreDiff >= 2)
            {
                GameWinner = Players.player1;
            }

            if(_playerTwoScore >=4 && scoreDiff >= 2)
            {
                GameWinner = Players.player2;
            }

        }
    }
}
