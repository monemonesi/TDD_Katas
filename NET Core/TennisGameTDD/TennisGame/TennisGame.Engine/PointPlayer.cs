using System;
using System.Collections.Generic;
using System.Text;

namespace TennisGame.Library
{
    public class PointPlayer : IPointPlayer
    {
        private readonly Random _rnd;

        public PointPlayer(int seed)
        {
            _rnd = new Random(seed);
        }

        public int AssignNextPoint()
        {
            return _rnd.Next(0, 2);
        }

    }
}
