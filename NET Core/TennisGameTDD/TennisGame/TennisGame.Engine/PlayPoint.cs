using System;
using System.Collections.Generic;
using System.Text;

namespace TennisGame.Engine
{
    public class PlayPoint : IPlayPoint
    {
        public int Point { get; private set; }

        private readonly Random _rnd;

        public PlayPoint()
        {
            _rnd = new Random(2);
        }

        public int AssignNextPoint()
        {
            return _rnd.Next(0, 2);
        }

    }
}
