using System;
using System.Numerics;
using System.Reflection.Emit;
using static System.Console;
using System.IO;

namespace testTicTActoe
{


    abstract public class GameBoard
    {
        //Arrays
        protected char[] boardArray = { '0', '1', '2', '3' };
        public char[] BoardArray
        {
            get { return boardArray; }
            set { boardArray = value; }
        }

        //Displaying a board
        public virtual void printBoard()
        {
            WriteLine(" ");
            WriteLine("              |-----------------| ");
            WriteLine("              |     |     |     | ");
            WriteLine("              |  {0}  |  {1}  |  {2}  | ", BoardArray[1], BoardArray[2], BoardArray[3]);
            WriteLine("              |_____|_____|_____| ");
            WriteLine(" ");


        }



    }
}

