using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway.Library.Tests
{
    /*
     * Any live cell with fewer than two live neighbours dies, as if caused by under-population.
        
        Any live cell with two or three live neighbours lives on to the next generation.

        Any live cell with more than three live neighbours dies, as if by overcrowding.

        Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.
     */


    [TestFixture]
    public class LifeRulesTests
    {
        [TestCase(0)]
        [TestCase(1)]
        public void LiveCell_LessThan2Neighbours_Die(int liveNeighbours)
        {
            CellState currentState = CellState.Alive;

            CellState nextState = LifeRules.GetNextState(currentState, liveNeighbours);

            Assert.AreEqual(CellState.Dead, nextState);
            
        }

        [TestCase(2)]
        [TestCase(3)]
        public void LiveCell_WithTwoOrThreeNeighbours_Lives(int liveNeighbours)
        {
            CellState currentState = CellState.Alive;

            CellState nextState = LifeRules.GetNextState(currentState, liveNeighbours);

            Assert.AreEqual(CellState.Alive, nextState);
        }

        [Test]
        public void LiveCell_WithMoreThanThreeNeighbours_Dies
            ([Range(4,8)] int liveNeighbours)
        {
            CellState currentState = CellState.Alive;

            CellState nextState = LifeRules.GetNextState(currentState, liveNeighbours);

            Assert.AreEqual(CellState.Dead, nextState);
        }

        [TestCase(3)]
        public void DeadCell_WithThreeNeighbours_Live(int liveNeighbours)
        {
            CellState currentState = CellState.Dead;

            CellState nextState = LifeRules.GetNextState(currentState, liveNeighbours);

            Assert.AreEqual(CellState.Alive, nextState);
        }

        [Test]
        public void DeadCell_WithLessThenThreeNeighbours_Die
            ([Range(0,2)]int liveNeighbours)
        {
            CellState currentState = CellState.Dead;

            CellState nextState = LifeRules.GetNextState(currentState, liveNeighbours);

            Assert.AreEqual(CellState.Dead, nextState);
        }

        [Test]
        public void DeadCell_WithMoreThenThreeNeighbours_Die
            ([Range(4,8)]int liveNeighbours)
        {
            CellState currentState = CellState.Dead;

            CellState nextState = LifeRules.GetNextState(currentState, liveNeighbours);

            Assert.AreEqual(CellState.Dead, nextState);
        }
    }
}
