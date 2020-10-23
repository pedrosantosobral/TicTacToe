using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Player
    {
        Position positionToPlay = new Position(0, 0);
        public Position GetPlayerPosition()
        {
            string position = Console.ReadLine();

                if (position == "1")
                {
                    positionToPlay.Row = 1;
                    positionToPlay.Column = 1;
                    return positionToPlay;
                }
                else if (position == "2")
                {
                    positionToPlay.Row = 1;
                    positionToPlay.Column = 2;
                    return positionToPlay;
                }
                else if (position == "3")
                {
                    positionToPlay.Row = 1;
                    positionToPlay.Column = 3;
                    return positionToPlay;
                }
                else if (position == "4")
                {
                    positionToPlay.Row = 2;
                    positionToPlay.Column = 1;
                    return positionToPlay;
                }
                else if (position == "5")
                {
                    positionToPlay.Row = 2;
                    positionToPlay.Column = 2;
                    return positionToPlay;
                }
                else if (position == "6")
                {
                    positionToPlay.Row = 2;
                    positionToPlay.Column = 3;
                    return positionToPlay;
                }
                else if (position == "7")
                {
                    positionToPlay.Row = 3;
                    positionToPlay.Column = 1;
                    return positionToPlay;
                }
                else if (position == "8")
                {
                    positionToPlay.Row = 3;
                    positionToPlay.Column = 2;
                    return positionToPlay;
                }
                else if (position == "9")
                {
                    positionToPlay.Row = 3;
                    positionToPlay.Column = 3;
                    return positionToPlay;
                }
                else
                {
                    Renderer.RequestPosition();
                    GetPlayerPosition();
                }

            return positionToPlay;
        }
       /* public Position GetPosition(Board currentState)
        {

            Console.ReadKey();
            return new Position pos
        }
       */
    }
}
