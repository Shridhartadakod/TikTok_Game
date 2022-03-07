using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTok_Game
{
    public class TicTacGame
    {
        public static void DrawBoard()
        {
            char[] board = new char[10];
            for (int i = 0; board.Length > 0; i++)
            {
                Console.WriteLine(board[i] = ' ');
            }
            Console.ReadLine();
        }
    }
}
