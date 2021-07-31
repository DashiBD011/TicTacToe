using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    public enum StatusType
    {
        Draw, WinX, WinO, Game
    }
    public static class Board
    {
        public static char[] board = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static StatusType Status;

    }
}
