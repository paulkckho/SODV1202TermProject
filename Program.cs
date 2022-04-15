
using System;

using System.Collections.Generic;
using System.Linq;


/*
 *  SODV 1202 Introduction to Object Oriented Programming 
 *  SODV 1202 Term Project - Connect 4 Game 
 *   Codes and Program designed by   :  Paul K Kho and Nhan Nguyen
 *   Instructor                      :  Mahbub Murshed
 *      Due                          :   April 22 2022
 *
 *   This game is designed for two players. Player One will always have the first move.
 *   Each player will take turns. The first player to connect four in a row wins. 
 *   If no name is enter, default names are Player One and Player Two. The user has the
 *       option of choosing a game mode: Player vs Player, Computer vs Player, Computer vs Computer
 */

namespace SODV_1202_Term_Project
{
      
    internal class Program
    {
        class Game  // Base Class
        {
            // Setup Constructors 
            public Game ()  
            {

            }
            public void InitialSettings()
            {
                // Call GameBoard Setup
                // Call Player Setup
                // Call Calculations 
            }
            public void DisplayResults()
            {
                // Display GameBoard
                // Show Player's names
                // Show Player's scores


            }
        }
        class Gameboard : Game
        {
            private char diskone;
            private char disktwo;

            // Compute start positions 
            // Compute end positions
            // Compute players' starting positions
            // Compute players' end positions
            // Set up game board

            public char Diskone  { get; set; }
            public char Disktwo  { get; set; }
            public Gameboard(char DiskOne, char DiskTwo)
            {
                DiskOne = diskone;
                DiskTwo = disktwo;
            }

            public Gameboard()
            {
            }

            public void GameSettings()
            {
               
            }
            public void ComputeGameposition()
            {
                // Initial game settings

            }
            private void ComputeGamestatus()
            {
                // Call Computation Methods

            }
            private string GameReset(string clearGameBoard)
            {
                return clearGameBoard;
            }
        }

        // Derived Class 
        class Player : Game
        {
            public string PlayerOne { get; private set; }
            public string PlayerTwo { get; private set; }

            private void PlayersSetup(string P1, string P2)
            {
                P1 = PlayerOne;
                P2 = PlayerTwo;
            }

            private void PlayerMove()
            {

            }


        }
        // Derived Class
        class Score : Gameboard
        {
            public Score(char DiskOne, char DiskTwo) : base(DiskOne, DiskTwo)
            {
            }

            public Score()
            {
            }

            public void startPosition()
            {

            }
            public void currentPosition()
            {

            }
            public void endPosition()
            {

            }
        }
        static void Main(string[] args)
        {
            int delay = 6000;
            Gameboard gameboardsetup = new Gameboard();
            Player gameplayersetup = new Player();
            Gameboard gameCal = new Score();
            string Instructions = "This is a two player game. Each player takes turn dropping a disk into a 9 X 9 game board. \n " +
              "The first player achieving connecting four disks in sequence, either vertical, horizontal or diagonal wins. \n " +
              "The game is a draw if all slots are full. The game will reset after sixty second delay.  ";

            // Display Initial game board on console 
            Console.Clear();
            Console.WriteLine("\t\t\t\t Classic Connect Four Game \n\n");
               Console.WriteLine(Instructions);
                  Thread.Sleep(delay);
            Console.WriteLine("Please press 'Q' to exit or any other key to continue... ");
                char choice = (char)Console.Read();
                  Thread.Sleep(delay);
            if (choice == 'q')
            {
                Console.WriteLine(" Game's Over. Thank you for visiting. Good bye...");
            }
            else
            { 
                Console.WriteLine("Let the game begin!\n\n");
                Console.WriteLine();
                // Call Player Class. Set up player 
                // Call Game Board Class. Set up game board
                gameboardsetup.GameSettings();
                  
              
            }
           
            Console.Read();
        }
    }
}


