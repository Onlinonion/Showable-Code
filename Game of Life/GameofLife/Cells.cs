using System;
using System.Collections.Generic;
using System.Text;

namespace GameofLife
{
    class Cells
    {
        public bool _isAlive;
        public bool _nextState;

        public Cells(bool state)
        {
            _isAlive = state;
        }

        public void ComeAlive()
        {
            _nextState = true;
        }

        public void PassAway()
        {
            _nextState = false;
        }

        public void Update()
        {
            _isAlive = _nextState;
        }
    }
}
