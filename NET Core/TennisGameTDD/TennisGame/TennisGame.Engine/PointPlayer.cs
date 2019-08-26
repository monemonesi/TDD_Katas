using System;
using System.Collections.Generic;
using System.Text;

namespace TennisGame.Library
{
    public class PointPlayer : IPointPlayer
    {
        //public int Point { get; private set; }

        private readonly Random _rnd;

        public PointPlayer()
        {
            _rnd = new Random(2);
        }

        public int AssignNextPoint()
        {
            return _rnd.Next(0, 2);
        }

    }
}
