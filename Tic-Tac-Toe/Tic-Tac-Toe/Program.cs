using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            int turn;
            char player = 'X';
            Game.Init();
            do
            {
                CLI.PrintBoard();
                Console.Write("Ваш ход на ");
                turn = Convert.ToInt32(Console.ReadLine());
                if (Game.CheckMove(turn - 1))
                {
                    Board.board[turn - 1] = player;
                    CLI.PrintBoard();
                }
                    Game.ChangeOfTurn(ref player);
            } while (!Game.CheckEnd(player));
        }
    }
}
