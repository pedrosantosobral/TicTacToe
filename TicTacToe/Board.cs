using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Board
    {
        private State[,] board_states;
        private State NextTurn { get; set; }


        public Board()
        {
            //create new board
            board_states = new State[3, 3];
            //set player round
            NextTurn = State.X;

            //initialize all positions as undecided
            for (int row = 0; row < board_states.GetLength(0); row++)
            {
                for (int col = 0; col < board_states.GetLength(1); col++)
                {
                    board_states[row, col] = State.Undecided;
                }
            }
        }

        public void ChangeTurn()
        {
            if (NextTurn == State.X)
            {
                NextTurn = State.O;
            }
            else
            {
                NextTurn = State.X;
            }

        }

        public State GetState(Position pos)
        {
            return board_states[pos.Row,pos.Column];
        }

        //Set new state and change turn
        public bool SetState(State newState, Position pos)
        {
            if (newState != NextTurn) return false;
            if (newState != State.Undecided) return false;

            board_states[pos.Row, pos.Column] = newState;
            SwitchState();
            return true;
            
        }

        public void SwitchState()
        {
            if(NextTurn == State.O)
            {
                NextTurn = State.X;
            }
            else
            {
                NextTurn = State.O;
            }
        }



    }
}
