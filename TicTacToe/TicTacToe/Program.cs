using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Board board = new Board();
            Renderer render = new Renderer();
            Player player1 = new Player();
            Player player2 = new Player();

            render.DisplayGame(board);
            Renderer.RequestPosition();
        }
    }
}
