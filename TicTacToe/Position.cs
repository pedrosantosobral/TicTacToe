using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Position
    {
        public int Column { get; set; }
        public int Row    { get; set; }

        public Position(int Column, int Row)
        {
            this.Column = Column;
            this.Row    = Row;
        }
    }
}
