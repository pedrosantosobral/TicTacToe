using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Renderer
    {
        public static void RequestPosition()
        {
            Console.WriteLine("Please select a position between 1 and 9");
            Console.WriteLine("Ex: 1 - top left corner");
            Console.WriteLine("Ex: 9 - bottom right corner");
        }

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

            Console.WriteLine(rendered_states[0, 0] + " |" + rendered_states[0, 1] + " |" + rendered_states[0, 2]);
            Console.WriteLine("--|--|--");
            Console.WriteLine(rendered_states[1, 0] + " |" + rendered_states[1, 1] + " |" + rendered_states[1, 2]);
            Console.WriteLine("--|--|--");
            Console.WriteLine(rendered_states[2, 0] + " |" + rendered_states[2, 1] + " |" + rendered_states[2, 2]);
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
