using System;
/*
*  SODV 1202 Introduction to Object Oriented Programming 
*  SODV 1202 Term Project - Connect 4 Game 
*   Codes and Program designed by   :  Paul K Kho and Nhan Nguyen
*   Instructor                      :  Mahbub Murshed
*   Due                             :  April 22 2022
*
*   This game is designed for two players. Player One will always have the first move.
*   Each player will take turns. The first player to connect four in a row wins. 
*   
*/
namespace Connect4
{
    public class Human : IPlayer
    {
        public Human()
        {
        }

        public int PlayerTurn(State state)
        {
            Console.Clear();
            Console.WriteLine("CONNECT 4  FINAL PROJECT SODV1202\n");
            Console.WriteLine(state);
            Console.Write("Whats your move (1-7)?");
            char c = Console.ReadKey().KeyChar;
            int move;

            if (!int.TryParse(c.ToString(), out move))
            {
            }
            return move;
        }
    }
}
