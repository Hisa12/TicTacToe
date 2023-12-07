using System;
using System.Numerics;
using System.Reflection.Emit;
using static System.Console;
using System.IO;

namespace testTicTActoe
{
    public class File
    {
        private int read;
        private char QUIT = 'Y';
        private char CNTN = 'N';
        private char QUITorCNTN;
        private int command;
        public char OutPutChar { get; set; }

        //Write data to a file
        public void WriteFile(char[] array)
        {

            FileStream sb = new FileStream("MyFile.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(sb);
            WriteLine(" ");
            Write("Save the game and leave? Enter " + QUIT + " | Continue the game? Enter "+CNTN+ " ... ");

            while(true)
            {
                char.TryParse(ReadLine(), out QUITorCNTN);

                if (QUITorCNTN == 'Y' || QUITorCNTN == 'N')
                {
                    if (QUITorCNTN == 'Y')
                    {
                        sw.Write(array);
                        WriteLine(" ");
                        WriteLine("The game is saved! Bye bye!");
                        sw.Close();
                        Read();
                        System.Environment.Exit(1);
                    }
                    else
                    {
                        break;
                    }

                }
                else
                {
                    WriteLine(" ");
                    Write("Invalid Entry. Enter 'Y' or 'N' ... ");
                }
            }
           
        }

        //Read data to the program
        public void ReadFile(char[] array)
        {
            string path = "Myfile.txt";

            while (true)
            {
                WriteLine(" ");
                Write("Start new game: Enter '1' | Load saved game: Enter '2' ... ");
                if (!int.TryParse(ReadLine(), out command))
                {
                    command = -1;
                }
                if (command == 2)
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        char[] savedChar = new char[10];
                        while ((read = sr.ReadBlock(savedChar, 0, savedChar.Length)) > 0)
                        {
                            for (int i = 0; i < read; i++)
                            {
                                OutPutChar = savedChar[i];
                                array[i] = OutPutChar;
 
                            }
                        }
                    }
                    break;
                }
                else if (command == 1)
                {
                    break;
                }
                else
                {
                    WriteLine(" ");
                    Write("Invalid entry! ");
                    WriteLine(" ");
                }
            }

        }
    }
}

