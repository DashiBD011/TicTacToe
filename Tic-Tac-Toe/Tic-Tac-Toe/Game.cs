using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    public class Game
    {
        public static void Init()
        {
            Board.Status = StatusType.Game;
        }

        public static bool CheckMove(int position)
        {
            return Board.board[position] == ' ';
        }

        public static bool CheckEnd(char player)
        {
            bool drawn_game = true;
            for (int i = 0; i < 9; i++)
            {
                if (Board.board[i] == ' ') drawn_game = false;
            }
            if (Board.board[0] == Board.board[4] && Board.board[4] == Board.board[8] && Board.board[0] != ' ' ||
                Board.board[0] == Board.board[1] && Board.board[1] == Board.board[2] && Board.board[0] != ' ' ||
                Board.board[0] == Board.board[3] && Board.board[3] == Board.board[6] && Board.board[0] != ' ' ||
                Board.board[2] == Board.board[4] && Board.board[4] == Board.board[6] && Board.board[2] != ' ' ||
                Board.board[2] == Board.board[5] && Board.board[5] == Board.board[8] && Board.board[2] != ' ' ||
                Board.board[4] == Board.board[3] && Board.board[3] == Board.board[5] && Board.board[4] != ' ' ||
                Board.board[4] == Board.board[1] && Board.board[1] == Board.board[7] && Board.board[4] != ' ' ||
                Board.board[7] == Board.board[6] && Board.board[6] == Board.board[8] && Board.board[7] != ' ')
            {
                Board.Status = (player == 'X' ? StatusType.WinO : StatusType.WinX);
                CLI.PrintEnd();
                return true;
            }
            else if (drawn_game)
            {
                Board.Status = StatusType.Draw;
                CLI.PrintEnd();
                return true;
            }
            return false;


        }
        public static void ChangeOfTurn(ref char player)
        {
            if (player == 'X' || player == 'x')
                player = 'O';
            else player = 'X';
        }

    }
}
