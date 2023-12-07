using System;
using System.Numerics;
using System.Reflection.Emit;
using static System.Console;
using System.IO;

namespace testTicTActoe
{
    class TicTacToeHelpSystem: HelpSystem
    {

        public override void showInstruction()
        {
            WriteLine("");
            WriteLine("        +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
            WriteLine("        |                        Wild Tic Tac Toe                         |");
            WriteLine("        |                                                                 |");
            WriteLine("        |  Step1: Choose 'X' or 'O' as a symbol.                          |");
            WriteLine("        |  Step2: choose a number (1-9) to place the piece on the board.  |");
            WriteLine("        |                                                                 |");
            WriteLine("        |  a Player who create a three-in-a-row of marks is winner!       |");
            WriteLine("        |                                                                 |");
            WriteLine("        |    Example...                                                   |");
            WriteLine("        |    |-----------------|                                          |");
            WriteLine("        |    |     |     |     |                                          |");
            WriteLine("        |    |  X  |  X  |  X  | <- the same three symbols are in a row   |");
            WriteLine("        |    |_____|_____|_____|                                          |");
            WriteLine("        |    |     |     |     |                                          |");
            WriteLine("        |    |     |     |     |                                          |");
            WriteLine("        |    |_____|_____|_____|                                          |");
            WriteLine("        |    |     |     |     |                                          |");
            WriteLine("        |    |     |     |     |                                          |");
            WriteLine("        |    |     |     |     |                                          |");
            WriteLine("        |    |-----------------|                                          |");
            WriteLine("        |                                                                 |");
            WriteLine("        +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
            WriteLine("");
        }

    }
}

