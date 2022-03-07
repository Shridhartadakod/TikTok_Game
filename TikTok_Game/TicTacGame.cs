using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTok_Game
{
    public class TicTacGame
    {
        public static char player, computer;
        public static void DrawBoard()
        {
            char[] board = new char[10];
            for (int i = 1; board.Length < 10; i++)
            {
                Console.WriteLine(board[i] = ' ');
            }
            Console.ReadLine();
        }

        public static void PlayerInput()
        {
            player = Convert.ToChar(Console.ReadLine().ToUpper());
            switch (player)
            {
                case 'X':
                    computer O;
                    Console.WriteLine("Player Input:" + player);
                    Console.WriteLine("Computer char is :" + computer);
                    break;
                case 'O':
                    computer X;
                    Console.WriteLine("Player Input:" + player);
                    Console.WriteLine("Computer char is :" + computer);
                    break;
                default:
                    Console.WriteLine("invalid");
            }
        }
    }
}
