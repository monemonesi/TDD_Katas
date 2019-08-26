using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TennisGame.Engine;
using TennisGame.Library;

namespace TennisGame.Tests
{
    public class PlayGameTests
    {
        Mock<IPlayPoint> _playPointMock;
        IPlayGame _playGame;

        [OneTimeSetUp]
        public void Setup()
        {
            _playPointMock = new Mock<IPlayPoint>();
            _playGame = new PlayGame();
        }

        [Test]
        public void WhenPlayerOneGetAllPointsWinsTheGame()
        {
            Given4To0ForPlayerOne();
            WhenTheGameIsEvaluated();
            ThenPlayerOneWinTheGame();
        }

        private void ThenPlayerOneWinTheGame()
        {
            Assert.AreEqual(Players.player1, _playGame.Winner);
        }

        private void WhenTheGameIsEvaluated()
        {
            _playGame.AssignGame();
        }

        private void Given4To0ForPlayerOne()
        {
            _playPointMock.Setup(pp => pp.AssignNextPoint()).Returns(0);
        }
    }
}
