using System;
using System.Numerics;
using System.Reflection.Emit;
using static System.Console;
using System.IO;

namespace testTicTActoe
{
    public class HumanPlayer: Player
    {

        //Promot a user for X or O
        public override void inputSymbol()
        {
            Write("Symbol? ('X' or 'O'). If need help, type '/' ... ");

            while (true)
            {
                char.TryParse(ReadLine(), out tempChar);
                if (tempChar == 'O' || tempChar == 'X' || tempChar == '/')
                {
                    if (tempChar == '/')
                    {
                        TicTacToeHelpSystem ticHelpSystem = new TicTacToeHelpSystem();
                        ticHelpSystem.showInstruction();

                        IsTrue = false;
                        Write("Symbol? ('X' or 'O'). If need help, type '/'... ");

                    }
                    else
                    {
                        IsTrue = true;
                        break;
                    }
                }
                else
                {
                    WriteLine(" ");
                    Write("Invalid entry! Enter either 'X' or 'O', If you need help, enter '/' ... ");

                }
            }

        }
        //Prompt a user for one location number
        public override void inputPieceLocation()
        {

            while (true)
            {
                WriteLine(" ");
                Write("The number on the board? (1 to 9) ... ");
                if (!int.TryParse(ReadLine(), out tempInt))
                {
                    tempInt = -1;
                }

                if (tempInt == 1 || tempInt == 2 || tempInt == 3 || tempInt == 4 || tempInt == 5
                     || tempInt == 6 || tempInt == 7 || tempInt == 8 || tempInt == 9)
                {

                    break;
                }
                else
                {
                    WriteLine(" ");
                    WriteLine("Invalid entry! Enter the number from 1 to 9");
                    
                }
            }

        }
    }
}

