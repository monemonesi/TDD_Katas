using System;
using Moq;
using NUnit.Framework;
using TennisGame.Library;

namespace Tests
{
    public class GamePlayerTests
    {
        Mock<IPointPlayer> _pointPlayerMock;
        IGamePlayer _gamePlayer;

        [OneTimeSetUp]
        public void Setup()
        {
            _pointPlayerMock = new Mock<IPointPlayer>();
        }

        [Test]
        public void WhenPlayerOneGetAllPointsWinsTheGame()
        {
            GivenPlayerOneWinningAllPoints();
            WhenTheGameIsPlayed();
            ThenThePlayerWhoWinsTheGameIs(Players.player1);
        }

        [Test]
        public void WhenPlayerTwoGetAllPointsWinsTheGame()
        {
            GivenPlayerTwoWinningAllPoints();
            WhenTheGameIsPlayed();
            ThenThePlayerWhoWinsTheGameIs(Players.player2);
        }

        //[TestCase(4, 0, Players.player1)]
        //[TestCase(6, 4, Players.player1)]
        //[TestCase(3, 5, Players.player2)]
        //public void AssignGameShouldReturnTheCorrectWinner(int playerOneScore, int playerTwoScore, Players expectedWinner)
        //{
        //    GivenTheResultOf(playerOneScore, playerTwoScore);
        //    WhenTheGameIsEvaluated();
        //    ThenTheCorrectPlayerWin();
        //}

        //private void GivenTheResultOf(int playerOneScore, int playerTwoScore)
        //{
        //    //_playPointMock.SetupSequence(p => p.AssignNextPoint())
        //    //    .Returns()
        //    _gamePlayer.
        //}

        private void ThenThePlayerWhoWinsTheGameIs(Players expectedWinner)
        {
            Assert.AreEqual(expectedWinner, _gamePlayer.GameWinner);
        }

        private void WhenTheGameIsPlayed()
        {
            _gamePlayer.PlayGame();
        }

        private void GivenPlayerOneWinningAllPoints()
        {
            _pointPlayerMock.Setup(pp => pp.AssignNextPoint()).Returns(0);
            _gamePlayer = new GamePlayer(_pointPlayerMock.Object);
        }

        private void GivenPlayerTwoWinningAllPoints()
        {
            _pointPlayerMock.Setup(pp => pp.AssignNextPoint()).Returns(1);
            _gamePlayer = new GamePlayer(_pointPlayerMock.Object);
        }
    }
}