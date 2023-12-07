using System;
using System.Numerics;
using System.Reflection.Emit;
using static System.Console;
using System.IO;

namespace testTicTActoe
{
    abstract public class Game
    {
        public int tempInt;
        public int PlayerNum { get; set; }
        public int WinnerNum { get; set; }
        public string? Header { get; set; }
        public int EntryMode { get; set; }
        public char TempChar { get; set; }

        HumanPlayer humanplayer = new HumanPlayer();
        ComputerPlayer computerplayer = new ComputerPlayer();
        TicTacToeGameBoard ticboard = new TicTacToeGameBoard();
        File file = new File();

        //Create game template 
        public virtual void PrintGameTemplate()
        {
            PrintHeader();
            file.ReadFile(ticboard.BoardArray);
            startGame();
        }


        //Display a header
        public virtual void PrintHeader()
        {
            WriteLine(" ");
            Header = "-+-+ WELCOME TO GAME BOARD +-+-";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Header.Length / 2)) + "}", Header));
            
        }
        //Displaying a game mode 
        public int DisplayGameMode()
        {
            WriteLine(" ");
            Write("Choose mode? Human vs Human: Enter 1 | Human vs Computer: Enter 2 ... ");

            do
            {
                int.TryParse(ReadLine(), out tempInt);
                EntryMode = tempInt;
                if (EntryMode == 1 || EntryMode == 2)
                {
                    break;

                }
                else
                {
                    WriteLine(" ");
                    Write("Invalid entry! Enter either '1' or '2' ... ");   

                }
            }
            while (true);

            return EntryMode;
        }

        //Display a board and ask a symbol and numbers
        public virtual void startGame()
        {
            PlayerNum = -1;
            WinnerNum = 0;
            EntryMode = DisplayGameMode();
            if (EntryMode == 1)
            {
                do
                {
                    //Human vs Human mode
                    PlayerNum = whoPlay(PlayerNum);
                    WriteLine(" ");
                    WriteLine("--------------------------------------------------");
                    WriteLine("Turn: Player " + PlayerNum);
                    WriteLine("");
                    ticboard.printBoard();
                    humanplayer.inputSymbol();
                    humanplayer.inputPieceLocation();
                    storeinArray(ticboard, humanplayer,file);
                    

                    WinnerNum = checkWinner(ticboard);

                }
                while (WinnerNum != 1 && WinnerNum != -1);
            }
            else
            {
                do
                {
                    //Human vs Computer mode
                    
                    PlayerNum = whoPlay(PlayerNum);
                    WriteLine(" "); 
                    WriteLine("--------------------------------------------------");
                    WriteLine("Turn: Player " + PlayerNum);
                    WriteLine(" ");
                    ticboard.printBoard();

                    //Player1: Human
                    if (PlayerNum == 1)
                    {
                        humanplayer.inputSymbol();
                        humanplayer.inputPieceLocation();
                        storeinArray(ticboard, humanplayer,file);
                        

                    }
                    //Player2: Computer
                    
                    else
                    {
                        computerplayer.inputSymbol();

                        TempChar = computerplayer.inputSymbol();
                        WriteLine(" ");
                        WriteLine("Symbol? ('1' or '2') ... "+TempChar);
                        WriteLine(" "); 
                        computerplayer.inputPieceLocation();
                        while (true)
                        {

                            if (ticboard.BoardArray[computerplayer.tempInt] == '1' || ticboard.BoardArray[computerplayer.tempInt] == '2')
                            {
                                WriteLine(" ");
                                WriteLine("Error! {0} is already marked! Enter again.", computerplayer.tempInt);
                                WriteLine(" ");
                                computerplayer.inputPieceLocation();
                            }
                            else
                            {
                                ticboard.BoardArray[computerplayer.tempInt] = TempChar;
     
                                break;

                            }
                        }
                    }
                    WinnerNum = checkWinner(ticboard);
                    ReadLine();

                }
                while (WinnerNum != 1 && WinnerNum != -1);
            }

            // Check if either player1 ir 2 won or the game is draw
            if (WinnerNum == 1)
            {
                WriteLine(" ");
                WriteLine("Winner is player {0}! Congrats!", PlayerNum);
            }
            else
            {
                WriteLine(" ");
                WriteLine("Draw! Nice game!");
            }
            Read();
        }
        //Make sure if input number has 1 or 2
        public virtual void storeinArray(TicTacToeGameBoard g, HumanPlayer hp,File f)
        {
            while (true)
            {

                if (g.BoardArray[hp.tempInt] == '1' || g.BoardArray[hp.tempInt] == '2')
                {
                    WriteLine(" ");
                    WriteLine("Error! {0} is already marked! Enter again.", hp.tempInt);

                    hp.inputPieceLocation();
                }
                else
                {
                    g.BoardArray[hp.tempInt] = hp.TempChar;
                 
                    f.WriteFile(g.BoardArray);
                    break;

                }
            }
        }

        //players take turn
        public int whoPlay(int plyNum)
        {

            if (plyNum.Equals(1))
            {
                return 2;
            }
            return 1;
        }
       
        //// Check if locations of pieces on the board meet requirement to win
        public abstract int checkWinner(TicTacToeGameBoard g);

    }

}
