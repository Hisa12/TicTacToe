using System;
using System.Numerics;
using System.Reflection.Emit;
using static System.Console;
using System.IO;

namespace testTicTActoe
{
    public class WildTicTacToeGame:Game
    {

        HumanPlayer humanplayer = new HumanPlayer();
        ComputerPlayer computerplayer = new ComputerPlayer();
        TicTacToeGameBoard ticboard = new TicTacToeGameBoard();
        File file = new File();

        public override void PrintGameTemplate()
        {
            PrintHeader();
            file.ReadFile(ticboard.BoardArray);
            startGame();
        }
        
        //Display a board and ask a symbol and numbers
        public override void startGame()
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
                    storeinArray(ticboard, humanplayer, file);
                   

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
                        storeinArray(ticboard, humanplayer, file);
                       
                    }
                    //Player2: Computer
                    else
                    {
                        computerplayer.inputSymbol();

                        TempChar = computerplayer.inputSymbol();
                        WriteLine(" ");
                        WriteLine("Symbol? ('X' or 'O') ... " + TempChar);
                        WriteLine(" ");
                        computerplayer.inputPieceLocation();
                        while (true)
                        {

                            if (ticboard.BoardArray[computerplayer.tempInt] == 'X' || ticboard.BoardArray[computerplayer.tempInt] == 'O')
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
        //Check if input number has X or O
        public override void storeinArray(TicTacToeGameBoard g, HumanPlayer hp, File f)
        {
            while (true)
            {

                if (g.BoardArray[hp.tempInt] == 'X' || g.BoardArray[hp.tempInt] == 'O')
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

        //// Check if locations of pieces on the board meet requirement to win
        public override int checkWinner(TicTacToeGameBoard g)
        {
            if (g.BoardArray[1] == g.BoardArray[2] && g.BoardArray[2] == g.BoardArray[3])
            {
                return 1;
            }
            else if (g.BoardArray[4] == g.BoardArray[5] && g.BoardArray[5] == g.BoardArray[6])
            {
                return 1;
            }
            else if (g.BoardArray[7] == g.BoardArray[8] && g.BoardArray[8] == g.BoardArray[9])
            {
                return 1;
            }
            else if (g.BoardArray[1] == g.BoardArray[4] && g.BoardArray[4] == g.BoardArray[7])
            {
                return 1;
            }
            else if (g.BoardArray[2] == g.BoardArray[5] && g.BoardArray[5] == g.BoardArray[8])
            {
                return 1;
            }
            else if (g.BoardArray[3] == g.BoardArray[6] && g.BoardArray[6] == g.BoardArray[9])
            {
                return 1;
            }
            else if (g.BoardArray[1] == g.BoardArray[5] && g.BoardArray[5] == g.BoardArray[9])
            {
                return 1;
            }
            else if (g.BoardArray[3] == g.BoardArray[5] && g.BoardArray[5] == g.BoardArray[7])
            {
                return 1;
            }
            else if (g.BoardArray[1] != '1' && g.BoardArray[2] != '2' && g.BoardArray[3] != '3' && g.BoardArray[4] != '4' && g.BoardArray[5] != '5' && g.BoardArray[6] != '6' && g.BoardArray[7] != '7' && g.BoardArray[8] != '8' && g.BoardArray[9] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

}
