using Chess_board;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace move_chess
{
    class Program
    {
        static ChessBoardModel2 myBoard = new ChessBoardModel2(8);

        static void Main(string[] args)
        {
            Console.WriteLine("X- the position of the piece on the board, + legal moves marked");
            //generate empty chess board
            printBoard(myBoard);
            //ask the user's X Y cordy where you want to put the pawn
            Cell currentCell = SetCurentCell();
            currentCell.curentlyBusy = true;


          
            string Piece = Console.ReadLine();
            string Choice = Piece.ToUpper();
            myBoard.MarkNextLegalMove(currentCell, Choice);


            printBoard(myBoard);
            Console.ReadLine();
        }

        
        public static Cell SetCurentCell()
        {
            



            var currentRow = 0;
            var currentColumn = 0;

            // throwing an exception
            {
               ;
                try
                {
                   // ChessBoardModel2 myBoard;
                    do
                    {
                        Console.WriteLine("Enter the current number in row: 1-8");


                        currentRow = Convert.ToInt32(Console.ReadLine());
                        currentRow = currentRow - 1;
                    } while (currentRow >=  8 || currentRow < 0); ;







                    do
                    {
                        Console.WriteLine("Enter the current number in colums: 1-8");

                        currentColumn = Convert.ToInt32(Console.ReadLine());
                        currentColumn = currentColumn - 1;
                    } while (currentColumn >= 8 || currentColumn < 0);
                        
                }
          
                catch (FormatException)
                {
                 Console.WriteLine("Error occurred");

                }

          
            } 
            Console.WriteLine("What kind of chess piece would you like to place ont the board? Knight, King, Queen, Rook, Bishop");
           
            
           



            return myBoard.theGrid[currentRow, currentColumn];
            

        }

       private static void printBoard(ChessBoardModel2 myBoard)
        {

            for (int k = 0; k < 1; k++)
            {
                Console.WriteLine("=========================================================="); 
            }
            //generates checkerboards
            for (int i = 0; i < myBoard.Size; i++)
                {

                    for (int j = 0; j < myBoard.Size; j++)
                    {

                        Cell c = myBoard.theGrid[i, j];

                        if (c.curentlyBusy == true) { Console.Write(" ! X ! "); }
                        else if (c.legalMove == true) { Console.Write(" ! + ! "); }

                        else Console.Write(" !___! ");

                    }
                    Console.WriteLine("");
                }
            
            Console.WriteLine("==========================================================");
        }


    }
}
