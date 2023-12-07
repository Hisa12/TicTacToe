using System;
using System.Numerics;
using System.Reflection.Emit;
using static System.Console;
using System.IO;

namespace testTicTActoe
{
    abstract public class Player
    {
        public char tempChar;
        public int tempInt = 0;
        private char entryPiece;
        private bool isTrue;
        private int entryPosition;

        public char TempChar
        {
            get
            {
                return tempChar;
            }
            set
            {
                tempChar = value;
            }
        }
        public int TempInt
        {
            get
            {
                return tempInt;
            }
            set
            {
                tempInt = value;
            }
        }
        public char EntryPiece
        {
            get
            {
                return entryPiece;
            }
            set
            {
                
                 entryPiece = value;
               
            }
        }
        public bool IsTrue
        {
            get
            {
                return isTrue;
            }
            set
            {
                isTrue = value;
            }
        }
        public int EntryPosition
        {
            get
            {
                return entryPosition;
            }
            set
            {
                entryPosition = value;
            }
        }

        //Promot a user for 1 or 2
        public virtual void inputSymbol()
        {
            Write("Symbol? ('1' or '2'). If need help, type '/' ... ");
            
            while (true)
            {
                char.TryParse(ReadLine(), out tempChar);
                if (tempChar == '1' || tempChar == '2' || tempChar == '/')
                {
                    if (tempChar == '/')
                    {
                        TicTacToeHelpSystem ticHelpSystem = new TicTacToeHelpSystem();
                        ticHelpSystem.showInstruction();

                        IsTrue = false;
                        Write("Symbol? ('1' or '2'). If need help, type '/'... ");
                        
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
                    Write("Invalid entry! Enter either '1' or '2', If you need help, enter '/' ... ");
                    
                }
            }

        }
        //Prompt a user for one location number
        public virtual void inputPieceLocation()
        {

            while (true)
            {
                WriteLine(" ");
                Write("The number on the board? (1 to 9) ... ");
                if (!int.TryParse(ReadLine(), out tempInt))
                {
                    tempInt = -1;
                }

                if (tempInt == 1 || tempInt == 2 || tempInt == 3)
                {

                    break;
                }
                else
                {
                    WriteLine(" ");
                    WriteLine("Invalid entry! Enter the number from 1 to 9");
                    WriteLine(" ");
                }
            }

        }
    }
}

