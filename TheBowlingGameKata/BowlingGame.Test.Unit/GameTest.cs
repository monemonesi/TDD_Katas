using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BowlingGame.Test.Unit
{
    [TestFixture]
    public class GameTest
    {
        private Game game;

        private void RollSpare()
        {
            game.Roll(6);
            game.Roll(4);
        }

        private void RollStrike()
        {
            game.Roll(10);
            game.Roll(0);
        }

        [SetUp]
        public void SetUp()
        {
            game = new Game();
        }

        private void RollConstantPins( int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                game.Roll(pins);
            }
        }

        [TestCase(20,0,0)]
        [TestCase(20,1,20)]
        [TestCase(20,4,80)]
        public void Game_RollingAlwaysTheSamePins_ShouldReturnCorrectScore
            (int rolls, int pins, int expectedScore)
        {
            RollConstantPins(rolls, pins);

            Assert.AreEqual(expectedScore, game.Score());
        }

        [Test]
        public void Game_Spare_ShouldReturnScorePlusBonus()
        {
            //Test spare: (6+4)+(3) = 13 + 3 = 16
            RollSpare();
            game.Roll(3);
            RollConstantPins(17, 0);
            Assert.AreEqual(16, game.Score());
        }

        [Test]
        public void Game_Strike_ShouldReturnDoubleBonus()
        {
            //(10+0)+(5+2)= 17+7=24
            RollStrike();
            game.Roll(5);
            game.Roll(2);
            RollConstantPins(16, 0);
            Assert.AreEqual(24, game.Score());
        }

        [Test]
        public void Game_TestTenthFromSpare()
        {
            RollConstantPins(18, 0);
            RollSpare();//spare in 10th => 1 more ball
            game.Roll(9);

            Assert.AreEqual(19, game.Score());
        }

        [Test]
        public void Game_TestTenthAfterStrike()
        {
            RollConstantPins(18, 0);
            game.Roll(10);//strike in 10th => two more balls
            game.Roll(3);
            game.Roll(5);

            Assert.AreEqual(18, game.Score());
        }

    }
}
