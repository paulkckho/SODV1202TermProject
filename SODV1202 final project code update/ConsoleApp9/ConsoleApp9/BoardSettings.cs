namespace Connect4
{
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
    public class BoardSettings : IBoardSettings
    {
        public int Columns { get; set; }
        public int Rows { get; set; }
        public int WinningCount { get; set; }
  
        //public int MoveCount { get; set; }
        //public int Turn { get; set; }
    }
}
