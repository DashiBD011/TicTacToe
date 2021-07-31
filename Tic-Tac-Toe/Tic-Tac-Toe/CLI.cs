using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    public static class CLI
    {
        public static void PrintBoard()
        {
            Console.Clear();
            Console.Write("\n\n\n\n\n\n\n\n");
            for (int i = 6; i >= 0; i -= 3)
            {
                Console.Write("\t\t\t\t\t\t ");

                for (int j = 0; j < 3; j++)
                {
                    PrintInfo($" {Board.board[i + j]}");
                    if (j != 2) Console.Write(" | ");
                }
                Console.WriteLine();

                Console.Write("\t\t\t\t\t\t ");
                if (i != 0) Console.Write("--- --- ---");
                Console.WriteLine();

            }
        }
        public static void PrintEnd()
        {
            switch (Board.Status)
            {
                case StatusType.Draw:
                    PrintDraw("Draw");
                    break;
                case StatusType.WinO:
                    PrintWin("Win O");
                    break;
                case StatusType.WinX:
                    PrintWin("Win X");
                    break;
            }
        }
        private static void Print(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        private static void PrintWin(string message)
        {
            Print(message, ConsoleColor.Red);
        }
        private static void PrintDraw(string message)
        {
            Print(message, ConsoleColor.Gray);
        }
        
        private static void PrintInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(message);
            Console.ResetColor();
        }
        
    }
}

