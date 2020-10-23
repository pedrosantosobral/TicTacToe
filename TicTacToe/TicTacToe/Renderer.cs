using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Renderer
    {

        //display board 
        public void DisplayGame(Board board)
        {
            char[,] rendered_states = new char[3, 3];
            //fill the render symbols array with the correct states
            for(int row = 0; row< 3; row++)
            {
                for(int column = 0; column < 3; column++)
                {
                    rendered_states[row, column] = ConvertStatesToRender(board.GetState(new Position(row, column)));
                }
            }
        }

        //get a char to be displayed 
        private char ConvertStatesToRender(State state)
        {
           switch(state)
           {
                case State.O:
                    return 'O';
                case State.X:
                    return 'X';
                default:
                    return ' ';
           }
        }
    }
}
