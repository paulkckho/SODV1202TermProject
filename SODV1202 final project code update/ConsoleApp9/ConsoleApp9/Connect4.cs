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
    public class Connect4
    {
        internal State GameState; //Current game state.
        public bool Winner; //Winner found.
        public IPlayer Player1;
        public IPlayer Player2;
        protected IMessage _Message;

        /// <summary>
        /// Initialises a new game with specifed grid size.
        /// </summary>
        /// <param name="gridColumns">No. of columns in grid</param>
        /// <param name="gridRows">No. of rows in grid</param>
        public Connect4(IBoardSettings boardSettings, IMessage message)
        {
            //Initialise
            _Message = message;
            Winner = false;
            GameState = new State(boardSettings);
        }
   
        public bool Turn(int move)
        {
            try
            {
                State state = GameState.Move(move);

                if (state == null)
                    return false;

                GameState = state;
            }
            catch (Exception ex)
            {
                _Message.WriteLine(string.Format("Invalid move - {0}", ex.Message));
            }
            return true;
        }

        /// <summary>
        /// Checks the state of the game to see if there is a winning sequence.
        /// </summary>
        /// <returns>//0=No Winner; 1=Player1 wins; 2=Player2 wins; -1 = Tie</returns>
        public int CheckGameStateForWin()
        {
            return GameState.CheckWin(); //0=No Winner; 1=Player1 wins; 2=Player2 wins; -1 = Tie
        }

        public void PlayGame()
        {
            int w = 0;
            while (!Winner)
            {
                if (GameState.Turn == 1)
                    Turn(Player1.PlayerTurn(GameState));
                else
                    Turn(Player2.PlayerTurn(GameState));

                w = CheckGameStateForWin();
                Winner = (w != 0);

                //Console.Clear();
                //Console.WriteLine(GameState);
            }

            _Message.Clear();
            _Message.WriteLine("CONNECT 4  FINAL PROJECT SODV1202\n");
            _Message.Write(GameState);

            if (w == -1)
                Console.WriteLine(" ITS A TIE!!!");
            else
                Console.WriteLine(string.Format("PLAYER {0} IS THE WINNER!", (w == 1) ? "1" : "2"));
        }
    }
}
