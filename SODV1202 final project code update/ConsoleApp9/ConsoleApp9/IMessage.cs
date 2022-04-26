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
    public interface IMessage
    {
        void Write(State GameState);
        void WriteLine(string message);
        void Clear();
    }
}
