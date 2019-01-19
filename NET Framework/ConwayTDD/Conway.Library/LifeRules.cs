using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway.Library
{
    public class LifeRules
    {
        public static CellState GetNextState(CellState currentState, int liveNeighbours)
        {
            CellState nextState = currentState;


            switch (currentState)
            {
                case CellState.Alive:
                    if (liveNeighbours < 2 || liveNeighbours > 3)
                        nextState = CellState.Dead;
                    break;
                case CellState.Dead:
                    if (liveNeighbours == 3)
                        nextState = CellState.Alive;
                    break;
                default:
                    break;
            }


            return nextState;
        }
    }
}
