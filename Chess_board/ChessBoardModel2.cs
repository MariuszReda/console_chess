using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Chess_board
{
    public class ChessBoardModel2
    {
        //the size of the board usually (8x8)
        public int Size { get; set; }
        //array 2D of type Cell
        public Cell[,] theGrid { get; set; } 

        //Constructor
        public ChessBoardModel2(int s) 
        {
            //initial size of the board defines s
            Size = s;
            //creat new 2D array of typ Cell
            theGrid = new Cell[Size, Size];
            //fill the 2d array with new cell each with unique coord
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j] = new Cell(i, j);

                }
            }
        }
        //function to check it is (safe)legal moves
        private bool isSafe(int x, int y) 
        { 
           
           if(x < Size && y < Size && 0 <= x && 0 <= y)
            {
                
                return true;
            }
            
            return false;
        }
     
    
        
        public void MarkNextLegalMove(Cell currentCell, string chessPiece)
        {
            //clear all previous legal move
            for (int f = 0; f < Size; f++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[f, j].legalMove = false;
                    theGrid[f, j].curentlyBusy = false;

                }
                // all legal combat moves piece
                switch (chessPiece)
                {
                    case "KNIGHT":
                        if (isSafe(currentCell.rowNumber + 2, currentCell.columnNumber + 1))
                        {
                            theGrid[currentCell.rowNumber + 2, currentCell.columnNumber + 1].legalMove = true;
                        }
                        if (isSafe(currentCell.rowNumber + 2, currentCell.columnNumber - 1))
                        {
                            theGrid[currentCell.rowNumber + 2, currentCell.columnNumber - 1].legalMove = true;
                        }
                        if (isSafe(currentCell.rowNumber - 2, currentCell.columnNumber + 1))
                        {
                            theGrid[currentCell.rowNumber - 2, currentCell.columnNumber + 1].legalMove = true;
                        }
                        if (isSafe(currentCell.rowNumber - 2, currentCell.columnNumber + 1))
                        {
                            theGrid[currentCell.rowNumber - 2, currentCell.columnNumber - 1].legalMove = true;
                        }
                        if (isSafe(currentCell.rowNumber - 2, currentCell.columnNumber + 1))
                        {
                            theGrid[currentCell.rowNumber + 1, currentCell.columnNumber + 2].legalMove = true;
                        }
                        if (isSafe(currentCell.rowNumber - 2, currentCell.columnNumber + 1))
                        {
                            theGrid[currentCell.rowNumber + 1, currentCell.columnNumber - 2].legalMove = true;
                        }
                        if (isSafe(currentCell.rowNumber - 2, currentCell.columnNumber + 1))
                        {
                            theGrid[currentCell.rowNumber - 1, currentCell.columnNumber + 2].legalMove = true;
                        }
                        if (isSafe(currentCell.rowNumber - 2, currentCell.columnNumber + 1))
                        {
                            theGrid[currentCell.rowNumber - 1, currentCell.columnNumber - 2].legalMove = true;
                        }

                        break;

                    case "KING":

                        int j = 1;
                        if (isSafe(currentCell.rowNumber + j, currentCell.columnNumber))
                        {
                            theGrid[currentCell.rowNumber + j, currentCell.columnNumber].legalMove = true;
                        }
                        if (isSafe(currentCell.rowNumber - j, currentCell.columnNumber))
                        {
                            theGrid[currentCell.rowNumber - j, currentCell.columnNumber].legalMove = true;
                        }
                        if (isSafe(currentCell.rowNumber + j, currentCell.columnNumber + j))
                        {
                            theGrid[currentCell.rowNumber + j, currentCell.columnNumber + j].legalMove = true;
                        }
                        if (isSafe(currentCell.rowNumber + j, currentCell.columnNumber - j))
                        {
                            theGrid[currentCell.rowNumber + j, currentCell.columnNumber - j].legalMove = true;
                        }
                        if (isSafe(currentCell.rowNumber, currentCell.columnNumber + j))
                        {
                            theGrid[currentCell.rowNumber, currentCell.columnNumber + j].legalMove = true;
                        }
                        if (isSafe(currentCell.rowNumber, currentCell.columnNumber - j))
                        {
                            theGrid[currentCell.rowNumber, currentCell.columnNumber - j].legalMove = true;
                        }
                        if (isSafe(currentCell.rowNumber - j, currentCell.columnNumber + j))
                        {
                            theGrid[currentCell.rowNumber - j, currentCell.columnNumber + j].legalMove = true;
                        }
                        if (isSafe(currentCell.rowNumber - j, currentCell.columnNumber - j))
                        {
                            theGrid[currentCell.rowNumber - j, currentCell.columnNumber - j].legalMove = true;
                        }
                        break;
                    case "ROOK":
                        for (int i = 0; i <= Size; i++)
                        {
                            if (isSafe(currentCell.rowNumber + i, currentCell.columnNumber))
                            {
                                theGrid[currentCell.rowNumber + i, currentCell.columnNumber].legalMove = true;
                            }
                            if (isSafe(currentCell.rowNumber - i, currentCell.columnNumber))
                            {
                                theGrid[currentCell.rowNumber - i, currentCell.columnNumber].legalMove = true;
                            }
                            if (isSafe(currentCell.rowNumber, currentCell.columnNumber - i))
                            {
                                theGrid[currentCell.rowNumber, currentCell.columnNumber - i].legalMove = true;
                            }
                            if (isSafe(currentCell.rowNumber, currentCell.columnNumber + i))
                            {
                                theGrid[currentCell.rowNumber, currentCell.columnNumber + i].legalMove = true;
                            }
                        }
                      
                            
                        break;
                    case "BISHOP":
                        for (int i = 0; i <= Size; i++)
                        {


                            if (isSafe(currentCell.rowNumber + i, currentCell.columnNumber + i))
                            {
                                theGrid[currentCell.rowNumber + i, currentCell.columnNumber + i].legalMove = true;
                            }
                            if (isSafe(currentCell.rowNumber - i, currentCell.columnNumber + i))
                            {
                                theGrid[currentCell.rowNumber - i, currentCell.columnNumber + i].legalMove = true;
                            }
                            if (isSafe(currentCell.rowNumber + i, currentCell.columnNumber - i))
                            {
                                theGrid[currentCell.rowNumber + i, currentCell.columnNumber - i].legalMove = true;
                            }
                            if (isSafe(currentCell.rowNumber - i, currentCell.columnNumber - i))
                            {
                                theGrid[currentCell.rowNumber - i, currentCell.columnNumber - i].legalMove = true;
                            }

                        }
                        


                        break;


                    case "QUEEN":
                        for (int i = 0; i <= Size; i++)
                        {


                            if (isSafe(currentCell.rowNumber + i, currentCell.columnNumber + i))
                            {
                                theGrid[currentCell.rowNumber + i, currentCell.columnNumber + i].legalMove = true;
                            }
                            if (isSafe(currentCell.rowNumber - i, currentCell.columnNumber + i))
                            {
                                theGrid[currentCell.rowNumber - i, currentCell.columnNumber + i].legalMove = true;
                            }
                            if (isSafe(currentCell.rowNumber + i, currentCell.columnNumber - i))
                            {
                                theGrid[currentCell.rowNumber + i, currentCell.columnNumber - i].legalMove = true;
                            }
                            if (isSafe(currentCell.rowNumber - i, currentCell.columnNumber - i))
                            {
                                theGrid[currentCell.rowNumber - i, currentCell.columnNumber - i].legalMove = true;
                            }

                        }
                        for (int i = 0; i <= Size; i++)
                        {
                            if (isSafe(currentCell.rowNumber + i, currentCell.columnNumber))
                            {
                                theGrid[currentCell.rowNumber + i, currentCell.columnNumber].legalMove = true;
                            }
                            if (isSafe(currentCell.rowNumber - i, currentCell.columnNumber))
                            {
                                theGrid[currentCell.rowNumber - i, currentCell.columnNumber].legalMove = true;
                            }
                            if (isSafe(currentCell.rowNumber, currentCell.columnNumber - i))
                            {
                                theGrid[currentCell.rowNumber, currentCell.columnNumber - i].legalMove = true;
                            }
                            if (isSafe(currentCell.rowNumber, currentCell.columnNumber + i))
                            {
                                theGrid[currentCell.rowNumber, currentCell.columnNumber + i].legalMove = true;
                            }
                        }


                        break;

                    default:

                        break;

                }
                theGrid[currentCell.rowNumber, currentCell.columnNumber].curentlyBusy = true;
            }

        }


    }
}

