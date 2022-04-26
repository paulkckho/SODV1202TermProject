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
    public interface IBoardSettings
    {
        int Columns { get; set; }
        int Rows { get; set; }
        int WinningCount { get; set; }
        //int MoveCount { get; set; }
        //int Turn { get; set; }
    }
}
