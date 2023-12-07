using System;
using System.Numerics;
using System.Reflection.Emit;
using static System.Console;
using System.IO;

namespace testTicTActoe
{


    public class TicTacToeGameBoard: GameBoard
    {
        //Arrays
        private new char[] boardArray = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public new char[] BoardArray
        {
            get { return boardArray; }
            set { boardArray = value; }
        }

        //Displaying a board
        public override void printBoard()
        {
            WriteLine(" ");
            WriteLine("              |-----------------| ");
            WriteLine("              |     |     |     | ");
            WriteLine("              |  {0}  |  {1}  |  {2}  | ", BoardArray[1], BoardArray[2], BoardArray[3]);
            WriteLine("              |_____|_____|_____| ");
            WriteLine("              |     |     |     | ");
            WriteLine("              |  {0}  |  {1}  |  {2}  | ", BoardArray[4], BoardArray[5], BoardArray[6]);
            WriteLine("              |_____|_____|_____| ");
            WriteLine("              |     |     |     | ");
            WriteLine("              |  {0}  |  {1}  |  {2}  | ", BoardArray[7], BoardArray[8], BoardArray[9]);
            WriteLine("              |     |     |     | ");
            WriteLine("              |-----------------| ");
            WriteLine(" ");
                

        }
    }
}

