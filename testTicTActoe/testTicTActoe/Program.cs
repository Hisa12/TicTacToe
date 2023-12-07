using System;
using System.Numerics;
using System.Reflection.Emit;
using static System.Console;
using System.IO;

namespace testTicTActoe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WildTicTacToeGame tictactoegame = new WildTicTacToeGame();
            tictactoegame.PrintGameTemplate();
        }
    }
}