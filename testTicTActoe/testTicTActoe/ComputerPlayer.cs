using System;
using System.Numerics;
using System.Reflection.Emit;
using static System.Console;
using System.IO;

namespace testTicTActoe
{
    public class ComputerPlayer : Player
    {
        public char[] tempCharArray = { 'O', 'X' };
        public int RndmNum { get; set; }

        //By using Random(), computer can input a random symbol
        Random rndm = new Random();
        public new char inputSymbol()
        {

            RndmNum = rndm.Next(0, 2);
            return tempCharArray[RndmNum];

        }
        //By using Random(), computer can input a random number
        public override void inputPieceLocation()
        {
            tempInt = rndm.Next(1, 9);
            WriteLine("The number on the board? (1 to 9) ... " + TempInt);

        }
    }
}

